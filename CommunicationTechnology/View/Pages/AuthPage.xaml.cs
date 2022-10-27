using CommunicationTechnology.Model;
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

namespace CommunicationTechnology.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        Core db = new Core();
        List<Client> arrayClients;
        public AuthPage()
        {
            InitializeComponent();
            arrayClients = db.context.Client.ToList();
        }

        private void SingInButton_Click(object sender, RoutedEventArgs e)
        {
            if (LogInTextBox.Text!=String.Empty
                && AuthPasswordBox.Password!=String.Empty
                && !String.IsNullOrWhiteSpace(LogInTextBox.Text)
                && !String.IsNullOrWhiteSpace(AuthPasswordBox.Password))
            {
                Client activeUser = arrayClients
                .Where(x => x.Login == LogInTextBox.Text && x.Password == AuthPasswordBox.Password).FirstOrDefault();
                if (activeUser!=null)
                {
                    this.NavigationService.Navigate(new PersonalPage());
                }
                else
                {
                    MessageBox.Show("Введены неправильные данные");
                }
            }
            else
            {
                MessageBox.Show("Не введен логин или пароль!");
            }
        }
    }
}
