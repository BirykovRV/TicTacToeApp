namespace TicTacToe.Core
{
    /// <summary>
    /// Представляет квадрат внутри поля.
    /// </summary>
    public class Square
    {
        private string player;
        /// <summary>
        /// Получить или установить имя игрока который выбрал это поле.
        /// </summary>
        public string Player
        {
            get
            {
                return player;
            }
            set
            {
                if (value.Equals("X") || value.Equals("O"))
                {
                    player = value;
                }
            }
        }
    }
}
