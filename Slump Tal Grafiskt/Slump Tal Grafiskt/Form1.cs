using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slump_Tal_Grafiskt
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            tal = rnd.Next(1, 101);
        }

        int tal;
        int gissning;
        int antal = 1;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = ("Gissa ett nytt tal mellan 1-100");
            int gissning = int.Parse(numericUpDown1.Text);

            if (gissning < tal)
                label1.Text = ("Gissa högre!");
            else if (gissning > tal)
                label1.Text = ("Gissa lägre!");
            else
                label1.Text = ("Du gissade rätt! Svaret var: " + tal + " och det tog dig: " + antal + " gissningar");

            antal++;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
