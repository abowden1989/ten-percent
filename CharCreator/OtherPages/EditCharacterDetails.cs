namespace CharCreator.OtherPages
{
    public class EditCharacterDetails
    {
        public string PlayerName { get; set; }
        public EditCharacterDetails(PlayerCharacter playerCharacter)
        {
            PlayerName = playerCharacter.PlayerName;
        }
    }
}
