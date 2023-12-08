using Insult_Generator_Thing;
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
        /// <summary>
        /// Method that sets the textblock text to the compliment returned from the ComplimentGenerator method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateComplimentButton_Click(object sender, RoutedEventArgs e)
        {
            //Creates comp object in MainPage.xaml.cs
            Compliments comp = new Compliments();
            //Assigns the TextBlock's text to the output of the ComplimentGenerator method
            Textblock.Text = comp.ComplimentGenerator();
        }
        /// <summary>
        /// Method that sends the user to the InsultPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComplimentInsultButton_Click(object sender, RoutedEventArgs e)
        {
            //Changes page from the MainPage to the InsultPage
            Frame.Navigate(typeof(InsultPage));
        }
    }
}