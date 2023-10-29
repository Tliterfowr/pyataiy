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
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
            Random random = new Random();

            int[] arr = new int[14];
            int a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
            }

            foreach (var item in arr)
            {
                Tb1.Text += $"{item} ";
                if (item % 2 == 0)
                {
                    a++;
                }
            }
            Tb2.Text = $"Число чётных: {a}";
            int[] testArray = new int[a];
        }
    }
}
