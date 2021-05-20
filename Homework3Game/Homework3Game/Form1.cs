using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework3Game.Concrete;

namespace Homework3Game
{
    public partial class Form1 : Form
    {

        #region Class ve List Tanımlamaları
        //Ikı boyutlu Cell nesnelerini tutan dizimizi oluşturduk.
        //Oyun ekranında ki cellerimizi bunun içinde tutacağız.
        Cell[,] cells = new Cell[5, 5];
        Clues[,] clues = new Clues[4, 5]; //5x5 lik alanın orta boşluklarına gelecek şekilde listemizi oluşturduk.(Horizontal için)
        Clues[,] cluesV = new Clues[5, 4]; //Vertical için
        Random random = new Random();
        Cell cell = new Cell();
        Clues clue = new Clues();
        CluesManager cluesManager = new CluesManager();
        CellManager cellManager = new CellManager();
        private int countofHints = 5;


        #endregion
        public Form1()
        {
            InitializeComponent();
            
            clue.createClueLabelsHorizontal(clues, gbxGameArea);
            clue.createClueLabelsVertical(cluesV, gbxGameArea);
            cell.createCells(cells, gbxGameArea);
            startNewGame();
        }
        
        private void startNewGame()
        {
            
            loadValues();
            cluesManager.showRandomValuesHints(random, cells, 5);
            cluesManager.showRandomClueLabelsHorizontal(random, cells, clues, 5);
            cluesManager.showRandomClueLabelsVertical(random, cells, cluesV, 4);
        }
        private void loadValues()
        {
            //cells dizimizdeki tüm nesneleri gezip değerlerini temizliyoruz.
            foreach (var cell in cells)
            {
                cell.Value = 0;
                cell.Clear();
            }

            fillNumber(0, -1);
            
        }

        private bool fillNumber(int i, int j)
        {
            var value = 0;
            var numberList = new List<int> { 1, 2, 3, 4, 5 };
            if (++j > 4)
            {
                //Değerlerimizi oluştururken satır sonuna gelip gelmediğini kontrol ediyoruz

                j = 0;
                if (++i > 4)
                    return true;
            }

            do
            {
                //eğer geriye kalan sayımız kalmadıysa burda işlemi kırıyoruz.
                if (numberList.Count < 1)
                {
                    cells[i, j].Value = 0;
                    return false;
                }

                //0'dan elimizde kalan sayıların sayısına kadar random bir sayı üretiyoruz.
                value = numberList[random.Next(0, numberList.Count)];
                //ve bunu gerekli nesnemizin değeri olarak atıyoruz.
                cells[i, j].Value = value;

                //o sayıyı da kalan sayılar arasından çıkartıyoruz.
                numberList.Remove(value);
            }
            while (!controlNumbers(value, i, j) || !fillNumber(i, j));

            //sadece test için yazıldı oyun sırasında kaldırılacak.
            //cells[i, j].Text = value.ToString();
            return true;

        }

        private bool controlNumbers(int value, int x, int y)
        {
            for (int i = 0; i < 5; i++)
            {
                //Oluşturduğumuz değer aynı satırda var mı diye kontrol ediyoruz. (kendisi hariç)
                if (i != y && cells[x, i].Value == value)
                    return false;

                //Oluşturduğumuz değer aynı sütunda var mı diye kontrol ediyoruz. (kendisi hariç)
                if (i != x && cells[i, y].Value == value)
                    return false;
            }

            //eğer aynı satır ve sütunda yoksa true dönüyoruz.
            return true;

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCountsOfHints.Text = countofHints.ToString();
        }
        
        #region ButtonClickIslemleri
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lblTimer.Text = "90";
            cluesManager.clearAllClues(clues, cluesV);
            cellManager.clearBackColorCells(cells);
            startNewGame();
            countofHints = 5;
            lblCountsOfHints.Text = countofHints.ToString();
        }
        private void btnCheckInputs_Click(object sender, EventArgs e)
        {
            //yeni list of celller oluşturuyoruz. Burada yanlış ve dogru işaretlenmiş nesneleri tutacağız.
            var wrongCells = new List<Cell>();
            var correctCells = new List<Cell>();


            foreach (var cell in cells)
            {
                if (cell.Text != String.Empty)
                {
                    //nesnemizin değeri ile girilen textin eşitliği kontrol edilir.
                    if (!string.Equals(cell.Value.ToString(), cell.Text))
                    {
                        //eşit olmayan nesne yasnlıs listemize eklenir.
                        wrongCells.Add(cell);
                    }
                    else
                    {
                        //eşit olan nesne dogru listeye eklenir
                        correctCells.Add(cell);
                    }

                }

            }

            //doğru listeyi yesile 
            foreach (var cell in correctCells)
            {
                cell.BackColor = Color.Green;
            }

            //yanlıs listeyi kırmızı yapar
            foreach (var cell in wrongCells)
            {
                cell.BackColor = Color.Red;
            }

            //dogru listesi sayısı tüm alanları kapsıyorsa hepsi doğru demektir ve oyun biter
            if (correctCells.Count == 25)
            {
                MessageBox.Show("FINISH GAME ALL ANSWERS CORRECT!");
                Thread.Sleep(1200);
                Application.Exit();
            }



        }
        private void btnEndGame_Click(object sender, EventArgs e)
        {

            cellManager.showAllCells(cells);
            //Oyun alanımız sleepten etkilenmesin sleep öncesi yenilensin diye refresh yapıyoruz.
            gbxGameArea.Refresh();
            //3 sn bekleme ekliyoruz ve ardından oyunu sonlandırıyoruz.
            Thread.Sleep(3000);

            Application.Exit();
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }
        private void btnHints_Click(object sender, EventArgs e)
        {
            if (countofHints > 0)
            {
                countofHints--;
                lblCountsOfHints.Text = countofHints.ToString();
                cluesManager.showRandomValuesHints(random, cells, 1);
            }
            else
            {
                MessageBox.Show("You don't have more hints!");

            }

        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            int value = int.Parse(lblTimer.Text);
            value--;
            lblTimer.Text = value.ToString();
            if (value == 0)
            {
                cellManager.showAllCells(cells);
                gbxGameArea.Refresh();
                Thread.Sleep(3000);
                Application.Exit();
            }
        }
    }
}
