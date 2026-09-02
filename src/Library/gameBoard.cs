using System;

namespace Ucu.Poo.GameOfLife
{
    public class Board
    {
        private bool[,] cells;

        public bool[,] GetCells()
        {
            return cells;
        }

        public bool GetCell(int x, int y)
        {
            return cells[x, y];
        }

        public void SetCell(int posX, int posY, bool valor)
        {
            cells[posX, posY] = valor;
        }

        private int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public Board(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.cells = new bool[width, height];
        }


    }
}