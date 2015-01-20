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
using LogicLayer.Interfaces;
using LogicLayer.Interfaces.Entities;

namespace LogicLayer.Client
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

        private class SiteView : ISite
        {
            public int CustomerId { get; set; }
            public string MeterPointRef { get; set; }
            public bool IsDailyMetered { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ICalculationController controller = new CalculationController(); //can be replaced by Dependency Injection

            //get currently selected information and perform calculation
            var costComponents = controller.CalculateCost(new SiteView{CustomerId = 1, MeterPointRef = "123456", IsDailyMetered = true});

            //output results
            foreach (var costComponent in costComponents)
            {
                Console.WriteLine(string.Format("{0} - £{1}", costComponent.Description, costComponent.Cost));
            }
        }
    }
}
