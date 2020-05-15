using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using ExpresionHandlerLib;

namespace Calculator
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

        private void DataChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (resultTxtBox.Text[0] == '0')
            {
                if (resultTxtBox.Text[1] != ',')
                {
                    resultTxtBox.Text = resultTxtBox.Text.Replace('0', ' ');
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text != "0")
            {
                resultTxtBox.Text = resultTxtBox.Text + "0";
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text == "0")
            {
                resultTxtBox.Text = "1";
            }
            else
            {
                resultTxtBox.Text = resultTxtBox.Text + "1";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text == "0")
            {
                resultTxtBox.Text = "2";
            }
            else
            {
                resultTxtBox.Text = resultTxtBox.Text + "2";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text == "0")
            {
                resultTxtBox.Text = "3";
            }
            else
            {
                resultTxtBox.Text = resultTxtBox.Text + "3";
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text == "0")
            {
                resultTxtBox.Text = "4";
            }
            else
            {
                resultTxtBox.Text = resultTxtBox.Text + "4";
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text == "0")
            {
                resultTxtBox.Text = "5";
            }
            else
            {
                resultTxtBox.Text = resultTxtBox.Text + "5";
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text == "0")
            {
                resultTxtBox.Text = "6";
            }
            else
            {
                resultTxtBox.Text = resultTxtBox.Text + "6";
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text == "0")
            {
                resultTxtBox.Text = "7";
            }
            else
            {
                resultTxtBox.Text = resultTxtBox.Text + "7";
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text == "0")
            {
                resultTxtBox.Text = "8";
            }
            else
            {
                resultTxtBox.Text = resultTxtBox.Text + "8";
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text == "0")
            {
                resultTxtBox.Text = "9";
            }
            else
            {
                resultTxtBox.Text = resultTxtBox.Text + "9";
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {

            resultTxtBox.Text = resultTxtBox.Text + "+";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = "0";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {

            resultTxtBox.Text = resultTxtBox.Text + "/";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {

            resultTxtBox.Text = resultTxtBox.Text + "*";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "-";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            prevResultTxtBox.Text = resultTxtBox.Text + "=" + ExpressionHandler.GetResault(resultTxtBox.Text);
            resultTxtBox.Text = "0";
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + ",";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "(";
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + ")";
        }

        private void ButtonPowerOff_Click(object sender, RoutedEventArgs e)
        {

            Task.Run(new Action(() =>
            {
                Thread.Sleep(1900);
                this.Dispatcher.Invoke(new Action(() => { this.Close(); }));
            }));

        }


    }
}
