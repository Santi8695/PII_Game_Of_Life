using System.IO;

namespace Ucu.Poo.GameOfLife
{
    /// <summary>
    /// Clase que se encarga de importar el tablero de un archivo 
    /// </summary>
    public class BoardImporter
    {
        public bool[,] ImportarTablero()
        {
            string url = @".\assets\board.txt";
            string[] contentLines = File.ReadAllLines(url);
            int height = contentLines.Length;
            int width = contentLines[0].Length;
            bool[,] board = new bool[width, height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < contentLines[y].Length; x++)
                {
                    if (contentLines[y][x] == '1')
                    {
                        board[x, y] = true;
                    }
                }
            }           
            return board;
        }
    }
}