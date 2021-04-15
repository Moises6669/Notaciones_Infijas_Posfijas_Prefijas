using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Notaciones_Infijas_Profijas_Prefijas
{
    public partial class Prefija_a_infija : Form
    {
        public Prefija_a_infija()
        {
            InitializeComponent();
        }
        public string prefija = "", infija = "", axu1 = "", axu2 = "", invertida = "";
        public char dato;
        int max;

        private void btn_prefija_a_Infija_Click(object sender, EventArgs e)
        {
            if (txtPrefija.Text != "")
            {
                Convert();
            }
            else
            {
                MessageBox.Show("Debe ingresar algun valor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        public void Convert()
        {
            prefija = txtPrefija.Text;
            max = prefija.Length;
            Pila pila = new Pila(max);

            for (int i = prefija.Length - 1; i >= 0; i--)
            {
                dato = prefija[i];

                if (dato != '^' && dato != '*' && dato != '/' && dato != '+' && dato != '-')
                {
                    pila.Agregar(dato.ToString());
                }
                else
                {
                    axu1 = pila.Eliminar();
                    axu2 = pila.Eliminar();
                    axu2 = "(" + axu2 + dato + axu1 + ")";
                    pila.Agregar(axu2);
                }
            }

            while (pila.PilaVacia() != true)
            {
                infija += pila.Eliminar();
            }

            for (int i = infija.Length - 1; i >= 0; i--)
            {
                if (infija[i] == '(')
                {
                    invertida += ')';
                }
                else if (infija[i] == ')')
                {
                    invertida += '(';
                }
                else
                {
                    invertida += infija[i];
                }
            }
            dgv1.Rows.Add(prefija, infija, invertida);
            txtPrefija.Clear();
            invertida = ""; infija = "";
        }
    }
}
