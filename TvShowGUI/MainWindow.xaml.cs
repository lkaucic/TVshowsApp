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
using TvShowCode;

namespace TvShowGUI
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

        private void ConfirmSearch_Click(object sender, RoutedEventArgs e)
        {
            string title = SearchInput.Text;
            var shows = ApiHelper.GetShowsByName(title);
            ShowsListBox.ItemsSource = shows;
            ShowsListBox.Items.Refresh();
        
        }

        private void ShowsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var shows = ShowsListBox.SelectedItem as BestFit;
            SeasonsList.ItemsSource = ApiHelper.GetSeasonsOfShow(shows.Show.Id);
            SeasonsList.Items.Refresh();

            ShowNameBox.Text = shows.Show.Name;
            ShowLanguageBox.Text = shows.Show.Language;
            ShowRatingBox.Text = shows.Show.Rating.ToString();
            if(ShowRatingBox.Text == "")
            {
                ShowRatingBox.Text = "N.A.";
            }
            ShowGenresBox.Text = String.Join(", ", shows.Show.Genres);

            ShowStatusBox.Text = shows.Show.Status; 
        }

        private void SeasonsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var season = SeasonsList.SelectedItem as Season;
            var episodes = ApiHelper.GetEpisodesOfShow(season.Id);
            EpisodesList.ItemsSource = episodes;
            EpisodesList.Items.Refresh();
        }

        private void EpisodesList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var episode = EpisodesList.SelectedItem as Episode;

            EpisodeWindow window = new EpisodeWindow();
            window.EpisodeNameBox.Text = episode.Name;
            window.EpisodeRuntimeBox.Text = Convert.ToString(episode.Runtime);
            window.EpisodeTypeBox.Text = episode.Type;

            
            if (episode.Image != null)
            {
                BitmapImage image = new BitmapImage(new Uri(episode.Image.Original));
                window.ShowImage.Source =image;
            }

            string summary = episode.Summary;
            if (summary != null)
            {
                summary = summary.Replace("<p>", "");
                summary = summary.Replace("</p>", "");
                summary = summary.Replace("<i>", "");
                summary = summary.Replace("<br>", "");
                window.SummaryBox.Text = summary;
            }

            window.Show();

        }

         private void XKCD_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int number = rand.Next(1, 2400);

            var comic = ApiHelper.GetComic(number);

            Xkcd window = new Xkcd();

            window.Box1.Text = comic.Title;

            BitmapImage image = new BitmapImage(new Uri(comic.Img));
            if (image != null)
            {
                window.ShowComic.Source = image;
            }

            window.Show();
        }
    }
}
