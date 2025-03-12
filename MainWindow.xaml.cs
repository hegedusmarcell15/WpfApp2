﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int szam1 = 0;
        int szam2 = 0;
        string muvelet = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "0";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "1";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "3";

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "4";

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "5";

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "6";

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "7";

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "8";

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "9";

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            // + gomb
            szam1 = int.Parse(textbox1.Text);
            lbDebug.Content = szam1;
            lbDebug.Visibility = Visibility.Visible;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "0";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            szam1 = int.Parse(textbox1.Text);
            lbDebug.Content = szam1;
            lbDebug.Visibility = Visibility.Visible;

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (szam1 == 0) szam1 = int.Parse(textbox1.Text); else szam2 = int.Parse(textbox1.Text);
            lbDebug.Content = szam1 + "+" + szam2;
            textbox1.Text = "";
            muvelet = "+";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            if (szam1 == 0) szam1 = int.Parse(textbox1.Text); else szam2 = int.Parse(textbox1.Text);
            lbDebug.Content = szam1 + "-" + szam2;
            textbox1.Text = "";
            muvelet = "-";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            szam2 = int.Parse(textbox1.Text);
            var eredmeny = 0;
            switch (muvelet)
            {
                case "+":
                    eredmeny = szam1 + szam2;
                    break;
                case "-":
                    eredmeny = szam1 - szam2;
                    break;
                default:
                    break;
            }
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "";
            lbDebug.Content = "";
            szam1 = 0; szam2 = 0;
        }
    }
}