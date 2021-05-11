using Pr1.Pages;
using System;
using System.Windows;


namespace Pr1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameManager.MainFrame = MainFrame;
            FrameManager.MainFrame.Navigate(new PageMain());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (!FrameManager.MainFrame.CanGoBack)
                btnBack.Visibility = Visibility.Hidden;
            if (FrameManager.MainFrame.CanGoBack)
                btnBack.Visibility = Visibility.Visible;
        }
    }
}
