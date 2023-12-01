using Insult_Generator_Thing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ComplimentInsultGenerator
{
    public sealed partial class InsultPage : Page
    {
        public InsultPage()
        {
            this.InitializeComponent();
        }
        private void GenerateInsultButton_Click(object sender, RoutedEventArgs e)
        {
            Insults insult = new Insults();
            Textblock.Text = insult.InsultGenerator();
        }
        private void InsultButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}