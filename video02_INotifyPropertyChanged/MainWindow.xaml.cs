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

using video02_INotifyPropertyChanged.ViewModel;

namespace video02_INotifyPropertyChanged
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainVM _main = new MainVM();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _main;
        }

        private void Red_Clicked(object sender, RoutedEventArgs e)
        {
            _main.SetBackGround(Brushes.Red);
        }

        private void Blue_Clicked(object sender, RoutedEventArgs e)
        {
            _main.SetBackGround(Brushes.Blue);
        }

        private void Green_Clicked(object sender, RoutedEventArgs e)
        {
            _main.SetBackGround(Brushes.Green);
        }
    }
}
