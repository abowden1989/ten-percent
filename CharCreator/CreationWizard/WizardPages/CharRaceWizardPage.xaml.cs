using System;
using System.Windows;
using System.Windows.Controls;
using CharCreator.Races;

namespace CharCreator.CreationWizard.WizardPages
{
    /// <summary>
    /// Interaction logic for CharRaceWizardPage.xaml
    /// </summary>
    public partial class CharRaceWizardPage
    {
        public CharRaceWizardPage()
        {
            InitializeComponent();
        }

        private void RaceComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            var raceComboBox = sender as ComboBox;
            raceComboBox.ItemsSource = Enum.GetValues(typeof(RaceName));
            raceComboBox.SelectedIndex = 0;
        }

    }
}
