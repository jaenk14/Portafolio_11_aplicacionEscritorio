using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LogicaNegocio;

namespace ProyectoEscritorio
{
    public partial class Frm_Notas : Form
    {
        
       
        public Frm_Notas()
        {
            InitializeComponent();
        }

        public void resetearCuadroPromedio() {
            txtResultado.BackColor = Color.DarkGray;
            txtResultado.Text = string.Empty;
        }

        public int SumarNotas()
        {
                int sum = 0;
                foreach (int num in lstNotas.Items)
                {
                    sum += num;
                }
                return sum;          
        }

        public void MuyGrande(TextBox num)
        {
            if (num.Text.Length <= 4)
            {
                double n = 0;
                double.TryParse(num.Text, out n);
                
                if (n > 100)
                {
                    MessageBox.Show("La nota no puede ser mayor a 100", "Nota fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    num.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("La nota solo puede tener 3 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                num.Text = string.Empty;
            }
            
        }
        private void txtDigitarLaNota_KeyUp(object sender, KeyEventArgs e)
        {
            MuyGrande(txtDigitarLaNota);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtDigitarLaNota.Text))
            {
                   double num;

                   double.TryParse(txtDigitarLaNota.Text, out num);

                   lstNotas.Items.Add(Convert.ToInt32(num));

                    txtDigitarLaNota.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Ingrese una Nota", "Digite una Nota!!", MessageBoxButtons.OK);
            }
        }

        private void lstNotas_MouseClick(object sender, MouseEventArgs e)
        {
            txtNotaSeleccionada.Text = lstNotas.Text;
        }

        private void btnEliminarrSeleccionado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNotaSeleccionada.Text))
            {
                int num = Convert.ToInt32(txtNotaSeleccionada.Text);
                int indice = lstNotas.Items.IndexOf(num);
                lstNotas.Items.RemoveAt(indice);
            }
            else
            {
                MessageBox.Show("Elige Una Nota", "Intentelo nuevamente", MessageBoxButtons.OK);
            }
        }

        private void btnEliminarLista_Click(object sender, EventArgs e)
        {
            lstNotas.Items.Clear();
            txtNotaSeleccionada.Text = string.Empty;
            txtDigitarLaNota.Text = "";
            resetearCuadroPromedio();
        }

        private void btnVerResultado_Click(object sender, EventArgs e)
        {
            int cantidad = lstNotas.Items.Count;

            if (cantidad > 0)
            {
                int suma = SumarNotas();

                

                ClsPromedio variable = new ClsPromedio();

                double promedio = variable.CalcularPromedio(suma,cantidad);

               

                string color = variable.CondicionPromedio(promedio);

                if ( color == "green")
                {
                    txtResultado.BackColor = Color.Green;
                    txtResultado.Text = Convert.ToString(promedio) + " APROBADO" ;
                }
                else
                {
                    txtResultado.BackColor = Color.Red;
                    txtResultado.Text = Convert.ToString(promedio) + " REPROBADO";

                }


            }
            else
            {
                MessageBox.Show("Ingrese Notas!!", "Intentelo nuevamente", MessageBoxButtons.OK);
            }
        }
    }
}
