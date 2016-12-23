using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows;
using System.Xml;
using CharCreater.WizardPages;
using CharCreator.Names;
using CharCreator.OtherPages;

namespace CharCreator
{
    /// <summary>
    /// Interaction logic for StartupWindow.xaml
    /// </summary>

    public partial class StartupWindow
    {
        private IPlayerCharacter _playerCharacter;
        public StartupWindow()
        {
            InitializeComponent();
        }

        private void NewCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            var newCharWindow = new NewCharWizardWindow();
            newCharWindow.ShowDialog();

            string Class = newCharWindow.CharDetailsPage.CharClass.Text;
            _playerCharacter = (IPlayerCharacter) Activator.CreateInstance(AvailableClasses.ClassDictionary[Class]);

            _playerCharacter.PlayerName = newCharWindow.CharDetailsPage.CharacterName.Text;
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
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog
                {
                    FileName = _playerCharacter.PlayerName, // Default file name
                    DefaultExt = ".xml", // Default file extension
                    Filter = "XML documents (.xml)|*.xml" // Filter files by extension
                };
                var result = dlg.ShowDialog();

                // Process open file dialog box results
                if (result == true)
                {
                    // Open document
                    var filePath = dlg.FileName;
                    var classTypes = AvailableClasses.ClassDictionary.Values.ToArray();
                    var serializer = new DataContractSerializer(typeof(PlayerCharacter), classTypes);

                    using (var fw = XmlWriter.Create(filePath))
                    {
                        serializer.WriteObject(fw, (PlayerCharacter) _playerCharacter);
                    }
                    MessageBox.Show("Character saved");
                }
                else
                {
                    MessageBox.Show("Load cancelled");
                }
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
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog
                {
                    FileName = "Document", // Default file name
                    DefaultExt = ".xml", // Default file extension
                    Filter = "XML documents (.xml)|*.xml" // Filter files by extension
                };

                var result = dlg.ShowDialog();

                // Process open file dialog box results
                if (result == true)
                {
                    // Open document
                    var filePath = dlg.FileName;
                    var classTypes = AvailableClasses.ClassDictionary.Values.ToArray();
                    var serializer = new DataContractSerializer(typeof(PlayerCharacter), classTypes);

                    var charFile = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    var buffer = new byte[charFile.Length];
                    charFile.Read(buffer, 0, (int) charFile.Length);
                    using (var stream = new MemoryStream(buffer))
                    {
                        _playerCharacter = (IPlayerCharacter) serializer.ReadObject(stream);
                    }
                    MessageBox.Show("Character loaded");
                }
                else
                {
                    MessageBox.Show("Load cancelled");
                }

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
