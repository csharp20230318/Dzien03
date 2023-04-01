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
    /// Interaction logic for ButtonTest.xaml
    /// </summary>
    public partial class ButtonTest : Window
    {
        public ButtonTest()
        {
            InitializeComponent();
            btnTest.Content = "ABC";
            btnTest.Click += ButtonTest_Click;
        }

        private void ButtonTest_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("click!");
        }

    }
}
