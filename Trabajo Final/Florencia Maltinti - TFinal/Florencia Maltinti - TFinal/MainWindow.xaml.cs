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

namespace Florencia_Maltinti___TFinal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)system.SelectedItem;
            Search insSearch = new Search();
            var material = insSearch.Get();

            foreach (string value in material)
            {
                if (item.Content.ToString() == "Vent")
                {
                    result.Text = "PVC";
                }

                if (item.Content.ToString() == "Waste")
                {
                    result.Text = "Steel Iron";
                }

                if (item.Content.ToString() == "DHW")
                {
                    result.Text = "Cooper";
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var min = Convert.ToInt32(minimo.Text);
            var max = Convert.ToInt32(maximo.Text);
            Find insFind = new Find();
            var system = insFind.Get();

            foreach (string value in system)
            {
                if (min >= 2 && max <= 4)
                {
                    if (result.Text == "PVC")
                    {
                        resultDiametro.Text = "In the project";
                    }
                    else
                    {
                        resultDiametro.Text = "Invalid Diameter";
                    }
                }
                
                else if  (min >= 1 && max <= 4)
                {
                    if (result.Text == "Cooper")
                    {
                        resultDiametro.Text = "In the project";
                    }
                    else
                    {
                        resultDiametro.Text = "Invalid Diameter";
                    }

                }                

                else if (min >= 2 &&  max <= 12)
                {
                    if (result.Text == "Steel Iron")
                    {
                        resultDiametro.Text = "In the project";
                    }
                    else
                    {
                        resultDiametro.Text = "Invalid Diameter";
                    }
                }
                
                else
                {
                    resultDiametro.Text = "Invalid Diameter";
                }
            }
        }
    }
}
