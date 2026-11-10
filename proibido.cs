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
    public partial class proibido : Form
    {
        public proibido()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            escolar tela = new escolar();
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
