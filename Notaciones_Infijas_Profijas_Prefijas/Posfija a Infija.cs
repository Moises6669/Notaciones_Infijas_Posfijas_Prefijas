using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Notaciones_Infijas_Profijas_Prefijas
{
    public partial class Posfija_a_Infija : Form
    {
        public Posfija_a_Infija()
        {
            InitializeComponent();
        }
        string notacionInfija = "", notacionPosfija;
        string axu1, axu2;
        char dato;

        private void btn_posfija_a_Infija_Click(object sender, EventArgs e)
        {
            if (txtPosfija.Text != "")
            {
                Convert();
            }
            else
            {
                MessageBox.Show("Debes Ingresar valores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
         public void Convert()
        {
            notacionPosfija = txtPosfija.Text;
            Pila pila = new Pila(notacionPosfija.Length);

            while (notacionPosfija != "")
            {
                dato = notacionPosfija[0];
                notacionPosfija = notacionPosfija.Substring(1);

                if (dato >= '0' && dato <= '9')
                {
                    pila.Agregar(dato.ToString());
                }
                else
                {

                    axu1 = pila.Eliminar();
                    axu2 = pila.Eliminar();
                    axu1 = "(" + axu2 + dato + axu1 + ")";
                    pila.Agregar(axu1);

                }
            }

            while (pila.PilaVacia() != true)
            {
                notacionInfija += pila.Eliminar();
            }

            dgv1.Rows.Add(txtPosfija.Text, notacionInfija);
            txtPosfija.Clear();
            notacionPosfija = "";
            notacionInfija = "";
        }
    }
}
