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

namespace ZVDOP1
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
            /*Переменные расстояния*/
            string s1 = s1Box.Text;
            string s2 = s2Box.Text;
            string s3 = s3Box.Text;

            /*Переменные скорости*/
            string v1 = v1Box.Text;
            string v2 = v2Box.Text;
            string v3 = v3Box.Text;
            
            
            double sumS = 0;
            double sumV = 0;


            /*Рассчет каждого расстояния*/
            double sumS1 = 0;
            double sumS2 = 0;
            double sumS3 = 0;

           
            double sumV1 = 0;
            double sumV2 = 0;
            double sumV3 = 0;

            /*YНашли каждое время*/
            sumS1 = int.Parse(s1) / int.Parse(v1);
            sumS2 = int.Parse(s2) / int.Parse(v2);
            sumS3 = int.Parse(s3) / int.Parse(v3);
             
            sumS = int.Parse(v1) + int.Parse(v2) + int.Parse(v3);

            sumS1Box.Text = string.Format("Время = " + sumS1);
            sumS2Box.Text = string.Format("Время = " + sumS2);
            sumS3Box.Text = string.Format("Время = " + sumS3);

            sumV = sumS / (sumS1 + sumS2 + sumS3) ;

            SumaVblock.Text = string.Format("Средння скорость = " + sumV);


        }
    }
}
