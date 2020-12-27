using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Adaptability200.View
{
    /// <summary>
    /// Логика взаимодействия для PasswordView.xaml
    /// </summary>
    public partial class PasswordView : UserControl
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "jd18AAgjGJbiAdxfbEkmvjPzwooe8k4b2eKuP2vS",
            BasePath = "https://adaptability200-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        public PasswordView()
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
