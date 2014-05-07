namespace Nightmare {
    /// <summary>
    /// флакон выносливости
    /// </summary>
    public class StaminaPoiton : Item {
        public void Use(Character character) {
            new ExpierenceService().FillStamina(character);
        }
    }
}