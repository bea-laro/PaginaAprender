using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaginaAprender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Travessia tela = new Travessia();
            tela.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelA.Visible = false;
            panel3.Visible = false;

            panel1.Visible = true;
            panelV.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelA.Visible = true;
            panel3.Visible = false;
            panelV.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void panelA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelV.Visible = true;
            panel3.Visible = false;
            panelA.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panelV.Visible = true;
            panel3.Visible = false;
            panelA.Visible = false;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            panelA.Visible = true;
            panel3.Visible = false;
            panelV.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panelA.Visible = false;
            panelV.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panelA.Visible = false;
            panelV.Visible = false;
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Placas tela = new Placas();
            tela.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TelaInicial.TelaInicial tela = new TelaInicial.TelaInicial();
            tela.Show();
            this.Hide();
        }
    }
}
