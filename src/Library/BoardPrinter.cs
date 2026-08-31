using System;
using System.Text;

namespace Ucu.Poo.GameOfLife
{
    /// <summary>
    /// Se encarga de imprimir el tablero en la consola.
    /// Cumple SRP porque su única responsabilidad es mostrar
    /// el estado del tablero al usuario.
    /// Cumple Expert porque tiene la información necesaria
    /// para recorrer e imprimir el tablero que recibe.
    /// </summary>
    public class BoardPrinter
    {
        /// <summary>
        /// Recorre el tablero recibido por parámetro y renderiza su contenido en la consola.
        /// </summary>
        public void Print(Board board)
        {
            // Limpia la consola para borrar la generación anterior y simular animación
            Console.Clear();

            // Utiliza StringBuilder para construir todo el texto en memoria 
            // antes de imprimirlo, optimizando el rendimiento de consola.
            StringBuilder s = new StringBuilder();

            // Bucle externo: recorre las filas (eje Y) de arriba hacia abajo
            for (int y = 0; y < board.Height; y++)
            {
                // Bucle interno: recorre las columnas (eje X) de izquierda a derecha
                for (int x = 0; x < board.Width; x++)
                {
                    // Evalúa el estado de la celda en la posición (x, y)
                    if (board.Cells[x, y])
                    {
                        // Representación visual para una celda viva
                        s.Append("|X|");
                    }
                    else
                    {
                        // Representación visual para una celda muerta
                        s.Append("___");
                    }
                }

                // Agrega un salto de línea al finalizar cada fila del tablero
                s.Append("\n");
            }

            // Muestra en la pantalla todo el tablero generado de una sola vez
            Console.WriteLine(s.ToString());
        }
    }
}