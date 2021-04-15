using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Notaciones_Infijas_Profijas_Prefijas
{
    class Pila
    {
        public int tope, maximo;
        public string[] pila;


        public Pila(int max)
        {
            tope = -1;
            maximo = max;
            pila = new string[maximo];
        }

        public bool PilaLlena()
        {
            if (tope == maximo - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PilaVacia()
        {
            if (tope == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Agregar(string dato)
        {
            if (PilaLlena() == false)
            {
                tope++;
                pila[tope] = dato;
            }
            else
            {
                MessageBox.Show("la pila  se encuentra llena");
            }
        }



        public string Eliminar()
        {
            string dato = "";

            if (PilaVacia() == false)
            {
                dato = pila[tope];
                tope--;
            }
            else
            {
                MessageBox.Show("la pila se encuentra vacia");
            }

            return dato;
        }

    }
}

