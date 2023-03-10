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
using System.IO.Ports;

namespace Luci_Power
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
        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            Button btn1 = sender as Button;
            if (btn1.Content!="Disconnect")
            {
                btn1.Content = "Disconnect";
            }
            else
            {
                btn1.Content = "Connect";
            }
        }
        private void Power_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = btn.Background == Brushes.Green ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFDDDDDD")) : Brushes.Green;
            if(btn.Background == Brushes.Green)
            {
                btn.Content = "ON";
            }
            else
            {
                btn.Content = "OFF";
            }
        }
    }
}
