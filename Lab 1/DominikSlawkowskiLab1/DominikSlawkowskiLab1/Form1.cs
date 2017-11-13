using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominikSlawkowskiLab1
{
    public partial class FormHomework1 : Form
    {
        
            public FormHomework1()
        {
            InitializeComponent();

           //wywołanie na samym poczatku metody, w celu ustawienia wierszy i kolumn w tabeli, oraz przesłania danych do dataGridView
            SetColumnsAndRows();

            //wystartowanie poszczególnych timerów
            timerFoodIncrease.Start();
            timerGoldIncrease.Start();
            timerStoneIncrease.Start();
            timerWoodIncrease.Start();
        }

        //stworzenie nowego obiektu typu DataTable w celu wykorzystania go do zbudowania tabeli
        DataTable tableResources = new DataTable();

        //stworzenie nowego obiektu typu DataGridViewRow w celu wykorzystania go do dostania się i zmieniania wartości wierszach dataGridView
        DataGridViewRow newDataRow;

        //inicjalizowanie i nadawanie wartości zmiennym odpowiadającym za ilość aktualnie posiadanych surowcór
        int goldAmount = 200, woodAmount = 100, stoneAmount = 100, foodAmount = 100;

        //inicjalizowanie i nadawanie wartości zmiennym określających poziom rozbudowy kolejnych budynków
        int bakerLevel = 1, mintLevel = 1, sawmillLevel = 1, mineLevel = 1;

        //inicjalizowanie i nadawanie wartości zmiennym określających aktualny koszt ulepszenia budynków
        int bakerUpgradeCost = 30, mintUpgradeCost = 30, sawmillUpgradeCost = 30, mineUpgradeCost = 30;

        /// <summary>
        /// metoda odpowiadająca za początkowe ustawienie kolumn i wierszy tabeli, oraz przesłanie danych do dataGridView
        /// </summary>
        void SetColumnsAndRows()
        {
            tableResources.Columns.Add("Żywność", typeof(int));
            tableResources.Columns.Add("Złoto", typeof(int));
            tableResources.Columns.Add("Kamnień", typeof(int));
            tableResources.Columns.Add("Drewno", typeof(int));
           
            tableResources.Rows.Add(foodAmount, goldAmount, stoneAmount, woodAmount);
            
            //przesłanie danych do dataGridView
            dataGridViewResources.DataSource = tableResources;
        }
        
        /// <summary>
        /// metoda odpowiadająca za zwiekszanie aktualnej ilości złota oraz przesłanie tej wartości do dataGridView
        /// </summary>
        void GoldIncrease()
        {
            goldAmount += 10;
            newDataRow = dataGridViewResources.Rows[0];
            newDataRow.Cells[1].Value = goldAmount;
        }

        /// <summary>
        /// metoda odpowiadająca za zwiekszanie aktualnej ilości drewna oraz przesłanie tej wartości do dataGridView
        /// </summary>
        void WoodIncrease()
        {
            woodAmount += 10;
            newDataRow = dataGridViewResources.Rows[0];
            newDataRow.Cells[3].Value = woodAmount;
        }

        /// <summary>
        /// metoda odpowiadająca za zwiekszanie aktualnej ilości kamienia oraz przesłanie tej wartości do dataGridView
        /// </summary>
        void StoneIncrease()
        {
            stoneAmount += 10;
            newDataRow = dataGridViewResources.Rows[0];
            newDataRow.Cells[2].Value = stoneAmount;
        }

        /// <summary>
        /// metoda odpowiadająca za zwiekszanie aktualnej ilości żywności oraz przesłanie tej wartości do dataGridView
        /// </summary>
        void FoodIncrease()
        {
            foodAmount += 10;
            newDataRow = dataGridViewResources.Rows[0];
            newDataRow.Cells[0].Value = foodAmount;
        }

        /// <summary>
        /// metoda (wykonywana po kliknięciu w buttonFire) wyświetlająca wiadomość o wywołaniu pożaru, ustawiająca wartość surowców na 0 
        /// oraz wykonująca pętle for, w celu zaktualizowania danych w tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFire_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Twoje Królestwo niszczy wielki pożar, tracisz wszystkie surowce i złoto!");
            
            woodAmount = 0;
            stoneAmount = 0; 
            foodAmount = 0;
            goldAmount = 0;

            //pętla ustawiająca wartość wszystkich surowców i złota na 0 w wierszach dataGridView
            for (int i = 0; i <= 3; i++)
            {
                newDataRow = dataGridViewResources.Rows[0];
                newDataRow.Cells[i].Value = 0;
            }
        }

        /// <summary>
        /// metoda wywoływana przez timer, w celu zwiększenia wartości złota
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerGoldIncrease_Tick(object sender, EventArgs e)
        {
            GoldIncrease();
        }

        /// <summary>
        /// metoda wywoływana przez timer, w celu zwiększenia wartości kamienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerStoneIncrease_Tick(object sender, EventArgs e)
        {
            StoneIncrease();
        }

        /// <summary>
        /// metoda wywoływana przez timer, w celu zwiększenia wartości żywności
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFoodIncrease_Tick(object sender, EventArgs e)
        {
            FoodIncrease();
        }

        /// <summary>
        /// metoda wywoływana przez timer, w celu zwiększenia wartości drewna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerWoodIncrease_Tick(object sender, EventArgs e)
        {
            WoodIncrease();
        }

        /// <summary>
        /// metoda (wywoływana po kliknięciu w buttonBakerUpgrade) odpowiedzialna za ulepszenie piekarnii,
        /// oraz pokazywanie odpowiednich wiadomości gdy jest to niemożliwe do wykoniania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBakerUpgrade_Click(object sender, EventArgs e)
        {
            //sprawdzanie czy ulepszenie budynku jest możliwe, poziom budynku musi być mniejszy od 3 oraz potrzeba wymaganej ilości 
            if (bakerLevel < 3 && goldAmount >= bakerUpgradeCost)
            {
                //zmniejszenei interwały timera w celu zwiekszenia przyrostu surowca
                timerFoodIncrease.Interval -= 1000;
                //zwiększenie poziomu budynku
                bakerLevel++;
                //zmiana treści w labelu
                labelBakerLevel.Text = "poziom: " + bakerLevel.ToString();

                //zmniejszenie aktualnej ilości złota, która zostałą wykorzystana na ulepszenie budynku
                goldAmount -= bakerUpgradeCost;
                
                //zwiększenie kosztu kolejnego ulepszenia
                bakerUpgradeCost += 10;

                //zmiana treści w labelu
                labelBakerUpgradeCost.Text = "Koszt: " + bakerUpgradeCost.ToString() + " złota";

                //zaktualizowanie danych w wierszach dataGridView
                newDataRow = dataGridViewResources.Rows[0];
                newDataRow.Cells[1].Value = goldAmount;
            }
            //warunek gdy nie posiadamy wystarczającej ilości złota
            else if(goldAmount < bakerUpgradeCost)
            {
                //pokazanie na ekran wiadomości
                MessageBox.Show("Masz za mało złota, by kupić ulepszenie!");
            }
            //warunek gdy ulepszyliśmy budowle na maksymalny poziom
            if(bakerLevel == 3)
            {
                //schowanie labelów
                labelBakerLevel.Hide();
                labelBakerUpgradeCost.Hide();
                MessageBox.Show("Ulepszyłeś ten obiekt makymalnie!");
            }
        }

        //kod w kolejnych metodach poniżej rożni się jednynie nazwami zmiennych i obiektów

        /// <summary>
        /// metoda (wywoływana po kliknięciu w buttonMintUpgrade) odpowiedzialna za ulepszenie mennicy,
        /// oraz pokazywanie odpowiednich wiadomości gdy jest to niemożliwe do wykoniania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMintUpgrade_Click(object sender, EventArgs e)
        {
            if (mintLevel < 3 && goldAmount >= mintUpgradeCost)
            {
                timerGoldIncrease.Interval -= 3000;
                mintLevel++;
                labelMintLevel.Text = "poziom: " + mintLevel.ToString();

                goldAmount -= mintUpgradeCost;
                mintUpgradeCost += 10;
                labelMintUpgradeCost.Text = "Koszt: " + mintUpgradeCost.ToString() + " złota";

                newDataRow = dataGridViewResources.Rows[0];
                newDataRow.Cells[1].Value = goldAmount;
            }
            else if (goldAmount < mintUpgradeCost)
            {
                MessageBox.Show("Masz za mało złota, by kupić ulepszenie!");
            }
            if (mintLevel == 3)
            {
                labelMintLevel.Hide();
                labelMintUpgradeCost.Hide();
                MessageBox.Show("Ulepszyłeś ten obiekt makymalnie!");
            }
        }

        /// <summary>
        /// metoda (wywoływana po kliknięciu w buttonMineUpgrade) odpowiedzialna za ulepszenie kopalni,
        /// oraz pokazywanie odpowiednich wiadomości gdy jest to niemożliwe do wykoniania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMineUpgrade_Click(object sender, EventArgs e)
        {
            if (mineLevel < 3 && goldAmount >= mineUpgradeCost)
            {
                timerStoneIncrease.Interval -= 500;
                mineLevel++;
                labelMineLevel.Text = "poziom: " + mineLevel.ToString();

                goldAmount -= mineUpgradeCost;
                mineUpgradeCost += 10;
                labelMineUpgradeCost.Text = "Koszt: " + mineUpgradeCost.ToString() + " złota";

                newDataRow = dataGridViewResources.Rows[0];
                newDataRow.Cells[1].Value = goldAmount;
            }
            else if (goldAmount < mineUpgradeCost)
            {
                MessageBox.Show("Masz za mało złota, by kupić ulepszenie!");
            }
            if (mineLevel == 3)
            {
                labelMineLevel.Hide();
                labelMineUpgradeCost.Hide();
                MessageBox.Show("Ulepszyłeś ten obiekt makymalnie!");
            }
        }

        /// <summary>
        /// metoda (wywoływana po kliknięciu w buttonSawmillUpgrade) odpowiedzialna za ulepszenie tartaku,
        /// oraz pokazywanie odpowiednich wiadomości gdy jest to niemożliwe do wykoniania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSawmillUpgrade_Click(object sender, EventArgs e)
        {
            if (sawmillLevel < 3 && goldAmount >= sawmillUpgradeCost)
            {
                timerWoodIncrease.Interval -= 500;
                sawmillLevel++;
                labelSawmillLevel.Text = "poziom: " + sawmillLevel.ToString();

                goldAmount -= sawmillUpgradeCost;
                sawmillUpgradeCost += 10;
                labelSawmillUpgradeCost.Text = "Koszt: " + sawmillUpgradeCost.ToString() + " złota";

                newDataRow = dataGridViewResources.Rows[0];
                newDataRow.Cells[1].Value = goldAmount;
            }
            else if (goldAmount < sawmillUpgradeCost)
            {
                MessageBox.Show("Masz za mało złota, by kupić ulepszenie!");
            }
            if (sawmillLevel == 3)
            {
                labelSawmillLevel.Hide();
                labelSawmillUpgradeCost.Hide();
                MessageBox.Show("Ulepszyłeś ten obiekt makymalnie!");
            }
        }


    }
}
