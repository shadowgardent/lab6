using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            pikachu pikachu = new pikachu();
            labelname.Text = pikachu.Name();
            pictureBox1.Image = Properties.Resources.pikachus;
    }

        private void buttonload2_Click(object sender, EventArgs e)
        {
            bulbasaur bulbasaur = new bulbasaur();  
            labelname.Text=bulbasaur.Name();    
            pictureBox1.Image= Properties.Resources.bulbasaur;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonload3_Click(object sender, EventArgs e)
        {
             Raichu Raichu = new Raichu();
            labelname.Text = Raichu.Name();
            pictureBox1.Image = Properties.Resources.Raichu;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ekans ekans = new Ekans();
            labelname.Text = ekans.Name();
            pictureBox1.Image = Properties.Resources.Ekans;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            arbok arbok = new arbok();
            labelname.Text = arbok.Name();
             pictureBox1 .Image = Properties.Resources.arbok;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Exeggcute exeggcute = new Exeggcute();
            labelname .Text = exeggcute.Name();
            pictureBox1.Image = Properties.Resources.Exeggcute;
        }
    }
}

