namespace Nightmare {
    /// <summary>
    /// Флакон восстановления жизни
    /// </summary>
    public class LifePoiton : Item {
        public void Use(Character character) {
            new ExpierenceService().FillLife(character);
        }
    }
}