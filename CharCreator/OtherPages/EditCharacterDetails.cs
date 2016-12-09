namespace CharCreator.OtherPages
{
    public class EditCharacterDetails
    {
        public string PlayerName { get; set; }
        public EditCharacterDetails(IPlayerCharacter playerCharacter)
        {
            PlayerName = playerCharacter.PlayerName;
        }
    }
}
