using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3Game.Concrete
{
    //Cell isminde button class'ından inheritance alan
    //classımızı (nesnemizi) oluşturduk.
    class Cell : Button
    {
        public int Value { get; set; }
        public bool IsLocked { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        //nesne'nin özelliklerini 0'lamak için clear metodumuzu yazdık.
        public void Clear()
        {
            this.Text = string.Empty;
            this.IsLocked = false;
        }

        public void createCells(Cell[,] cells, GroupBox groupBox)
        {
            //5'e 5 lik bir oyun istediğimiz için döngülerimiz 
            //ona göre oluşturuldu.
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    //oluşmasını istediğimiz nesneyi newleyip özelliklerini belirliyoruz.
                    cells[i, j] = new Cell();
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 15);
                    cells[i, j].Size = new Size(30, 30);
                    cells[i, j].ForeColor = SystemColors.ControlDarkDark;
                    cells[i, j].Location = new Point((i * (60) + 35), (j * (60)) + 35);
                    cells[i, j].BackColor = Color.LightGray;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.Black;
                    cells[i, j].X = i;
                    cells[i, j].Y = j;

                    //nesnemize tıklanma durumunda oluşacak eventi tanımlıyoruz.
                    cells[i, j].KeyPress += cell_keyPressed;
                    //Oyun alanı için oluşturduğumuz groupbox'ın kontrollerine ekliyoruz.
                    groupBox.Controls.Add(cells[i, j]);

                }


            }
        }
        private void cell_keyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Cell;
            //eğer nesnemiz kilitliyse bir değişklik yaptırmıyoruz.
            if (cell.IsLocked)
                return;
            int value;

            //girilien değerin sayısal mı yoksa metinsel mi oldugunu kontrol ediyoruz.
            //eger sayısalda ona göre işlemlerimiz yönlendiriyoruz.
            //metinsel girişlerde her hangi bir işlem yapılmamaktadır bu durumda.
            if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                //0 değerini oyunda kullanmayacagımız için burada alanımızın
                //clear metodunu tetiklemek için kullanıyoruz.
                if (value == 0)
                    cell.Clear();
                else
                {
                    //girilen değer nesnemizin textine atılarak burada yazılıyor.
                    cell.Text = value.ToString();
                }
                cell.ForeColor = SystemColors.ControlDarkDark;

            }
        }
    }
}
