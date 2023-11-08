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

namespace ZVDOP
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string a = secBox.Text;
            double c = 0;
            double q = 0;

            if(int.TryParse(a, out int b))
            {
                c = b / 3600;
                q = (b % 3600)/60;
                Math.Round(q, 2);
                if (c > 10 && q > 10)
                {
                    nach.Text = string.Format("Результат = " + c + ":" + q);
                    
                }
                else if (c < 10 && q < 10)
                {
                    nach.Text = ("Результат = " + "0" + c + ":" + "0" + q);

                }
                else if (c < 10)
                {
                    nach.Text = ("Результат = " + "0" + c + ":" + q);

                }
                else if (q < 10)
                {
                    nach.Text = ("Результат = " + c + ":" + "0" + q);

                }
                
            }
            else
            {

            }
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            myMediaElement.Position = TimeSpan.Zero; // Перемотка видео к началу
            myMediaElement.Play(); // Начать воспроизведение снова
            myMediaElement.MediaEnded += MediaElement_MediaEnded;
        }

        private void clear(object sender, RoutedEventArgs e)
        {
            secBox.Clear();
        }

        private void secBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
