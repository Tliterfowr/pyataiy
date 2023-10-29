﻿using System;
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

namespace WpfApp3.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task15Page.xaml
    /// </summary>
    public partial class Task15Page : Page
    {
        public Task15Page()
        {
            InitializeComponent();
            Random random = new Random();

            double[] arr = new double[14];




            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-99, 100);
                Tb1.Text += $"{arr[i]} ";

            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (i < 7)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            double z = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = z;
                        }
                    }
                    else
                    {
                        if (arr[j] < arr[j + 1])
                        {
                            double z = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = z;
                        }
                    }
                }
            }
            foreach (double i in arr)
            {
                Tb2.Text += $"{i} ";
            }
        }
    }
}
