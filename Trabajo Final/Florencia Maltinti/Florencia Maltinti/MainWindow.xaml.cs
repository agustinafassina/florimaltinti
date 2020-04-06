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

namespace Florencia_Maltinti
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
            var material = new List<String>() { "PVC", "Cooper", "Steel Iron"};

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

        private void find_Click(object sender, RoutedEventArgs e)
        {
            var min = Convert.ToInt32(minimo.Text);
            var max = Convert.ToInt32(maximo.Text);
            var system = new List<String>() { "Waste", "DHW", "Vent" };

            foreach (string value in system)
            {
                if (result.Text == "Vent" || min >= 2 && max <= 4)
                {
                    resultDiametro.Text = "In the project";
                }
                else
                { 
                    resultDiametro.Text = "Invalid Diameter"; 
                }
            
                if (result.Text == "DHW" || min >= 1/8 && max <= 4)
                {
                    resultDiametro.Text = "In the project";
                }
                else
                {
                    resultDiametro.Text = "Invalid Diameter";
                }
            
                if (result.Text == "Waste" || min >= 2 && max <= 12)
                {
                    resultDiametro.Text = "In the project";
                }
                else
                {
                    resultDiametro.Text = "Invalid Diameter";
                }
            }


        }

        private void minimo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
