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
    public partial class Page1 : Page
    {
        float z;
        float x;
        float y;
        public Page1()
        {
            InitializeComponent();
        }

        private void txtX_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void txtX_TextChanged(object sender, TextChangedEventArgs e)
        {
            try { 
            if(Convert.ToDecimal(txtz.Text) >= 0)
            {
                z = (float)Convert.ToDecimal(txtz.Text);
                x = 2 * z + 1;
            }
            else
            {
                z = (float)Convert.ToDecimal(txtz.Text);
                x = (float)Math.Log10(Math.Pow(z,2) - z);
            }
            txtx.Text = "X = " + x.ToString();
            y = (float)(Math.Pow(Math.Sin(x), 2) + Math.Pow(Math.Cos(Math.Pow(x, 3)), 5 + Math.Log10(Math.Pow(x, 2 / 5))));
            txtY.Text = "Y = " + y.ToString();
            }
            catch
            {

            }
        }

        private void txtz_KeyDown(object sender, KeyEventArgs e)
        {
            var allowed = new[] { Key.D0, Key.D1, Key.D2, Key.D3, Key.D4, Key.D5, Key.D6,
Key.D7, Key.D8, Key.D9, Key.NumPad0, Key.NumPad1, Key.NumPad2, Key.NumPad3, Key.NumPad4,
Key.NumPad5, Key.NumPad6, Key.NumPad7, Key.NumPad8, Key.NumPad9, Key.Back, Key.OemComma};

            if (allowed.Contains(e.Key))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
