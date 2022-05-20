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

namespace GribovaPUB
{
    /// <summary>
    /// Actions for closing
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ComboLogin.ItemSource = AppData.Context.User.ToList();
        }

        private void BtnLogin_Click (object sender, RoutedEventArgs e)
        {
            if ComboLogin.SelectedItem i User currentUser)
                {
                if (PBoxPassword.Password == currentUser.Password)
                {
                    AppData.CurrentUser = CurrentUser;
                    var paymentWindow = new PaymentsWindow();
                    paymentWindow.Owner = this;
                    paymentWindow.Show();
                    Hide();
                }
                else 
                    MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
