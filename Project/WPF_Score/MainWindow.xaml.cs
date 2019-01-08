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
using System.Windows.Threading;
using Modele.Meci;

namespace WPF_Score
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Meci scor;
        private int time = 0;
        private DispatcherTimer Timer;
        public MainWindow()
        {
            InitializeComponent();
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Timer_Tick;
            Timer.Start();
            scor = new Meci { ScoreHome = 0, ScoreGuest=0};
            this.DataContext = scor;
          

        }
        void Timer_Tick(object sender, EventArgs e)
        {
            if(time>0)
            {
                if(time<=10)
                {
                    if (time % 2 == 0)
                    {
                        TBCountDown.Foreground = Brushes.Red;
                    }
                    else
                    {
                        TBCountDown.Foreground = Brushes.White;
                    }
                    time--;
                    TBCountDown.Text = string.Format("00:0{0}:0{1}", time / 60, time % 60);

                }
                else
                {
                    time--;
                    TBCountDown.Text = string.Format("00:0{0}:0{1}", time / 60, time % 60);
                }
               
            }
            else
            {
                Timer.Stop();
            }
        }
        private void ButtonAdd_Home_Click(object sender, RoutedEventArgs e)
        {
            DataContext = null;
            scor.ScoreHome= scor.ScoreHome +2;
            this.DataContext = scor;
           
        }

        private void ButtonAdd_Guest_Click(object sender, RoutedEventArgs e)
        {
            DataContext = null;
            scor.ScoreGuest= scor.ScoreGuest + 2;
            this.DataContext = scor;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonAdd3_Home_Click(object sender, RoutedEventArgs e)
        {
            DataContext = null;
            scor.ScoreHome = scor.ScoreHome + 3;
            this.DataContext = scor;
        }
        private void ButtonAdd3_Reset_Click(object sender, RoutedEventArgs e)
        {
            DataContext = null;
            scor.ScoreHome = 0;
            scor.ScoreGuest = 0;
            this.DataContext = scor;
        }

        private void ButtonAdd3_Guest_Click(object sender, RoutedEventArgs e)
        {
            DataContext = null;
            scor.ScoreGuest = scor.ScoreGuest + 3;
            this.DataContext = scor;
        }
        private void ButtonAdd1_Home_Click(object sender, RoutedEventArgs e)
        {
            DataContext = null;
            scor.ScoreHome++;
            this.DataContext = scor;
        }
        private void ButtonAdd1_Guest_Click(object sender, RoutedEventArgs e)
        {
            DataContext = null;
            scor.ScoreGuest++;
            this.DataContext = scor;
        }
    }
}
