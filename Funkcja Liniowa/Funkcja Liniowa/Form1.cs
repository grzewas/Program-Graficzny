using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Funkcja_Liniowa
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen Pioro1 = new Pen(Color.Black);
        Pen Pioro2 = new Pen(Color.Red);
        
        public Form1()
        {
            InitializeComponent();
        }

        int xmin = 12;
        int xmax = 1000;
        int xmid = 500;
        int ymin = 40;
        int ymax = 650;
        int ymid = 345;
        int a = 0;
        int b = 0;
        int x1, x2 ,y1, y2;

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program rysuje wykres funkcji liniowej, której wzór został wyznaczony przez użytkownika poprzez wypełnienie liczbami odpowiednich pól.");
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Grzegorz Wąs");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                g = this.CreateGraphics();
                g.Clear(this.BackColor);
                g.DrawLine(Pioro1, xmin, ymid, xmax, ymid);
                g.DrawLine(Pioro1, xmid, ymin, xmid, ymax);
                g.DrawLine(Pioro1, 200, 335, 200, 355);
                g.DrawLine(Pioro1, 470, 335, 470, 355);
                g.DrawLine(Pioro1, 800, 335, 800, 355);
                g.DrawLine(Pioro1, 530, 335, 530, 355);
                g.DrawLine(Pioro1, 490, 45, 510, 45);
                g.DrawLine(Pioro1, 490, 315, 510, 315);
                g.DrawLine(Pioro1, 490, 375, 510, 375);
                g.DrawLine(Pioro1, 490, 645, 510, 645);
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                g.DrawLine(Pioro2, 14, 345 + 486 * a - 6 * b, 998, 345 - 498 * a - 6 * b);
                label4.Text = "-50";
                label5.Text = "-5";
                label6.Text = "5";
                label7.Text = "50";
                label8.Text = "50";
                label9.Text = "5";
                label10.Text = "-5";
                label11.Text = "-50";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            }


    }
}
