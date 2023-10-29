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
    /// Логика взаимодействия для Task13Page.xaml
    /// </summary>
    public partial class Task13Page : Page
    {
        public Task13Page()
        {
            InitializeComponent();
            Random random = new Random();

            double[] arr = new double[15];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-99, 100);
                Tb1.Text += $"{arr[i]} ";

            }

            Tb2.Text += $"Сумма {arr.Min() + arr.Max()} ";
            Tb3.Text += $"Разноcть {arr.Max() - arr.Min()} ";
        }
    }
}
