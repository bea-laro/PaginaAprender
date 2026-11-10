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
    public partial class pedestre : Form
    {
        public pedestre()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Placas tela = new Placas();
            tela.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            escolar tela = new escolar();
            tela.Show();
            this.Hide();
        }
    }
}
