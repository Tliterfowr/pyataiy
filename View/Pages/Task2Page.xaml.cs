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
    /// Логика взаимодействия для Task2Page.xaml
    /// </summary>
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
            Random random = new Random();

            int[] arr = new int[12];
            int a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
                a += arr[i];
            }



            foreach (var num in arr)
            {
                Tb1.Text += $"{num} ";
            }
            arr[4] = a / 12;
            foreach (var num in arr)
            {
                Tb2.Text += $"{num} ";
            }
        }
        
    }
}
