using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3Game.Concrete
{
    class CluesManager
    {
        public void showRandomValuesHints(Random random, Cell[,] cells, int hintsCount)
        {
            //İpucu sayısı kadar dönecek bir döngü kuruyor ve her döngüde bir defa 
            //ipucu üretiyoruz.
            for (int i = 0; i < hintsCount; i++)
            {
                //X ve Y yönünde ki alanlarımızı temsilen rX ve rY yi 
                //oluşturup değer olarak max 5 olacak şekilde random sayı atıyoruz.
                var rX = random.Next(5);
                var rY = random.Next(5);

                //eğer oluşturulan rastgele ipuculu nesne daha önceden kilitlendiyse tekrardan yeni
                //random değerler güncellenir ve bu işlem yeni seçilen nesnemiz kilitli olmayana kadar devam eder.
                while (cells[rX, rY].IsLocked)
                {
                    rX = random.Next(5);
                    rY = random.Next(5);
                }

                cells[rX, rY].Text = cells[rX, rY].Value.ToString();
                cells[rX, rY].ForeColor = Color.Black;
                //Burada ipuculu nesneyi Locklayarak onun değerinin değişmesini ya da 
                //silinmesini engelliyoruz.
                cells[rX, rY].IsLocked = true;
            }
        }
        public void showRandomClueLabelsHorizontal(Random random, Cell[,] cells, Clues[,] clues, int clueCount)
        {
            //İstediğimiz sayıda ipucu üretmek için döngümüzü kuruyoruz.
            for (int i = 0; i < clueCount; i++)
            {
                //üretilecek ipucunun nerede olacagını random seçmek için rX ve rY değişkenlerini kullanıyoruz
                var rX = random.Next(4);
                var rY = random.Next(4);

                //koyacagımız işarete göre kıyaslanan nesnelerin büyüklük küçüklüğünü kontrol ediyoruz 
                if (cells[rX, rY].Value < cells[(rX + 1), rY].Value)
                {
                    clues[rX, rY].Text = "<";
                }
                else
                {
                    clues[rX, rY].Text = ">";
                }

            }
        }
        public void showRandomClueLabelsVertical(Random random, Cell[,] cells, Clues[,] clues, int clueCount)
        {
            for (int i = 0; i < clueCount; i++)
            {
                var rX = random.Next(4);
                var rY = random.Next(4);
                while (clues[rX, rY].Text != String.Empty)
                {
                    rX = random.Next(5);
                    rY = random.Next(4);
                }

                if (cells[rX, rY].Value < cells[rX, (rY + 1)].Value)
                {
                    clues[rX, rY].Text = "^";
                }
                else
                {
                    clues[rX, rY].Text = "v";
                }

            }
        }
        public void clearAllClues(Clues[,] clues, Clues[,] cluesV)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    clues[i, j].Text = String.Empty;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cluesV[i, j].Text = String.Empty;
                }
            }
        }

    }
}
