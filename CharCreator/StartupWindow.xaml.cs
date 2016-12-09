using System;
using System.IO;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;
using CharCreater.WizardPages;
using CharCreator.OtherPages;

namespace CharCreator
{
    /// <summary>
    /// Interaction logic for StartupWindow.xaml
    /// </summary>
    public partial class StartupWindow
    {
        private PlayerCharacter _playerCharacter;
        public StartupWindow()
        {
            InitializeComponent();
        }

        private void NewCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            var newCharWindow = new NewCharWizardWindow();
            newCharWindow.ShowDialog();
            _playerCharacter = new PlayerCharacter
            {
                PlayerName = newCharWindow.CharDetailsPage.CharacterName.Text,
                Class = newCharWindow.CharDetailsPage.CharClass.Text
            };
            var charAttributes = FillAttributeArray(newCharWindow.CharAttributesPage);
            _playerCharacter.SetAttributes(charAttributes);
        }

        private void SaveCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            if (_playerCharacter == null)
            {
                MessageBox.Show("No character available");
                return;
            }

            try
            {
                var fileName = _playerCharacter.PlayerName;
                var filePath =
                    @"C:\Users\Adam.Bowden\Documents\Visual Studio 2015\Projects\CharCreator\CharCreator\bin\Debug\" +
                    fileName + ".xml";
                var fw = XmlWriter.Create(filePath);
                XmlSerializer serializer = new XmlSerializer(_playerCharacter.GetType());
                serializer.Serialize(fw,_playerCharacter);
                MessageBox.Show("Character saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Attempt to save failed:" + ex);
            }
        }

        private void LoadCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string filePath = null;
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                dlg.FileName = "Document"; // Default file name
                dlg.DefaultExt = ".xml"; // Default file extension
                dlg.Filter = "XML documents (.xml)|*.xml"; // Filter files by extension
                bool? result = dlg.ShowDialog();

                // Process open file dialog box results
                if (result == true)
                {
                    // Open document
                    filePath = dlg.FileName;
                }
                var serializer = new XmlSerializer(typeof (PlayerCharacter));
                var charFile = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                var buffer = new byte[charFile.Length];
                charFile.Read(buffer, 0, (int) charFile.Length);
                var stream = new MemoryStream(buffer);
                _playerCharacter = (PlayerCharacter)serializer.Deserialize(stream);
                MessageBox.Show("Character loaded");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Attempt to load failed:" + ex);
            }
        }

        private void EditCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            var editCharDetails = new EditCharacterDetails(_playerCharacter);
            var editCharWindow = new EditCharWindow(editCharDetails, this);
            editCharWindow.ShowDialog();
        }

        internal void UpdateCharacterDetails(EditCharacterDetails editCharacterDetails)
        {
            _playerCharacter.PlayerName = editCharacterDetails.PlayerName;
        }

        private static int[] FillAttributeArray(CharAttributesWizardPage charAttributesPage)
        {
            var charStrength = int.Parse(charAttributesPage.CharStrength.Text);
            var charDexterity = int.Parse(charAttributesPage.CharDexterity.Text);
            var charConstitution = int.Parse(charAttributesPage.CharConstitution.Text);
            var charIntelligence = int.Parse(charAttributesPage.CharIntelligence.Text);
            var charWisdom = int.Parse(charAttributesPage.CharWisdom.Text);
            var charCharisma = int.Parse(charAttributesPage.CharConstitution.Text);
            int[] charAtts = {charStrength,charDexterity,charConstitution,charIntelligence,charWisdom,charCharisma};
            return charAtts;
        }
    }
}
