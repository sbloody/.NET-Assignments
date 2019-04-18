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
using System.Windows.Shapes;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for NewMediaItem.xaml
    /// </summary>
    public partial class NewMediaItem : Window
    {
        MainWindow mainWindow;
        public NewMediaItem(MainWindow mainWindow)
        {
            InitializeComponent();
            mediaTypeComboBox.ItemsSource = Enum.GetValues(typeof(Multimedia.MediaType));
            this.mainWindow = mainWindow;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(titleTextBox.Text) && !string.IsNullOrWhiteSpace(artistTextBox.Text) && !string.IsNullOrWhiteSpace(genreTextBox.Text) && mediaTypeComboBox.SelectedIndex != -1)
                mainWindow.SetMultiMediaList(new Multimedia(titleTextBox.Text, artistTextBox.Text, genreTextBox.Text, (Multimedia.MediaType)mediaTypeComboBox.SelectedValue));
            else mainWindow.SetMultiMediaList(null);
            this.Close();
        }

    }
}
