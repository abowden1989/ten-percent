using System;
using System.Windows;
using System.Windows.Controls;
using CharCreator.Classes;
using CharCreator.Races;

namespace CharCreator.WizardPages
{
    /// <summary>
    /// Interaction logic for CharDetailsWizardPage.xaml
    /// </summary>
    public partial class CharDetailsWizardPage
    {
        public CharDetailsWizardPage()
        {
            InitializeComponent();
        }

        private void CharName_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            CharDetails.CanSelectNextPage = !string.IsNullOrEmpty(CharacterName.Text);
        }

        private void ClassComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            var classComboBox = sender as ComboBox;
            classComboBox.ItemsSource = Enum.GetValues(typeof(ClassName));
            classComboBox.SelectedIndex = 0;
        }
        }
    }
}
