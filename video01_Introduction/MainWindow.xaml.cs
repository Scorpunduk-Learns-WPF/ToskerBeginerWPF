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
using video01_Introduction.Model;

namespace video01_Introduction
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ButtonNaming buttonOne = new ButtonNaming() { Name = "First Button" };
            ButtonNaming buttonTwo = new ButtonNaming() { Name = "Second Button" };

            Button_1.DataContext = buttonOne;
            Button_2.DataContext = buttonTwo;
        }

        private void MainWindowLoaded(object sender, RoutedEventArgs e)
        {
            mainGrid.Background = Brushes.CornflowerBlue;
        }
    }
}
