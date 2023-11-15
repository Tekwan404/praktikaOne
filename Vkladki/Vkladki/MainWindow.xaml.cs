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

namespace Vkladki
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

        private void fio_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void number_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void statusopl_Checked(object sender, RoutedEventArgs e)
        {
            var c = "Оплачено";
            status.Text = c;
        }

        private void statusopl_Unchecked(object sender, RoutedEventArgs e)
        {
             string  c = "Не оплачено";
            status.Text = c;
        }

        private List<string[]> data = new List<string[]>();


        private void Click_Click(object sender, RoutedEventArgs e)
        {
            string a = fio.Text;
            string b = number.Text;
            string c = status.Text;
            string x = date.Text;
            
            

            data.Add(new string[] { a, b, c, x});

            listview.ItemsSource = data.ToList();
        }

        private void status_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

            DateTime? selectedDate = calendar1.SelectedDate;

           var c = selectedDate.Value.Date.ToShortDateString();
            date.Text = c;
        }

        private void date_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
