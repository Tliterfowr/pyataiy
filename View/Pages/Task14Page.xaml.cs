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
    /// Логика взаимодействия для Task14Page.xaml
    /// </summary>
    public partial class Task14Page : Page
    {
        public Task14Page()
        {
            InitializeComponent();
            Random random = new Random();
            double a = 0;
            double[] arr = new double[17];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-99, 100);
                Tb1.Text += $"{arr[i]} ";
                if (arr[i] % 2 != 0)
                {
                    a += arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    arr[i] = a;
                }
                Tb2.Text += $"{arr[i]} ";
            }
        }
    }
}
