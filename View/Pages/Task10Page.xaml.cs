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
    /// Логика взаимодействия для Task10Page.xaml
    /// </summary>
    public partial class Task10Page : Page
    {
        public Task10Page()
        {
            InitializeComponent();
            Random random = new Random();

            double[] arr = new double[17];

            double a = 0;
            int ii = 0;
            double Sum = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-99, 100);
                Tb1.Text += $"{arr[i]} ";
                if (arr[i] < 0)
                {
                    a += Math.Abs(arr[i]);
                    ii++;
                }
            }
            a /= ii;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > a)
                {
                    Sum += arr[i];

                }
            }
            Tb2.Text += $"Сумма {Sum}";
        }
    }
}
