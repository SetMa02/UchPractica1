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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        int[,] mass1 = new int[4, 5];
        int[,] mass2 = new int[4, 4];
        int[,] mass3 = new int[6, 6];
        int[,] mass4 = new int[5, 8];
        Random random = new Random();

        public Page4()
        {
            InitializeComponent();
            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    mass2[i, j] = random.Next(-10,10);
                    MassOut2.AppendText(mass2[i, j].ToString() + " | ");
                }
                MassOut2.AppendText(" \n ");
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    mass3[i, j] = i+1;
                    if(i >= 2 && j == 5)
                        mass3[i, j] = 0;

                    if(i >= 3)
                    {
                        if(j > 1)
                            mass3[i, j] = 0;
                    }

                    if(i == 5)
                    {
                        mass3[i, j] = 0;
                        mass3[i, 0] = 6;
                    }
                    
                    MassOut3.AppendText(mass3[i, j].ToString() + " | ");
                }
                MassOut3.AppendText(" \n ");

            }



            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    mass4[i, j] = random.Next(-10, 10);
                    MassOut4.AppendText(mass4[i, j].ToString() + " | ");
                }
                MassOut4.AppendText(" \n ");
            }
        }


        int i = 0;
        int j = 0;
        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (ElMass1.Text != "")
            {
                if (e.Key == Key.Enter)
                {

                    if (j == 5)
                    {
                        i++;
                        j = 0;
                    }

                    MassOut1.Text = "";
                    for (int a = 0; a < 4; a++)
                    {

                        for (int b = 0; b < 5; b++)
                        {
                            mass1[i, j] = Int32.Parse(ElMass1.Text);
                            MassOut1.AppendText(mass1[a, b].ToString() + " | ");
                        }

                        MassOut1.AppendText(" \n ");
                    }
                    j++;
                    ElMass1.Text = "";
                }
            }


        }


        private void btnMass1_Click(object sender, RoutedEventArgs e)
        {
            MassOut1.AppendText("\n \n");
            int[] mass11 = new int[4];
            int podCount = 0;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 5;j++)
                {
                    if (mass1[i, j] < 0 && (mass1[i, j] % 3 == 0 || mass1[i, j] % 5 == 0))
                        podCount++;
                }
                mass11[i] = podCount;
                podCount = 0;
                MassOut1.AppendText(mass11[i].ToString() +" ");
            }
        }

        private void btnMass2_Click(object sender, RoutedEventArgs e)
        {
            bool est = false;
            int positiveCount = 0;
            int negativeCount = 0;
            for (int i = 0; i < 4; i++)
            {
                positiveCount = 0;
                negativeCount = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (mass2[i, j] > 0)
                        positiveCount++;
                    if (mass2[i, j] < 0)
                        negativeCount++;
                } 
                if(positiveCount == negativeCount)
                {
                    est = true;
                    break;
                }
            }
            MassOut2.AppendText("\n \n" + est.ToString());
        }

        private void btnMass3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMass4_Click(object sender, RoutedEventArgs e)
        {
            MassOut4.AppendText(" \n заменить все отрицательные элементы на нули  \n");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(mass4[i, j] < 0)
                        MassOut4.AppendText(0 + " | ");
                    else
                        MassOut4.AppendText(mass4[i, j].ToString() + " | ");
                }
                MassOut4.AppendText(" \n ");
            }
            MassOut4.AppendText(" \n вставить перед всеми стоками, первый элемент которых делится на 5, строку из цифр 5. \n");



            bool isReapeated = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(isReapeated == false)
                     if (mass4[i,0] % 5 == 0)
                        {
                            for(int b = 0; b < 8; b++)
                            {
                                MassOut4.AppendText(mass4[i, b].ToString() + " | ");
                            }
                            isReapeated = true;
                        MassOut4.AppendText(" \n ");
                        for(int a = 1; a< 8;a++)
                        { 
                            MassOut4.AppendText(5 + " | ");
                        }
                     }
                    else
                        MassOut4.AppendText(mass4[i, j].ToString() + " | ");
            }
                MassOut4.AppendText(" \n ");
                isReapeated = false;
            }
            MassOut4.AppendText(" \n удалить столбец, в котором находится первый нечетный положительный элемент. \n");


            int targerLine = -1;
            bool isFound = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (mass4[i, j] % 2 != 0 && isFound == false && mass4[i, j] > 0)
                    {
                        targerLine = i;
                        isFound = true;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == targerLine)
                    {

                    }
                    else
                        MassOut4.AppendText(mass4[i, j].ToString() + " | ");
                }
                MassOut4.AppendText(" \n ");
            }
            MassOut4.AppendText(" \n поменять местами второй и последний столбцы\n");



            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(j == 1)
                        MassOut4.AppendText(mass4[i, 7].ToString() + " | ");
                    else if(j == 7)
                        MassOut4.AppendText(mass4[i, 1].ToString() + " | ");
                    else 
                        MassOut4.AppendText(mass4[i, j].ToString() + " | ");
                }
                MassOut4.AppendText(" \n ");
            }


        }

        

    }
}
    

