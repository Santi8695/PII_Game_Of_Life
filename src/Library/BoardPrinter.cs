using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    public class BoardPrinter
    {
        public static void ImprimirTablero(Board board)
        {
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y < board.Height; y++)
                {
                    for (int x = 0; x < board.Width; x++)
                    {
                        if (board.GetCell(x, y))
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                //=================================================
                //Invocar método para calcular siguiente generación
                //=================================================
                Engine.CalcularSiguienteGeneracion(board);
                Thread.Sleep(300);
            }

        }
    }
}

