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
using Lib;

namespace SumSerial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<double> result;
        public MainWindow()
        {
            InitializeComponent();
            result = new List<double>();
        }

        private void Calc(object sender, RoutedEventArgs e)
        {
            SumSeriesLib sumSeries = new SumSeriesLib();
            int x = Convert.ToInt32(XInput.Text);
            double eps = Convert.ToDouble(EpsInput.Text);
            result = sumSeries.CalculateSumSeries(x, eps);
            Results.ItemsSource = result;
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            XInput.Text = string.Empty;
            EpsInput.Text = string.Empty;
        }

        private void WriteInFile(object sender, RoutedEventArgs e) 
        {
            try
            {

                string filePath = "D:\\output.txt";
                
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath))
                {
                    foreach (double item  in result)
                    {
                        file.WriteLine(item);
                    }
                }

                MessageBox.Show("Данные сохранены в файле: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при сохранении данных: " + ex.Message);
            }
        }
    }
}
