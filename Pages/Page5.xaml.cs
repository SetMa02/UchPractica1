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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }
      

        private void btnString2_Click(object sender, RoutedEventArgs e)
        {
            string str = txtString2.Text;
            string result = string.Join("", str.Select(c => c != '*' ? $"{c}{c}" : "*"));
            txtString2.Text = result;
        }

        private void txtString1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (txtString1.Text.ToString().Length > 10)
                    txtString1.Text = RemoveSpecialCharacters(txtString1.Text.ToString());
                txtLenght.Text = txtString1.Text.ToString().Length.ToString();

            }
        }

        private void txtString1_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtLenght.Text = txtString1.Text.ToString().Length.ToString();
        }


        public string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in str)
            {
                if ((c >= 'A' && c <= 'Z'))
                    continue;
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
