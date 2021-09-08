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
            if (sender is Button btn)
            {
                
            }
        }

        private void ClearBtn_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void ClearEntryBtn_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void BackSpcBtn_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void Dot_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void EqualBtn_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void PosNegBtn_OnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
