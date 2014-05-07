namespace Nightmare {
    /// <summary>
    /// Пользователь игры. Для идентификации и установления набора персонажей. 
    /// Несколько людей могут играть в игру под разными аккаунтами не смешивая игровых персонажей
    /// </summary>
    public class Users {
        public string Login { get; set; }
        public string Password  { get; set; }
    }
}