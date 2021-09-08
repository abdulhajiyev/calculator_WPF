using System;
using System.Runtime.Remoting.Channels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public char? Operator { get; set; }
        public double? Value { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button btn)) return;
            switch (btn.Content)
            {
                case "0":
                    if (mainTxt.Text.Length != mainTxt.MaxLength)
                    {
                        mainTxt.Text += "0";
                    }

                    break;

                case "1":
                    if (mainTxt.Text.Length != mainTxt.MaxLength)
                    {
                        mainTxt.Text += "1";
                    }

                    break;
                case "2":
                    if (mainTxt.Text.Length != mainTxt.MaxLength)
                    {
                        mainTxt.Text += "2";
                    }

                    break;
                case "3":
                    if (mainTxt.Text.Length != mainTxt.MaxLength)
                    {
                        mainTxt.Text += "3";
                    }

                    break;
                case "4":
                    if (mainTxt.Text.Length != mainTxt.MaxLength)
                    {
                        mainTxt.Text += "4";
                    }

                    break;
                case "5":
                    if (mainTxt.Text.Length != mainTxt.MaxLength)
                    {
                        mainTxt.Text += "5";
                    }

                    break;
                case "6":
                    if (mainTxt.Text.Length != mainTxt.MaxLength)
                    {
                        mainTxt.Text += "6";
                    }

                    break;
                case "7":
                    if (mainTxt.Text.Length != mainTxt.MaxLength)
                    {
                        mainTxt.Text += "7";
                    }

                    break;
                case "8":
                    if (mainTxt.Text.Length != mainTxt.MaxLength)
                    {
                        mainTxt.Text += "8";
                    }

                    break;
                case "9":
                    if (mainTxt.Text.Length != mainTxt.MaxLength)
                    {
                        mainTxt.Text += "9";
                    }

                    break;
            }
        }

        private void OperatorBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button btn)) return;
            if (mainTxt.Text == "") return;
            switch (Operator)
            {
                case '+':
                    Value += Convert.ToDouble(mainTxt.Text);
                    break;
                case '-':
                    Value -= Convert.ToDouble(mainTxt.Text);
                    break;
                case 'x':
                    Value *= Convert.ToDouble(mainTxt.Text);
                    break;
                case '/':
                    if (Value.ToString()[0] == '0')
                    {
                        MessageBox.Show("Cannot divide by zero");
                    }
                    else
                        Value /= Convert.ToDouble(mainTxt.Text);

                    break;
            }

            Operator = btn.Tag.ToString()[0];
            remVal.Text = Value.ToString();
            mainTxt.Text = "";
            remOp.Text = Operator.ToString();
        }



        private void ClearBtn_OnClick(object sender, RoutedEventArgs e)
        {
            remVal.Text = "";
            remOp.Text = "";
            Operator = null;
            Value = null;
            mainTxt.Text = "";
        }

        private void ClearEntryBtn_OnClick(object sender, RoutedEventArgs e)
        {
            mainTxt.Text = "";
        }

        private void BackSpcBtn_OnClick(object sender, RoutedEventArgs e)
        {
            switch (mainTxt.Text)
            {
                case "":
                    return;
                default:
                    mainTxt.Text = mainTxt.Text.Contains("-") && mainTxt.Text.Length == 2
                        ? mainTxt.Text.Substring(0, mainTxt.Text.Length - 2)
                        : mainTxt.Text.Substring(0, mainTxt.Text.Length - 1);
                    break;
            }
        }

        private void Dot_OnClick(object sender, RoutedEventArgs e)
        {
            if (mainTxt.Text != "" && !mainTxt.Text.Contains(",")) mainTxt.Text += ",";
        }

        private void EqualBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mainTxt.Text))
            {
                switch (Operator)
                {
                    case '+':
                        mainTxt.Text = (Value + Convert.ToDouble(mainTxt.Text)).ToString();
                        break;
                    case '-':
                        mainTxt.Text = (Value - Convert.ToDouble(mainTxt.Text)).ToString();
                        break;
                    case 'x':
                        mainTxt.Text = (Value * Convert.ToDouble(mainTxt.Text)).ToString();
                        break;
                    case '/':
                        mainTxt.Text = (Value / Convert.ToDouble(mainTxt.Text)).ToString();
                        break;
                }

                Value = null;
                Operator = null;
                remVal.Text = "";
                remOp.Text = "";
            }
            else
            {
                mainTxt.Text = $"{Value}";
                Value = null;
                Operator = null;
                remOp.Text = "";
                remVal.Text = "";
            }
        }

        private void PosNegBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (mainTxt.Text == "") return;

            if (mainTxt.Text[0] == '-')
            {
                mainTxt.Text = mainTxt.Text.Split('-')[1];
            }
            else
            {
                string temp = $"-{mainTxt.Text}";
                mainTxt.Text = temp;
            }
        }
    }
}


