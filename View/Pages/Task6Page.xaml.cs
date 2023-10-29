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
    /// Логика взаимодействия для Task6Page.xaml
    /// </summary>
    public partial class Task6Page : Page
    {
        public Task6Page()
        {
            InitializeComponent();
            Random random = new Random();

            int[] arr = new int[20];
            int ch = 0;
            int ne = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
                Tb1.Text += $"{arr[i]} ";
                if (arr[i] % 2 == 0)
                {
                    ch++;
                }
                else
                {
                    ne++;
                }
            }
            if (ch > ne)
            {
                Tb2.Text += $"Чётных {ch}\nНечётных {ne}\nЧётных больше";
            }
            else if (ch < ne)
            {
                Tb2.Text += $"Чётных {ch}\nНечётных {ne}\nНечётных больше";
            }
            else
            {
                Tb2.Text += $"Чётных {ch}\nНечётных {ne}\nЧётных и нечётных поровну";
            }
        }
    }
}
