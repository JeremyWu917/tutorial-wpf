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

namespace _01_XAML_Basic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainGrid.MouseUp += MainGrid_MouseUp1;
        }

        private void MainGrid_MouseUp1(object sender, MouseButtonEventArgs e)
        {
            _ = MessageBox.Show("The subscribe event in your code had been fired.");
        }

        private void MainGrid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _ = MessageBox.Show($"Clicked at position: [ {e.GetPosition(this)} ]");
        }
    }
}
