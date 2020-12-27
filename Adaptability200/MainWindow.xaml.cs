﻿using Adaptability200.ViewModel;
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

namespace Adaptability200
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ToDB_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new DBViewModel();
        }

        private void ToTest_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new TestViewModel();
        }

        private void ToSettings_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new PasswordViewModel();
        }
    }
}
