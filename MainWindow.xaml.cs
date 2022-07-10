using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace BlazeFN
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LaunchBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("PathTextBox.Text -AUTH_LOGIN=" + MailTextBox.Text + " -AUTH_PASSWORD=" + PassTextBox.Text + " -AUTH_TYPE=epic" + "-noeac -fromfl=be -fltoken=h1h4370717422124b232eFac -epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal");
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            


        }
    }
}