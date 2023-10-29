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
    /// Логика взаимодействия для Task3Page.xaml
    /// </summary>
    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
            Random random = new Random();

            int[] arr = new int[11];
            int a = 0;
            int b = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
                a += arr[i];
            }
            a = a / 11;
            foreach (var num in arr)
            {
                if (num > a)
                {
                    Tb1.Text += $"{num} ";
                    b++;
                }
            }
            Tb2.Text += $"{b} Элементов больше ср. ариф. {a}";
        }
    }
}
