namespace Nightmare {
    /// <summary>
    /// Одежка для главного героя
    /// </summary>
    public class Wear : Item {
        /// <summary>
        /// Уникальный номер предмета
        /// </summary>
        public int Id;
        /// <summary>
        /// Добавляет ли одежа бонус к атаке
        /// </summary>
        public int Attack;
        /// <summary>
        /// Добавляет ли одежа бонус к защиет
        /// </summary>
        public int Defence;

        /// <summary>
        /// Одета ли вещь на героя
        /// </summary>
        public bool Equiped;

        public Wear() {
            Type = "Wr";
        }

        /// <summary>
        /// Определяет может ли герой носит эту конкретную вещь
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public bool CanWearFor(Player player) {
            return true;
        }
    }
}