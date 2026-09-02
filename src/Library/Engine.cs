namespace Ucu.Poo.GameOfLife
{
    public class Engine
    {
        public static void CalcularSiguienteGeneracion(Board board)
        {
            int boardWidth = board.Width;
            int boardHeight = board.Height;

            Board cloneboard = new Board(boardWidth, boardHeight);

            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    int aliveNeighbors = 0;

                    for (int i = x - 1; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && board.GetCell(i, j))
                            {
                                aliveNeighbors++;
                            }
                        }
                    }

                    if (board.GetCell(x, y))
                    {
                        aliveNeighbors--;
                    }

                    if (board.GetCell(x, y) && aliveNeighbors < 2)
                    {
                        cloneboard.SetCell(x, y, false);
                    }
                    else if (board.GetCell(x, y) && aliveNeighbors > 3)
                    {
                        cloneboard.SetCell(x, y, false);
                    }
                    else if (!board.GetCell(x, y) && aliveNeighbors == 3)
                    {
                        cloneboard.SetCell(x, y, true);
                    }
                    else
                    {
                        cloneboard.SetCell(x, y, board.GetCell(x, y));
                    }
                }
            }

            // Actualizamos el tablero original volcando los datos del clon
            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    board.SetCell(x, y, cloneboard.GetCell(x, y));
                }
            }
        }
    }
}