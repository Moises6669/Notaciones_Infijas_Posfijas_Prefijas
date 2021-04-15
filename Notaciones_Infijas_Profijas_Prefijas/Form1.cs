using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notaciones_Infijas_Profijas_Prefijas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void posfija_infija_Click(object sender, EventArgs e)
        {
            Infija_a_Posfija infix = new Infija_a_Posfija();
            infix.ShowDialog();
        }

        private void Infija_a_Prefija_Click(object sender, EventArgs e)
        {
            Infija_a_Prefija pos = new Infija_a_Prefija();
            pos.ShowDialog();
        }

        private void Posfija_a_Infija_Click(object sender, EventArgs e)
        {
            Posfija_a_Infija prein = new Posfija_a_Infija();
            prein.ShowDialog();
        }

        private void Prefija_a_Infija_Click(object sender, EventArgs e)
        {
            Prefija_a_infija preinfija = new Prefija_a_infija();
            preinfija.ShowDialog();
        }
    }
}
