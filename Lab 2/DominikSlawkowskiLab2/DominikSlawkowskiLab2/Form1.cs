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
        }

        private void AddHorse()
        {
             try
              {
                /* string name = textBoxHorseName.Text;
                  int numberOfLegs = Int32.Parse(textBoxNumberOfLegs.Text);
              } */
            var horse = new Horse
            {
                Name = textBoxHorseName.Text,
        //      NumberOfLegs = Int32.Parse(textBoxNumberOfLegs.Text);
            };
            listOfHorses.Add(horse);

               }
            catch
            {
                throw Exception("ehh");
            }

        private void buttonAddHorse_Click(object sender, EventArgs e)
        {
            AddHorse();
        }

    }
}
