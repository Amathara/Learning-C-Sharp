using System.ComponentModel;
using System.Runtime.CompilerServices;
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
using Microsoft.Win32;
using static System.Net.Mime.MediaTypeNames;

namespace BasicWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string boundText;
        public string BoundText
        {
            get { return boundText; }
            set
            {
                boundText = value;
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText")); - Old Method.
                OnPropertyChanged(); // We don'r have to write ("Bound Text") because the method uses [CallerMemberName]
            }
        }

        private ImageSource _boundImage;

        public ImageSource BoundImage
        {
            get { return _boundImage; }
            set 
            { 
                _boundImage = value; 
                OnPropertyChanged();
            }
        }
        private ImageSource _boundGif;

        public ImageSource BoundGif
        {
            get { return _boundGif; }
            set
            {
                _boundGif = value;
                OnPropertyChanged();
            }
        }

        public MainWindow()
        {
            DataContext = this; // would be a ViewModel in MVVM
            InitializeComponent();
        }

       

        public event PropertyChangedEventHandler? PropertyChanged;

       
        private void btnSet_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Vil du skrive den tekst?", "PAS PÅ!", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                BoundText = boundText;
            }
            else
            {
                BoundText = null;
            }
        }
        //Binding this to a button that opens a filepath and returns the name of the file picked.
        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "C# files| *.cs"; //This filters is so it shows ANY files with .cs at the end.
            fileDialog.InitialDirectory = "C:\\Users\\Amanda\\source\\repos"; //chooses what folder we start in.
            fileDialog.Title = "Nu SKAL du vælge .cs fil(er)! :)";
            //fileDialog.Multiselect = true;

            bool? success = fileDialog.ShowDialog();
            if (success == true)

            {
                string path = fileDialog.FileName;
                string fileName = fileDialog.SafeFileName; // Shows only the Safe File Name
                tbResult.Text = fileName;
            }
            else
            {
                //didn't pick anything!
            }
        }

        private void btnOpenImage_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Png  | *.png"; //This filters is so it shows ANY files with .cs at the end.
            fileDialog.InitialDirectory = "E:\\Downloads"; //chooses what folder we start in.
            fileDialog.Title = "Nu SKAL du vælge en .png fil! :)";
            //fileDialog.Multiselect = true;

            bool? success = fileDialog.ShowDialog();
            if (success == true)

            {
               BoundImage = new BitmapImage(new Uri(fileDialog.FileName));
            }
            else
            {
                //didn't pick anything!
            }
        }
        private void btnOpenGif_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "GIF FILES(*.gif) | *.gif"; //This filters is so it shows ANY files with .cs at the end.
            fileDialog.InitialDirectory = "E:\\Downloads"; //chooses what folder we start in.
            fileDialog.Title = "Nu SKAL du vælge en .gif fil! :)";
            //fileDialog.Multiselect = true;

            bool? success = fileDialog.ShowDialog();
            if (success == true)

            {
                var image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(fileDialog.FileName);
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.EndInit();

                WpfAnimatedGif.ImageBehavior.SetAnimatedSource(GifImageControl, image);
            }
            else
            {
                //didn't pick anything!
            }
        }

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}