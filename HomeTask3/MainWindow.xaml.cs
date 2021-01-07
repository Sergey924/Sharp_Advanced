using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace Secundomer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        DispatcherTimer timer = new DispatcherTimer();
        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += dtTicker;
            timer.Start();

        }

        private void Button_Stop_Click(object sender, RoutedEventArgs e)
        {

            s = 0;
            m = 0;
            h = 0;
            lables.Content = h.ToString() + ":" + m.ToString() + ":" + s.ToString();
            timer.Stop();
        }



        private int s = 0;
        private int m = 0;
        private int h = 0;

        private void dtTicker(object sender, EventArgs e)
        {

            s++;
            if (s == 60)
            {
                s = 0;
                m += 1;
            }
            if (m == 60)
            {
                m = 0;
                h += 1;
            }
            if(h == 24)
            {
                s = 0;
                m = 0;
                h = 0;
            }

            lables.Content = h.ToString() + ":" + m.ToString() + ":" + s.ToString();
        }







    }  
}
