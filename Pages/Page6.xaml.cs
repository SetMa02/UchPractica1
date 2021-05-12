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
using System.IO;
using Microsoft.Win32;

namespace Pr1.Pages
{
    public partial class Page6 : Page
    {
        string path1 = @"C:\Users\User\Desktop\Уч.Практика\ПерваяУчПр\Pr1\Ex6.txt";
        string path2 = @"C:\Users\User\Desktop\Уч.Практика\ПерваяУчПр\Pr1\f1.txt";
        string path21 = @"C:\Users\User\Desktop\Уч.Практика\ПерваяУчПр\Pr1\f2.txt";
        string path4 = @"C:\Users\User\Desktop\Уч.Практика\ПерваяУчПр\Pr1\Ex6.txt";
        string path5 = @"C:\Users\User\Desktop\Уч.Практика\ПерваяУчПр\Pr1\Ex6.txt";
        int[] mass1 = new int[10];

        Random random = new Random();
        public Page6()
        {
            InitializeComponent();
           
            using (StreamWriter sw1 = new StreamWriter(path1))
            {
                for(int i = 16; i <= 37; i++)
                {
                    sw1.Write(i.ToString() + " ");
                }
            }
            using (StreamReader sr1 = new StreamReader(path1))
            {
                txtZad1.Text += sr1.ReadToEnd();
            }


            int chislo;
            using (StreamWriter sw1 = new StreamWriter(path2))
            {
                for (int i = 0; i < 10; i++)
                {
                    chislo = random.Next(-100, 100);
                    sw1.Write(chislo + " ");
                    mass1[i] = chislo;
                }
            }
            using (StreamReader sr1 = new StreamReader(path2))
            {
                txtZad2.Text += sr1.ReadToEnd();
            }





        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtZad1.Text = "";
            using (StreamWriter sw1 = new StreamWriter(path1, false))
            {
                for (int i = 16; i <= 37; i++)
                {
                    if(i == 20)
                        sw1.Write("0.5" + " ");
                    else
                        sw1.Write(i.ToString() + " ");
                }
            }
            using (StreamReader sr1 = new StreamReader(path1))
            {
                txtZad1.Text += sr1.ReadToEnd();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            
            using (StreamWriter sw1 = new StreamWriter(path21, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    if (mass1[i] < 18.9)
                        sw1.Write(mass1[i]);

                }
            }
            using (StreamReader sr1 = new StreamReader(path21))
            {
                txtZad2.Text +="\n"+ sr1.ReadToEnd();
            }
        }
    }
}
