using Insult_Generator_Thing;
using System;
using System.Drawing;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;


namespace ComplimentInsultGenerator
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            Compliments comp = new Compliments();
            Textblock.Text = comp.ComplimentGenerator();
        }
        private void ComplimentInsultButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}