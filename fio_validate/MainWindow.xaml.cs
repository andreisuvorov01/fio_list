using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace fio_validate
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private User _user;
        private ObservableCollection<string> list;
        public MainWindow()
        {
            InitializeComponent();

            _user = new User();
            list = new ObservableCollection<string> { };
        }

        private void vnos_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            _user.otchestvo1 = otchestvo.Text;
            _user.familiya1 = familiya.Text;
            _user.imya1 = imya.Text;
            _user.FIO = (imya.Text + " " + familiya.Text + " " + otchestvo.Text);
            list.Add(_user.FIO);
            list1.ItemsSource = list;

        }
    }
}