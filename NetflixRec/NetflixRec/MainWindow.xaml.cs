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

namespace NetflixRec
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            SignIn.Visibility = Visibility.Hidden;
            LoginPage.Visibility = Visibility.Visible;
            LoginBorder.Visibility = Visibility.Visible;
            UserNameBox.Foreground = Brushes.Gray;
            PassWordBox.Foreground = Brushes.Gray;
            UserNameBox.Text = "Insert Username Here";
            PassWordBox.Text = "Insert Password Here";
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            SignIn.Visibility = Visibility.Hidden;
            LoginPage.Visibility = Visibility.Hidden;
            LoginBorder.Visibility = Visibility.Hidden;
            SignOut.Visibility = Visibility.Visible;
            CreateUser.Margin = new Thickness(1025, 33, 0, 0);
            MovieInfoGrid.Visibility = Visibility.Visible;
        }

        private void SignOut_Click(object sender, RoutedEventArgs e)
        {
            SignOut.Visibility = Visibility.Hidden;
            SignIn.Visibility = Visibility.Visible;
            CreateUser.Margin = new Thickness(0, 405, 0, 0);
            MovieInfoGrid.Visibility = Visibility.Hidden;
        }

        private void CreateUser_Click(object sender, RoutedEventArgs e)
        {
            SignIn.Visibility = Visibility.Hidden;
            CreateUserForm.Visibility = Visibility.Visible;
            CreateUserFormBorder.Visibility = Visibility.Visible;
            FirstNameCreatedForm.Foreground = Brushes.Gray;
            LastNameCreatedForm.Foreground = Brushes.Gray;
            UserNameCreatedForm.Foreground = Brushes.Gray;
            PasswordCreatedForm.Foreground = Brushes.Gray;
            FirstNameCreatedForm.Text = "First Name";
            LastNameCreatedForm.Text = "Last Name";
            UserNameCreatedForm.Text = "Username";
            PasswordCreatedForm.Text = "Password";
            MovieInfoGrid.Visibility = Visibility.Hidden;
        }

        private void UserNameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            UserNameBox.Clear();
            UserNameBox.Foreground = Brushes.Black;
        }

        private void UserNameBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if(UserNameBox.Text == "")
            {
                UserNameBox.Foreground = Brushes.Gray;
                UserNameBox.Text = "Insert Username Here";
            }
        }

        private void PassWordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if(PassWordBox.Text == "")
            {
                PassWordBox.Foreground = Brushes.Gray;
                PassWordBox.Text = "Insert Password Here";
            }
            
        }

        private void PassWordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PassWordBox.Clear();
            PassWordBox.Foreground = Brushes.Black;
        }

        private void FirstNameCreatedForm_GotFocus(object sender, RoutedEventArgs e)
        {
            FirstNameCreatedForm.Clear();
            FirstNameCreatedForm.Foreground = Brushes.Black;
        }

        private void FirstNameCreatedForm_LostFocus(object sender, RoutedEventArgs e)
        {
            if (FirstNameCreatedForm.Text == "")
            {
                FirstNameCreatedForm.Foreground = Brushes.Gray;
                FirstNameCreatedForm.Text = "First Name";
            }
        }

        private void LastNameCreatedForm_GotFocus(object sender, RoutedEventArgs e)
        {
            LastNameCreatedForm.Clear();
            LastNameCreatedForm.Foreground = Brushes.Black;
        }

        private void LastNameCreatedForm_LostFocus(object sender, RoutedEventArgs e)
        {
            if (LastNameCreatedForm.Text == "")
            {
                LastNameCreatedForm.Foreground = Brushes.Gray;
                LastNameCreatedForm.Text = "Last Name";
            }
        }

        private void UserNameCreatedForm_GotFocus(object sender, RoutedEventArgs e)
        {
            UserNameCreatedForm.Clear();
            UserNameCreatedForm.Foreground = Brushes.Black;
        }

        private void UserNameCreatedForm_LostFocus(object sender, RoutedEventArgs e)
        {
            if (UserNameCreatedForm.Text == "")
            {
                UserNameCreatedForm.Foreground = Brushes.Gray;
                UserNameCreatedForm.Text = "Username";
            }
        }

        private void PasswordCreatedForm_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordCreatedForm.Clear();
            PasswordCreatedForm.Foreground = Brushes.Black;
        }

        private void PasswordCreatedForm_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordCreatedForm.Text == "")
            {
                PasswordCreatedForm.Foreground = Brushes.Gray;
                PasswordCreatedForm.Text = "Password";
            }
        }

        private void CreateUserButton_onForm_Click(object sender, RoutedEventArgs e)
        {
            CreateUserForm.Visibility = Visibility.Hidden;
            CreateUserFormBorder.Visibility = Visibility.Hidden;
            CreateUser.Margin = new Thickness(1025, 33, 0, 0);
            SignOut.Visibility = Visibility.Visible;
            MovieInfoGrid.Visibility = Visibility.Visible;
        }
    }
}
