using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3Game.Concrete
{
    class CellManager
    {
        public void clearBackColorCells(Cell [,] cells)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    cells[i, j].BackColor = Color.LightGray;
                }
            }
        }
        public void showAllCells(Cell[,] cells)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    cells[i, j].Text = cells[i, j].Value.ToString();
                }
            }
        }
    }
}
