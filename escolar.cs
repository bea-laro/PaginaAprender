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
    public partial class escolar : Form
    {
        public escolar()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pedestre tela = new pedestre();
            tela.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            proibido tela = new proibido();
            tela.Show();
            this.Hide();
        }
    }
}
