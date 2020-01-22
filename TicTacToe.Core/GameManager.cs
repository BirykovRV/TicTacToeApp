
namespace TicTacToe.Core
{
    /// <summary>
    /// Класс для создания игры Крестики-Нолики.
    /// </summary>
    public class GameManager
    {
        private Board board;
        /// <summary>
        /// Получить или установить имя игрока.
        /// </summary>
        public string GetPlayer
        {
            get
            {
                return IsNext ? "X" : "O";
            }
        }
        /// <summary>
        /// пер
        /// </summary>
        public bool IsNext { get; set; } = true;

        readonly int[,] winCombination =
        {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8},
            {0, 4, 8},
            {2, 4, 6},
            {0, 3, 6},
            {1, 4, 7},
            {2, 5, 8}
        };
        public GameManager(Board board)
        {
            this.board = board;
        }
        /// <summary>
        /// Отобразить поле с позициями клеток.
        /// </summary>
        /// <returns> Вернёт строковое представление игрового поля. </returns>
        public string DisplayBoard()
        {
            var result = "";
            int counter = 1;
            for (int i = 0; i < board.Squares.Length; i++)
            {
                if (counter > 3)
                {
                    result += "\r\n";
                    counter = 1;
                }
                result += $"[{board.Squares[i].Player}]\t";
                counter++;
            }
            return result;
        }
        /// <summary>
        /// Заполнить игровой квадрат на поле игроком.
        /// </summary>
        /// <param name="index"> Позиция в массиве. </param>
        /// <param name="playerName"> Имя игрока. </param>
        public void FillSquare(int index, string playerName)
        {
            if (board.Squares != null)
            {
                board.Squares[index].Player = playerName;
            }
        }
        /// <summary>
        /// Получить победителя.
        /// </summary>
        /// <returns> Вернёт название игрока или пустую строку. </returns> 
        public string GetWiner()
        {
            var row = winCombination.GetUpperBound(0) + 1;
            var column = winCombination.GetUpperBound(1) + 1;
            string result = "";
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    var a = (int)winCombination.GetValue(i, 0);
                    var b = (int)winCombination.GetValue(i, 1);
                    var c = (int)winCombination.GetValue(i, 2);
                    if (!string.IsNullOrEmpty(board.Squares[a].Player))
                    {
                        if (board.Squares[a].Player == board.Squares[b].Player && board.Squares[a].Player == board.Squares[c].Player)
                        {
                            result = board.Squares[a].Player;
                        }
                    }
                }
            }
            return result;
        }
    }
}
