using System.Windows;

namespace WPF_TEST
{
    /// <summary>
    /// Interaction logic for NoteMenu.xaml
    /// </summary>
    public partial class NoteMenu : Window
    {
        public NoteMenu()
        {
            InitializeComponent();
        }

        private void ButtonImage_OnClick(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog
            {
                DefaultExt = ".png",
                Filter =
                    "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
            };

            // Display OpenFileDialog by calling ShowDialog method 
            bool? result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result != true) return;
            // Open document 
            string filename = dlg.FileName;
            ImageBox.Text = filename;
        }
    }
}
