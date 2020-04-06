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

namespace Ej3_class_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        void Main(string[] args)
        {
            int number = 20;
            Console.WriteLine("number + 5 = {0}");
            AddFive(number);
            
        }
        static void AddFive(int number)
        {
            number = number + 5;
            Console.WriteLine(number);
        }
    }
}