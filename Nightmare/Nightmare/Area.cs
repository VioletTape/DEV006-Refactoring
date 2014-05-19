using System.Collections.Generic;

namespace Nightmare {
    /// <summary>
    /// Класс содержит информацию об области где находится главный герой. 
    /// В зависимости от типа области накладываются штрафы или бонусы на героя 
    /// (так же зависят от способностей героя) 
    /// </summary>
    public class Area {
        public string Name;
        public AreaType AreaType;
        /// <summary>
        /// 
        /// </summary>
        public bool IsFightArea;
        /// <summary>
        /// зона торговли или нет
        /// </summary>
        public bool IsMerchArea;
        /// <summary>
        /// является ли это скрытой областью, которая открывается спец.средствами
        /// </summary>
        public bool IsSecretArea;
        /// <summary>
        /// количество опыта герою за открытие зоны 
        /// </summary>
        public int DiscoverXp;

        private List<Beast> enemies = new List<Beast>();

        /// <summary>
        /// Создание класса
        /// </summary>
        public Area() {

            if (IsFightArea) {
                // todo: здесь надо генерировать список вражин для героя в этой местности
            }

            if (IsMerchArea) {
                // todo: реализовать торговлю
            }
        }

        public void PlayerEnter(Character character) {
            new ExpierenceService().AddXp(character, DiscoverXp);

//            if (character.Level > 10) {
//                var bee = new Bee();
//                var lion = new Lion();

//                character.Attack();
//            }
        }
    }
}