﻿using System;
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

        int[] vector;
        int n;
        int min;
        int max;
        int i;
        Stopwatch contador = new Stopwatch();

        public void GenerarDatos(int n, int min, int max)
        {
            vector = new int[n];
            Random aleatorio = new Random();
            for (i = 0; i < vector.Length; i++)
            {
                vector[i] = aleatorio.Next(min, max);

            }
        }

        public void BurbujaBidireccional (int n)
        {

            int der = vector.Length - 1;
            int izq = 0;
            int ultimo = 0;
            int aux;
            int comparaciones = 0;
            int intercambio = 0;
            do
            {
                //recorrido a la derecha
                for (int i = izq; i < der; i++)
                {
                    comparaciones++;
                    if (vector[i] > vector[i+1])
                    {
                        aux = vector[i];
                        vector[i] = vector[i + 1];
                        vector[i + 1] = aux;
                        ultimo = i;
                        intercambio++;
                    }
                }
                der = ultimo;

                //recorrido a la izq
                for (int j = der; j > izq; j--)
                {
                    comparaciones++;
                    if (vector[j-1] > vector[j])
                    {
                        aux = vector[j];
                        vector[j] = vector[j - 1];
                        vector[j - 1] = aux;
                        ultimo = j;
                        intercambio++;
                    }
                    
                }
                izq = ultimo;

                lblComparaciones.Text = comparaciones.ToString();
                lblIntercambios.Text = intercambio.ToString();
                return;

            } while (izq < der);          
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
                min = int.Parse(txtMin.Text);
                max = int.Parse(txtMax.Text);
                GenerarDatos(n, min, max);
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
