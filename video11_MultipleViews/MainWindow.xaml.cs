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

using video11_MultipleViews.ViewModels;

namespace video11_MultipleViews
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RedView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new RedViewModel();
        }

        private void BlueView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new BlueViewModel();
        }

        private void GreenView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new GreenViewModel();
        }
    }
}
