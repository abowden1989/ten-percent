using System.Windows;

namespace CharCreator.OtherPages
{
    /// <summary>
    /// Interaction logic for EditCharWindow.xaml
    /// </summary>
    public partial class EditCharWindow
    {
        private readonly EditCharacterDetails _editCharacterDetails;
        private readonly StartupWindow _startupWindow;
        public EditCharWindow(EditCharacterDetails editCharacterDetails, StartupWindow startupWindow)
        {
            _editCharacterDetails = editCharacterDetails;
            _startupWindow = startupWindow;
            InitializeComponent();
            DataContext = _editCharacterDetails;
        }

        private void CancelCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SaveCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            _startupWindow.UpdateCharacterDetails(_editCharacterDetails);
            Close();
        }
    }


}

