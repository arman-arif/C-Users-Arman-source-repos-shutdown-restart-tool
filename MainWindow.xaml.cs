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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace shutdown_restart_tool
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

        private void btnRestart_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/r /t 0");
        }

        private void btnShutdown_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");
        }
    }
}
