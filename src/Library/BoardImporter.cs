using System.IO;

namespace Ucu.Poo.GameOfLife
{
    public class BoardImporter
    {

        public static Board ImportarTablero()
        {
            string url = @"../../assets/board.txt";
            string content = File.ReadAllText(url);
            string[] contentLines = content.Split('\n');

            int height = contentLines.Length; //altura total del arreglo contentLines(renglones del archivo)
            int width = contentLines[0].Length; //total de caracteres en primer renglon, es el ancho de la tabla
            Board board = new Board(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x < contentLines[y].Length && contentLines[y][x] == '1')
                    {
                        board.SetCell(x, y, true);
                    }
                    else
                    {
                        board.SetCell(x, y, false);
                    }
                }
            }
            return board;
        }
    }
}