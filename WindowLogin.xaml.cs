using System.Windows;
using exam.Database;

namespace exam
{
    /// <summary>
    /// Логика взаимодействия для WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Window
    {
        public WindowLogin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginInput.Text;
            string pass = PassInput.Text;
            if(login != "" && pass != "")
            {
                bool res = new Database.Database().login(login, pass);
                if (res)
                {
                    MainWindow window = new MainWindow();
                    window.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowRegister window = new WindowRegister();
            window.Show();
            this.Close();
        }

        private void LoginInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
