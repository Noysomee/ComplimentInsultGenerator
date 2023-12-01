using Insult_Generator_Thing;
using Windows.Devices.Enumeration;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace ComplimentInsultGenerator
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void GenerateComplimentButton_Click(object sender, RoutedEventArgs e)
        {
            Compliments comp = new Compliments();
            Textblock.Text = comp.ComplimentGenerator();
        }
        private void ComplimentInsultButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InsultPage));
        }
    }
}