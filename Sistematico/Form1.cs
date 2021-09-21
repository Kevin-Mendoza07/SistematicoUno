using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistematico
{
    public partial class Form1 : Form
    {
        int count = 0;
        Estudiante estudiante = new Estudiante();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNotas_KeyDown(object sender, KeyEventArgs e)
        {
            int nots;

            if (e.KeyCode == Keys.Enter)
            {
                if (count < 6)
                {
                    try
                    {
                        estudiante.Add(txtNotas.Text, count);
                        count++;
                    }
                    catch (ArgumentOutOfRangeException)
                    {

                        MessageBox.Show($@"La nota ingresada esta fuera del rango",
                            "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show($@"No se puede convertir el valor ingresado", "Mensaje de Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (count < 6)
                    {
                        txtNotas.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show($@"No puede ingresar mas de 6 notas", "Mensaje de Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
                estudiante.Carnet = txtCarnet.Text;
                estudiante.Nombre = txtNombre.Text;
                estudiante.Apellidos = txtApellido.Text;
                count = 0;


       
                MessageBox.Show($@"Datos del estudiante: 
                             Carnet: {estudiante.Carnet}
                             Nombre:{estudiante.Nombre}
                             Apellido:{estudiante.Apellidos}
                             Promedio:{estudiante.GetPromedio()}");
            
           
        }
      
            }
        }
    
