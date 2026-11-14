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
    public partial class ajuda : Form
    {
        public ajuda()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Placas tela = new Placas();
            tela.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Travessia tela = new Travessia();
            tela.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
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
