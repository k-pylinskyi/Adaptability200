using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Adaptability200
{
    /// <summary>
    /// Логика взаимодействия для PasswordPage.xaml
    /// </summary>
    public partial class PasswordPage : Page
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "jd18AAgjGJbiAdxfbEkmvjPzwooe8k4b2eKuP2vS",
            BasePath = "https://adaptability200-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        public PasswordPage()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
        }

        private async void ConfirmPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            FirebaseResponse passwordResp = await client.GetTaskAsync("Password/node");
            Password paswordObj = passwordResp.ResultAs<Password>();

            if (PreviousPasswordBox.Password.Equals(paswordObj.password))
            {
                var newPassword = new Password
                {
                    password = NewPasswordBox.Password
                };

                SetResponse PasswordResp = await client.SetTaskAsync("Password/node", newPassword);

                MessageBox.Show("Ви змінили пароль");
            }
            else
            {
                MessageBox.Show("пароль невірний спробуйте знову");
                PreviousPasswordBox.Password = string.Empty;
                NewPasswordBox.Password = string.Empty;
            }

        }
    }
}
