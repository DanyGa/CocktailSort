using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cocktail_sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] vector = new int[30];
        int n;
        int i;
        Stopwatch contador = new Stopwatch();

        public void GenerarDatos(int n)
        {
            Random aleatorio = new Random();
            for (i = 0; i < n; i++)
            {
                vector[i] = aleatorio.Next(1, 31);

            }
        }

        public void BurbujaBidireccional (int n)
        {
            int recorrido;
            int aux = 0;
            n = vector.Length;
            //ordena los numeros de mayor a menor
            for (recorrido = 0; recorrido < n ; recorrido++)
            //si en el paso anterior no hubo cambios se detiene el ciclo
            {
                for (int j = 0; j < n - recorrido - 1; j++)
                //las comparaciones van disminuyendo a medida que se afectan los pasos
                {
                    if (vector[j] < vector[j + 1])
                    {                       
                        aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;
                    }
                }

            }
        }

        public void mostrar(int n, ListBox l)
        {
            for(i = 0; i < n; i++)
            {
                l.Items.Add(vector[i]);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                lbNum.Items.Clear();
                lbOrdenar.Items.Clear();
                n = int.Parse(txtNum.Text);
                contador.Restart();
                GenerarDatos(n);
                contador.Stop();
                lblTiempoGenerar.Text = contador.Elapsed.TotalMilliseconds.ToString() + " Milisegundos";
                mostrar(n, lbNum);
                btnOrdenar.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Introduzca un numero valido");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            contador.Restart();
            BurbujaBidireccional(n);
            contador.Stop();
            lblTiempoOrdenar.Text = contador.Elapsed.TotalMilliseconds.ToString() + " Milisegundos";
            mostrar(n, lbOrdenar);
            btnOrdenar.Enabled = false;

        }
    }
}
