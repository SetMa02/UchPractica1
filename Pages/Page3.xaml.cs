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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        int[] mass1 = new int[10];
        int[] mass2 = new int[15];
        int mass1Pos = 0;
        int mass2Pos = 0;
        Random random = new Random();

        public Page3()
        {
            InitializeComponent();

            for(int i = 0; i < mass2.Length; i ++ )
            {
                mass2[i] = random.Next(-10, 40);
                Mass2output.AppendText(mass2[i].ToString() + " ");
            }
        }

        private void txtMass_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            var allowed = new[] { Key.OemPipe, Key.D0, Key.D1, Key.D2, Key.D3, Key.D4, Key.D5, Key.D6,
            Key.D7, Key.D8, Key.D9, Key.NumPad0, Key.NumPad1, Key.NumPad2, Key.NumPad3, Key.NumPad4,
            Key.NumPad5, Key.NumPad6, Key.NumPad7, Key.NumPad8, Key.NumPad9, Key.Back, Key.OemComma};


            if (allowed.Contains(e.Key))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
            */
        }

        private void txtMass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (txtMass.Text != "")
                {
                    int mass1El = Convert.ToInt32(txtMass.Text);
                    mass1[mass1Pos] = mass1El;
                    txtMass.Text = "";
                    mass1Pos++;
                    RewriteMassive1();
                }
            }
        }

        public void RewriteMassive1()
        {
            Mass1output.Text = "";
            for (int i = 0; i < mass1.Length; i++)
            {
                Mass1output.AppendText(mass1[i].ToString() + " ");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int proizv = 1;
            for(int i = 0; i < mass1.Length; i++)
            {
                if(mass1[i] % 2 !=0)
                {
                    proizv *= mass1[i];
                }
            }
            txtOutput.AppendText("произведение  элементов, имеющих нечетное значение = " + proizv.ToString() + " индексы тех элементов, значения которых равны А: ");

            for (int i = 0; i < mass1.Length; i++)
            {
                if (mass1[i] == Convert.ToInt32(txtA.Text))
                    txtOutput.AppendText(i +" ");
            }

            bool krK = false;
            foreach(int i in mass1)
            {
                if (i % Convert.ToInt32(txtK.Text) == 0)
                { 
                    krK = true;
                    return;
                }
            }
            txtOutput.AppendText("Элементы кратные K = " + krK.ToString());


            int minEl = 0;
            for (int i = 0; i < mass1.Length; i++)
            {
                if(mass1[i] < 0 && Math.Abs(mass1[minEl]) < Math.Abs(mass1[i]))
                {
                    minEl = i;
                }
            }
            mass1[minEl] = 99;

            RewriteMassive1();


            for (int i = 0; i < mass1.Length; i++)
            {
                if (i > Convert.ToInt32(txtK.Text))
                {
                    mass1[i] = 0;
                }
            }
            RewriteMassive1();
        }

        public void RewriteMass2()
        {
            Mass2output.Text = "";
            for (int i = 0; i < mass2.Length; i++)
            {
                Mass2output.AppendText(mass2[i].ToString() + " ");
            }
        }


        private void btnRasch2_Click(object sender, RoutedEventArgs e)
        {
                int firstPositive = 0;
                int positiveIndex = 0;
                int lastNegative = 0;
                int negativeIndex = 0;

            for(int i = 0; i < mass2.Length;i++)
            {
                
                int chislo = Math.Abs(mass2[i]);
                int firstDigit = (int)(chislo / Math.Pow(10, (int)Math.Log10(chislo)));
                int lastDigit = (int)(chislo % 10);
                if (firstDigit == 3 || lastDigit == 3)
                    mass2[i] = 0;


                try 
                { 
                if (mass2[i] % i == 0)
                    mass2[i + 1] = Int32.Parse(txtK1.Text);
                }
                catch
                {    }
                if (mass2[i] > 0)
                { 
                    firstPositive = mass2[i];
                    positiveIndex = i;
                }
                else if(mass2[i]< 0)
                {
                    lastNegative = mass2[i];
                    negativeIndex = i;
                }
            }
            mass2[positiveIndex] = lastNegative;
            mass2[negativeIndex] = firstPositive;

            RewriteMass2();
        }
    }
}
