using Insult_Generator_Thing;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ComplimentInsultGenerator
{
    public sealed partial class InsultPage : Page
    {
        public InsultPage()
        {
            this.InitializeComponent();
        }
        /// <summary>
        /// Method that sets the textblock text to the insult returned from the InsultGenerator method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateInsultButton_Click(object sender, RoutedEventArgs e)
        {
            //Creates insult object in InsultPage.xaml.cs
            Insults insult = new Insults();
            //Assigns the TextBlock's text to the output of the InsultGenerator method
            Textblock.Text = insult.InsultGenerator();
        }
        /// <summary>
        /// Method that sends the user to the MainPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsultButton_Click(object sender, RoutedEventArgs e)
        {
            //Changes page from the InsultPage to the MainPage
            Frame.Navigate(typeof(MainPage));
        }
    }
}