using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Adaptability200.View
{
    /// <summary>
    /// Логика взаимодействия для DBView.xaml
    /// </summary>
    public partial class DBView : UserControl
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "jd18AAgjGJbiAdxfbEkmvjPzwooe8k4b2eKuP2vS",
            BasePath = "https://adaptability200-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        public DBView()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
            FindByNameButton.IsEnabled = false;
            UpdateButton.IsEnabled = false;
        }

        private async void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            FirebaseResponse cntResp = await client.GetTaskAsync("Counter/node");
            Counter cntObj = cntResp.ResultAs<Counter>();

            int i = 0;
            int cnt = Convert.ToInt32(cntObj.cnt);

            List<Person> employeeList = new List<Person>();

            while (i < cnt)
            {
                i++;

                FirebaseResponse employeeResp = await client.GetTaskAsync("Information/" + i);
                Person employeeObj = employeeResp.ResultAs<Person>();

                employeeList.Add(new Person()
                {
                    Id = employeeObj.Id,
                    Name = employeeObj.Name,
                    Surname = employeeObj.Surname,
                    FatherName = employeeObj.FatherName,
                    D = employeeObj.D,
                    PR = employeeObj.PR,
                    KP = employeeObj.KP,
                    MN = employeeObj.MN,
                    VPS = employeeObj.VPS,
                    DAP = employeeObj.DAP,
                    SR = employeeObj.SR,
                    OAP = employeeObj.OAP,
                });
            }

            BaseGrid.ItemsSource = employeeList;
        }

        private async void PasswordButton_Click(object sender, RoutedEventArgs e)
        {
            FirebaseResponse passwordResp = await client.GetTaskAsync("Password/node");
            Password paswordObj = passwordResp.ResultAs<Password>();

            if (PassBox.Password.Equals(paswordObj.password))
            {
                FindByNameButton.IsEnabled = true;
                UpdateButton.IsEnabled = true;
            }
            else MessageBox.Show("пароль невірний спробуйте знову");
        }

        private async void FindByNameButton_Click(object sender, RoutedEventArgs e)
        {
            FirebaseResponse cntResp = await client.GetTaskAsync("Counter/node");
            Counter cntObj = cntResp.ResultAs<Counter>();

            int i = 0;
            int cnt = Convert.ToInt32(cntObj.cnt);

            List<Person> employeeList = new List<Person>();

            while (i < cnt)
            {
                i++;

                FirebaseResponse employeeResp = await client.GetTaskAsync("Information/" + i);
                Person employeeObj = employeeResp.ResultAs<Person>();

                if (employeeObj.Surname.Equals(FindByNameBox.Text))
                {
                    employeeList.Add(new Person()
                    {
                        Id = employeeObj.Id,
                        Name = employeeObj.Name,
                        Surname = employeeObj.Surname,
                        FatherName = employeeObj.FatherName,
                        D = employeeObj.D,
                        PR = employeeObj.PR,
                        KP = employeeObj.KP,
                        MN = employeeObj.MN,
                        VPS = employeeObj.VPS,
                        DAP = employeeObj.DAP,
                        SR = employeeObj.SR,
                        OAP = employeeObj.OAP,
                    });
                }
            }

            BaseGrid.ItemsSource = employeeList;
        }

    }
}
