using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3Game.Concrete
{
    //İpucları için ( <,> gibi) kullanacagımız nesneyi oluşturuyoruz.
    class Clues:Label
    {
        public int X { get; set; }
        public int Y { get; set; }
        //Nesnelerin textlerini temizlemek için Clear isminde bir metot tanımıyoruz
        public void Clear()
        {
            this.Text = String.Empty;
        }

        public void createClueLabelsHorizontal(Clues[,] clues, GroupBox groupBox)
        {
            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 5; j++)
                {

                    clues[i, j] = new Clues();
                    clues[i, j].Size = new Size(20, 20);
                    clues[i, j].Location = new Point((i * (60) + 73), (j * (60) + 48));
                    clues[i, j].Text = String.Empty;
                    clues[i, j].X = i;
                    clues[i, j].Y = j;

                    groupBox.Controls.Add(clues[i, j]);

                }


            }

        }
        public void createClueLabelsVertical(Clues[,] clues, GroupBox groupBox)
        {
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 4; j++)
                {

                    clues[i, j] = new Clues();
                    clues[i, j].Size = new Size(20, 20);
                    clues[i, j].Location = new Point((i * (60) + 45), (j * (60) + 70));
                    clues[i, j].Text = String.Empty;
                    clues[i, j].X = i;
                    clues[i, j].Y = j;

                    groupBox.Controls.Add(clues[i, j]);

                }


            }

        }


    }
}
