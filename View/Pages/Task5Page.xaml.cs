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
    /// Логика взаимодействия для Task5Page.xaml
    /// </summary>
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
            Random random = new Random();

            int[] arr = new int[10];

            int ia = 0, ib = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
                Tb1.Text += $"{arr[i]} ";
            }
            int a = arr[0];
            int b = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < a)
                {
                    a = arr[i];
                    ia = i;
                }
                if (arr[i] > b)
                {
                    b = arr[i];
                    ib = i;
                }
            }
            arr[ia] = b;
            arr[ib] = a;
            foreach (int i in arr)
            {
                Tb2.Text += $"{i} ";
            }
        }
    }
}
