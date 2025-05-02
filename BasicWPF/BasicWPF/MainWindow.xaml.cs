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

namespace BasicWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this; // would be a ViewModel in MVVM
            InitializeComponent();
        }

        private string boundText;

        public event PropertyChangedEventHandler? PropertyChanged;

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
            fileDialog.Filter = "C# Source Files | *.cs"; //This filters is so it shows ANY files with .cs at the end.
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

        

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}