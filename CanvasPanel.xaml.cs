﻿using System;
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

namespace DemoAboutLayout_WPF
{
    /// <summary>
    /// Interaction logic for CanvasPanel.xaml
    /// </summary>
    public partial class CanvasPanel : Window
    {
        public CanvasPanel()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            string CarInfo = $"Car Name : {txtCarName.Text} \nColor : {txtColor.Text} \nBrand : {txtBrand.Text}";
            MessageBox.Show(CarInfo, "Car Details");
        }
    }
}
