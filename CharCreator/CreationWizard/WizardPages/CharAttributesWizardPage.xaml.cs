using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CharCreater.WizardPages
{
    /// <summary>
    /// Interaction logic for CharAttributesWizardPage.xaml
    /// </summary>
    public partial class CharAttributesWizardPage
    {
        public CharAttributesWizardPage()
        {
            InitializeComponent();
        }

        private void AttComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            var attComboBox = sender as ComboBox;
            attComboBox.ItemsSource = Enumerable.Range(6, 30).ToArray();
            attComboBox.SelectedIndex = 4;
        }
    }
}
