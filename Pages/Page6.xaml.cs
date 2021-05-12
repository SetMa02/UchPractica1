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
        string path3 = @"C:\Users\User\Desktop\Уч.Практика\ПерваяУчПр\Pr1\f3.txt";
        string path31 = @"C:\Users\User\Desktop\Уч.Практика\ПерваяУчПр\Pr1\f4.txt";
        string path4 = @"C:\Users\User\Desktop\Уч.Практика\ПерваяУчПр\Pr1\f5.txt";
        string path41 = @"C:\Users\User\Desktop\Уч.Практика\ПерваяУчПр\Pr1\f6.txt";
        string path5 = @"C:\Users\User\Desktop\Уч.Практика\ПерваяУчПр\Pr1\f7.txt";
        string path51 = @"C:\Users\User\Desktop\Уч.Практика\ПерваяУчПр\Pr1\f8.txt";
        int[] mass1 = new int[10];
        int[] mass2 = new int[10];
        int[] mass21 = new int[10];

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


            using (StreamWriter sw1 = new StreamWriter(path3))
            {
                for (int i = 0; i < 10; i++)
                {
                    chislo = random.Next(-100, 100);
                    sw1.Write(chislo + " ");
                    mass2[i] = chislo;
                }
            }
            using (StreamWriter sw1 = new StreamWriter(path31))
            {
                for (int i = 0; i < 10; i++)
                {
                    chislo = random.Next(-100, 100);
                    sw1.Write(chislo + " ");
                    mass21[i] = chislo;
                }
            }
            using (StreamReader sr1 = new StreamReader(path3))
            {
                txtZad3.Text += sr1.ReadToEnd();
            }
            txtZad3.Text += "\n_____________________\n";
            using (StreamReader sr1 = new StreamReader(path31))
            {
                txtZad3.Text += sr1.ReadToEnd();
            }


            using (StreamWriter sw1 = new StreamWriter(path4))
            {
                sw1.Write("Что-то \n" + "\n" + "продолжение");
            }
            using (StreamReader sr1 = new StreamReader(path4))
            {
                txtZad4.Text += sr1.ReadToEnd();
            }


            using (StreamWriter sw1 = new StreamWriter(path5))
            {
                sw1.Write("sdfsdfaojksasdfdasfsfhadf.1233213123sdfsdfasdasdsdf1231");
            }
            using (StreamReader sr1 = new StreamReader(path5))
            {
                txtZad5.Text += sr1.ReadToEnd();
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

            System.Diagnostics.Process.Start("notepad.exe", path1);
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

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            int summ = 0;
            for (int i = 0; i < 10; i++)
            {
                if (mass2[i] > 4.3)
                    summ += mass2[i];
                if (mass21[i] > 4.3)
                    summ += mass2[i];

            }
            txtZad3.Text += "\n Сумма = " + summ.ToString();
        }

        private void btn4_ClickAsync(object sender, RoutedEventArgs e)
        {
            using (StreamReader sr1 = new StreamReader(path4))
            {
                string line;
                while ((line = sr1.ReadLine()) != null)
                {
                    if (line != "")
                        using (StreamWriter sw1 = new StreamWriter(path41, true))
                        {
                            sw1.WriteLine(line);
                        }
                }
               
            }
            using (StreamReader sr1 = new StreamReader(path41))
            {
                txtZad4.Text += "\n" + sr1.ReadToEnd();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader sr1 = new StreamReader(path5))
            {
                bool afterPoint = false;
                string el ;
                foreach(char ch in sr1.ReadToEnd())
                {
                    el = ch.ToString();
                    if (el == ".")
                        afterPoint = true;
                    if(afterPoint)
                        using (StreamWriter sw1 = new StreamWriter(path51, true))
                        {
                            sw1.Write(el);
                        }
                }
               
            }
            using (StreamReader sr1 = new StreamReader(path51))
            {
                txtZad5.Text += "\n" + sr1.ReadToEnd();
            }
        }
    }
    
}
