namespace TicTacToe.Core
{
    /// <summary>
    /// Класс для создания игровой доски
    /// </summary>
    public class Board
    {
        private Square[] squares;
        /// <summary>
        /// Получить массив квадратов
        /// </summary>
        public Square[] Squares
        {
            get
            {
                if (squares.Length != 0)
                {
                    return squares;
                }
                return null;
            }
        }

        public Board()
        {
            squares = new Square[9];
        }
        /// <summary>
        /// Создать новое игровое поле.
        /// </summary>
        public void CreateBoard()
        {
            for (int i = 0; i < squares.Length; i++)
            {
                squares[i] = new Square();
            }
        }
    }
}
