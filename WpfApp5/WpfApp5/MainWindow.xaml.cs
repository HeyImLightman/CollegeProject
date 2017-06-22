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

namespace WpfApp5
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

        

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Чирков А.А & Кондратенко А.С");
        }


        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Classes f1 = new Classes();
            f1.ShowDialog();
        }

        
            private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            
            Form3 f2 = new Form3();
            f2.ShowDialog();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

            Teachers f3 = new Teachers();
            f3.ShowDialog();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {

            Subjects f4 = new Subjects();
            f4.ShowDialog();
        }
    }
}
