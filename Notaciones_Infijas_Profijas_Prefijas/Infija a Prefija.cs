using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Notaciones_Infijas_Profijas_Prefijas
{
    public partial class Infija_a_Prefija : Form
    {
        public Infija_a_Prefija()
        {
            InitializeComponent();
        }

        string notacionInfija, notacionPrefija = "";
        string invertida = "";
        char dato;

        public void Convert()
        {
            notacionInfija = txtInfija.Text;

            Pila pila = new Pila(notacionInfija.Length);

            for (int i = notacionInfija.Length - 1; i >= 0; i--)
            {
                dato = notacionInfija[i];

                if (dato.Equals(')'))
                {
                    pila.Agregar(dato.ToString());
                }
                else if (dato.Equals('('))
                {
                    while (pila.pila[pila.tope] != ")")
                    {
                        notacionPrefija += pila.Eliminar();
                    }
                    pila.Eliminar();
                }
                else
                {
                    if (dato >= '0' && dato <= '9')
                    {
                        notacionPrefija += dato;
                    }
                    else
                    {
                        while (pila.PilaVacia() == false && Prioridad(dato.ToString()) < Prioridad((pila.pila[pila.tope])))
                        {
                            notacionPrefija += pila.Eliminar();
                        }

                        pila.Agregar(dato.ToString());

                    }
                }
            }
            while (pila.PilaVacia() == false)
            {
                notacionPrefija += pila.Eliminar();
            }


            for (int i = notacionPrefija.Length - 1; i >= 0; i--)
            {
                invertida += notacionPrefija[i];
            }

            dgv1.Rows.Add(notacionInfija, notacionPrefija, invertida);
            txtInfija.Clear();
            notacionPrefija = "";
            notacionInfija = "";

        }

        private void btn_infija_a_prefija_Click(object sender, EventArgs e)
        {
            if (txtInfija.Text != "")
            {
                Convert();
            }
            else
            {
                MessageBox.Show("Debes ingresar almenos un valor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static int Prioridad(string dato)
        {
            int priori = 0;

            switch (dato)
            {
                case "^":
                    priori = 4;
                    break;

                case "*":
                case "/":
                    priori = 3;
                    break;


                case "+":
                case "-":
                    priori = 2;
                    break;


                case "=":
                    priori = 1;
                    break;

                default:
                    priori = 0;
                    break;
            }
            return priori;
        }

    }
}
