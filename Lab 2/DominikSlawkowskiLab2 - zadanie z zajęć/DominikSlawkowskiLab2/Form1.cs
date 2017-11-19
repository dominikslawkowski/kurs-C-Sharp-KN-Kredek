using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominikSlawkowskiLab2
{
    public partial class Form1 : Form
    {
        private List<Horse> listOfHorses;
        private List<Unicorn> listOfUnicorn;
        public Form1()
        {
            InitializeComponent();
            listOfHorses = new List<Horse>();
            listOfUnicorn = new List<Unicorn>();
            dataGridViewHorse.DataSource = listOfUnicorn;
        }

        private void AddHorse()
        {
            try
            {
                var horse = new Horse
                {
                    Name = textBoxHorseName.Text,
                    NumberOfLegs = Int32.Parse(textBoxNumberOfLegs.Text),
                    ColorOfCorner = textBoxColorOfCorner.Text
                };
                listOfHorses.Add(horse);

            }
            catch(Exception e)
            {
                throw new Exception("ehh", e);
            }
        }

        void ShowHorse()
        {
            for(int i=0; i<listOfHorses.Count; i++)
            {
                textBoxHorses.Text += listOfHorses[i].Name + "_" + listOfHorses[i].NumberOfLegs + "_" + listOfHorses[i].ColorOfCorner + " ";
            }

        }

        void AddUnicorn()
        {
            try
            {
                var unicorn = new Unicorn
                {
                    Name = textBoxUnicornName.Text,
                    NumberOfLegs = Int32.Parse(textBoxNumberOfUnicornLegs.Text),
                    ColorOfCorner = textBoxColor.Text
                };
                listOfUnicorn.Add(unicorn);

            }
            catch (Exception e)
            {
                throw new Exception("ehh", e);
            }
        }

        void Mean()
        {
            int mean = 0;
            int counter = 0;
            foreach(Unicorn unicorn in listOfUnicorn)
            {
                unicorn.NumberOfLegs += mean;
                counter++;
            }
            if(counter!=0)
            {
                labelMean.Text = (mean / counter).ToString();
            }
        }
        
        private void buttonAddUnicorn_Click(object sender, EventArgs e)
        {
            AddUnicorn();
            dataGridViewHorse.DataSource = null;
            dataGridViewHorse.DataSource = listOfUnicorn;
        }

        private void buttonShowMean_Click(object sender, EventArgs e)
        {
            Mean();
        }
    }

    }

