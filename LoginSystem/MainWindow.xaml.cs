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

namespace LoginSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox.Text = users.Default.user;
            passwordBox.Password = users.Default.pass;
            passwordBox.PasswordChar = '●';
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

      

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string nome = textBox.Text;
            string pass = passwordBox.Password;
            if(nome == users.Default.user.ToString())
            {
                //Caso nome bata certo
                if(pass == users.Default.pass.ToString())
                {
                    //caso pass bata certo
                    MessageBox.Show("Login successful!");
                    //AQUI
                    IntClient IntWars = new IntClient();
                    IntWars.Show();
                    this.Close();

                }
                else
                {
                    //Caso pass bata errado
                    MessageBox.Show("Password incorrect!");
                }
            }
            else
            {
                //Caso nome bata errado
                MessageBox.Show("Nome incorrect!");
            }
        }

        

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string nome = textBox.Text;
            string pass = passwordBox.Password;
            users.Default.Save();
        }
    }
}
