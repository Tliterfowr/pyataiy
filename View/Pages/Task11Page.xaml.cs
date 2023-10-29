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
    /// Логика взаимодействия для Task11Page.xaml
    /// </summary>
    public partial class Task11Page : Page
    {
        public Task11Page()
        {
            InitializeComponent();
            Random random = new Random();

            double[] arr = new double[17];

            double a = 0;
            int ii = 0;



            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-99, 100);
                Tb1.Text += $"{arr[i]} ";
                if (arr[i] >= 0 && arr[i] % 2 == 0)
                {
                    a += arr[i];
                    ii++;
                }
            }
            Tb2.Text += $"Сумма {a} ";
            Tb3.Text += $"Колличество {ii} ";
        }
    }
}
