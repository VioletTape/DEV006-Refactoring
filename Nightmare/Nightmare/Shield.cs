namespace Nightmare {
    /// <summary>
    /// Щит
    /// </summary>
    public class Shield : Item {
        /// <summary>
        /// Номер предмета
        /// </summary>
        public int Id;
        /// <summary>
        /// Урон который может нанести оружие
        /// </summary>
        public int Defence;

        public bool Equiped;

        public Shield() {
            Type = "S";
        }

        public bool CanWearFor(Player player) {
            return true;
        }
    }
}