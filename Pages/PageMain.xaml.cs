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

namespace Pr1.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new Page1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new Page2());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new Page3());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new Page4());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new Page5());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new Page6());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new Page7());
        }
    }
}
