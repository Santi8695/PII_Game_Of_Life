using System.Data;
using System.Text.RegularExpressions;

namespace Ucu.Poo.GameOfLife
{
    public class Board
    {
        private bool[,] cells;
        public bool[,] Cells
        {
            get{return cells;} 
            set {Cells = value;}
        }
        
        public Board(bool[,] tablero)
        {
            this.cells = tablero;
        }
        public int height
        {
            get {return cells.GetLength(0);}
        }
        public int width
        {
            get {return cells.GetLength(1);}
        }
    }
}
