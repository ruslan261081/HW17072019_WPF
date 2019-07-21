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

namespace HW17072019_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Calc()
        {
            try
            {
                resultTxtBlk.Text = (Int32.Parse(number1Txt.Text) + Int32.Parse(number2Txt.Text)).ToString();
            }
            catch(Exception ex)
            {

            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sumBtn_Click(object sender, RoutedEventArgs e)
        {
            Calc();
        }

        private void number1Txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calc();
        }

        private void number2Txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calc();
        }
    }
}
