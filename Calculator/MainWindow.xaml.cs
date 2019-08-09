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

namespace Calculator
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            //  ElementController(btn, btn.Tag.ToString());
            var tag = btn.Tag.ToString();
            var num = int.Parse(tag.Substring( tag.Length - 1, 1));
            //MessageBox.Show(num);
            Show(num+"");
        }

        private void Show(string message)
        {
            ShowText.Text += message;
        }
        private void ShowLine(string message)
        {
            ShowText.Text += "\n" + message+"\n";
        }

        private void OperateAddBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowLine("+");
        }

        private void OperateSubtractBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowLine("-");
        }

        private void OperateMultiBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowLine("*");
        }

        private void OperateDivideBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowLine("/");
        }
        private void OperateEquelBtn_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
