using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace Pr1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {

        public Page2()
        {
            InitializeComponent();
          
        }

        private void txtN_KeyDown(object sender, KeyEventArgs e)
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

        private void txtA_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        public int CountA(int A, char[] N)
        {
            int count = 0;
            foreach(int i in N)
            {
                if (i > A)
                    count++;
            }
            return count;
        }

        public bool Prom(int n, int a, int b)
        {
            bool prin = false;
            if(a < b)
            {
                if(n <= b && n >= a && n%3 ==0& n%4==0 & n%5==0)
                {
                    prin = true;
                }
            }
            else
            {
                MessageBox.Show("A должно быть меньше B!", "Input Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            return prin;
        }
        public int SummChisl(int a, int b)
        {
            int sum = 0;
            for (int i = a; i < b + 1; i++)
            {
                if(i % 13==0 && i % 5==0)
                    sum += i;
            }
            return sum;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtA.Text.ToString() != null && txtB.Text.ToString() != null && txtN.Text.ToString() != null)
            {
                int summ = 0;
                bool second;
                int n = Convert.ToInt32(txtN.Text);
                int countA;
                char[] chisl = txtN.Text.ToCharArray();
                int a = Convert.ToInt32(txtA.Text);
                int b = Convert.ToInt32(txtB.Text);

                countA = CountA(a, chisl);
                second = Prom(n, a, b);
                summ = SummChisl(a, b);

                txtOutput.Text = "количество цифр данного числа, больших А = " + countA.ToString()+
                    " данное число принадлежит промежутку от А до В и кратно 3, 4 и 5 = " + second.ToString() 
                    + " суммa всех чисел из промежутка от А до В и кратных 13 и 5 = " + summ.ToString();

            }
        }
    }
}
