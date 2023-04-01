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
using System.Windows.Shapes;

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for WpfResources.xaml
    /// </summary>
    public partial class WpfResources : Window
    {
        public WpfResources()
        {
            InitializeComponent();
        }

        private bool isRed = true;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = null;
            string s1 = s.ToUpper();

            var obj = Application.Current.FindResource("DynamicColorBrush");
            obj = FindResource("text1");
            obj = stackPanel.FindResource("text1");

            Color color = isRed ? Colors.Green : Colors.Red;
            SolidColorBrush solid = new SolidColorBrush(color);            
            Application.Current.Resources["DynamicColorBrush"] = solid;
            isRed = !isRed;
        }
    }
}
