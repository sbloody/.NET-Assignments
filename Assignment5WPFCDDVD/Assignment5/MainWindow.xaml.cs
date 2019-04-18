
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace Assignment5
{
    public partial class MainWindow : Window
    {

        List<Multimedia> multiMediaList = new List<Multimedia>();

        public MainWindow()
        {

            InitializeComponent();

            multiMediaList.Add(new Multimedia("Under Byen", "Under Byen", "Progressive", Multimedia.MediaType.DVD));
            multiMediaList.Add(new Multimedia("Master of Puppets", "Metallica", "Metal Rock", Multimedia.MediaType.CD));
            multiMediaList.Add(new Multimedia("Chemtrails", "Beck", "Indie Rock", Multimedia.MediaType.DVD));

            mediaListBox.ItemsSource = from media in multiMediaList
                                       select media._artist + ": " + media._title;

            WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }

        private void AddNewMediaButton_Click(object sender, RoutedEventArgs e)
        {
            NewMediaItem newMediaItemWindow = new NewMediaItem(this);
            newMediaItemWindow.ShowDialog();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            titleTextBox.Text = multiMediaList[mediaListBox.SelectedIndex]._title;
            artistTextBox.Text = multiMediaList[mediaListBox.SelectedIndex]._artist;
            genreTextBox.Text = multiMediaList[mediaListBox.SelectedIndex]._genre;
            typeTextBox.Text = multiMediaList[mediaListBox.SelectedIndex]._type.ToString();
        }

        public void SetMultiMediaList(Multimedia multiMedia)
        {
            if (multiMedia != null)
            {
                multiMediaList.Add(multiMedia);
                mediaListBox.ItemsSource = from media in multiMediaList
                                           select media._artist + ": " + media._title;
            }

        }

    }

}

