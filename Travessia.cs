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
    public partial class Travessia : Form
    {
        public Travessia()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Placas tela = new Placas();
            tela.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ajuda tela = new ajuda();
            tela.Show();
            this.Hide();
        }
    }
}
