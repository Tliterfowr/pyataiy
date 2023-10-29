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

namespace WpfApp3.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task9Page.xaml
    /// </summary>
    public partial class Task9Page : Page
    {
        public Task9Page()
        {
            InitializeComponent();
            Random random = new Random();

            double[] arr = new double[15];

            double a = 0;



            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
                Tb1.Text += $"{arr[i]} ";
                a += arr[i];
            }
            a /= 15;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] - a;
                Tb2.Text += $"{Math.Round(arr[i], 2)} ";
            }
        }
    }
}
