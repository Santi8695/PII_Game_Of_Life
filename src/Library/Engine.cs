//Clase que aplica las reglas del juego de la vida

using System.Reflection.Metadata;

namespace Ucu.Poo.GameOfLife
{

    /// <summary>
    /// Representa el motor del juego de la vida.
    /// </summary>
    
    public class Engine
    {   
        public Board NewGeneration(Board currentBoard)
        {
            int width= currentBoard.width;
            int length= currentBoard.length;
            Board nextBoard= new Board (width, length);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < length; y++)
                {
                    int aliveNeighbors= CountAliveNeighbors(currentBoard, x, y);
                    bool currentStatus= currentBoard.GetCell(x, y).IsAlive;
                    bool nextStatus= false;
                    //Por defecto estan muertas, solo si se cumplen los if se ponen en vivas
                    if (currentStatus && (aliveNeighbors==2 || aliveNeighbors==3))
                    //Celula sobrevive
                    {
                        nextStatus= true;
                    }
                    else if (!currentStatus &&(aliveNeighbors==3))
                    //Celula nace
                    {
                        nextStatus=true;
                    }
                    nextBoard.SetCells(x, y, nextStatus);
                }
            }
            return nextBoard;
        }

        private int CountAliveNeighbors(Board board, int x, int y)
        {
            int count = 0;
            for (int i = x-1; i<=x+1;i++)
            {
                for (int j = y-1;j<=y+1;j++)
                {
                    if(i>=0 && i<board.Width && j>=0 && j<board.Length && board.GetCell(i, j).IsAlive)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
