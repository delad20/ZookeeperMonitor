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
using ZookeeperMonitor.ViewModel;

namespace ZookeeperMonitor.View
{
    /// <summary>
    /// Interaction logic for ZooKeeperView.xaml
    /// </summary>
    public partial class ZooKeeperView : Window
    {
        public ZooKeeperView()
        {
            // Position window in the center of the screen
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            InitializeComponent();
        }

        /// <summary>
        /// Don't know why I need this. Investigate
        /// </summary>
        private void scroll(object sender, TextChangedEventArgs e)
        {
            zkScrollView.ScrollToBottom();
        }
    }
}
