using PEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProyectoRestaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime FechaActual = DateTime.Now;
            CargarComidas();

        }

        private void CargarComidas() 
        {

        }


        private void btnReservar_Click(object sender, EventArgs e)
        {
            string mesaseleccionada = comboBox1.Text;
            if (comboBox1.Text == null)
            {
                throw new Exception("Favor de seleccionar una mesa");
            }
            if (dateTimePicker1.Value < DateTime.Now)
            {
                throw new Exception("Favor de seleccionar una fecha mayor a la actual");
            }


            if (mesaseleccionada != null)
            {
                
                switch (mesaseleccionada)
                {
                    case "Mesa1":
                        Mesa1.BackColor = Color.LightCoral;
                        break;
                    case "Mesa2":
                        Mesa2.BackColor = Color.LightCoral;
                        break;
                    case "Mesa3":
                        Mesa3.BackColor = Color.LightCoral;
                        break;
                    case "Mesa4":
                        Mesa4.BackColor = Color.LightCoral;
                        break;
                    case "Mesa5":
                        Mesa5.BackColor = Color.LightCoral;
                        break;
                    case "Mesa6":
                        Mesa6.BackColor = Color.LightCoral;
                        break;
                    case "Mesa7":
                        Mesa7.BackColor = Color.LightCoral;
                        break;
                    case "Mesa8":
                        Mesa8.BackColor = Color.LightCoral;
                        break;
                    case "Mesa9":
                        Mesa9.BackColor = Color.LightCoral;
                        break;
                    case "Mesa10":
                        Mesa10.BackColor = Color.LightCoral;
                        break;
                    default:
                        // Manejar otros casos si es necesario
                        break;
                }
            }
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            string mesaaliberar = comboBox2.Text;
            if (comboBox2.Text == null)
            {
                throw new Exception("Favor de seleccionar una mesa");
            }
            if (mesaaliberar != null)
            {

                switch (mesaaliberar)
                {
                    case "Mesa1":
                        Mesa1.BackColor = Color.LightGreen;
                        break;
                    case "Mesa2":
                        Mesa2.BackColor = Color.LightGreen;
                        break;
                    case "Mesa3":
                        Mesa3.BackColor = Color.LightGreen;
                        break;
                    case "Mesa4":
                        Mesa4.BackColor = Color.LightGreen;
                        break;
                    case "Mesa5":
                        Mesa5.BackColor = Color.LightGreen;
                        break;
                    case "Mesa6":
                        Mesa6.BackColor = Color.LightGreen;
                        break;
                    case "Mesa7":
                        Mesa7.BackColor = Color.LightGreen;
                        break;
                    case "Mesa8":
                        Mesa8.BackColor = Color.LightGreen;
                        break;
                    case "Mesa9":
                        Mesa9.BackColor = Color.LightGreen;
                        break;
                    case "Mesa10":
                        Mesa10.BackColor = Color.LightGreen;
                        break;
                    default:
                        
                        break;
                }
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            MessageBox.Show(comboBox3.Text);
            if (comboBox3.Text != null)
            {

                switch (comboBox3.Text)
                {
                    case "Mesa1":
                        dataGridView1.BringToFront();

                        break;
                    case "Mesa2":
                        dataGridView2.BringToFront();

                        break;
                    case "Mesa3":
                        dataGridView3.BringToFront();

                        break;
                    case "Mesa4":
                        dataGridView4.BringToFront();

                        break;
                    case "Mesa5":
                        dataGridView5.BringToFront();

                        break;
                    case "Mesa6":
                        dataGridView6.BringToFront();

                        break;
                    case "Mesa7":
                        dataGridView7.BringToFront();

                        break;
                    case "Mesa8":
                        dataGridView8.BringToFront();

                        break;
                    case "Mesa9":
                        dataGridView9.BringToFront();

                        break;
                    case "Mesa10":
                        dataGridView10.BringToFront();

                        break;
                    default:
                        // Manejar otros casos si es necesario
                        break;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            string nombreBotonSeleccionado = comboBox3.Text as string;
            
            if (nombreBotonSeleccionado != null)
            {
                System.Windows.Forms.Button botonSeleccionado = Controls.Find(nombreBotonSeleccionado, true)[0] as System.Windows.Forms.Button;

                if (botonSeleccionado != null)
                {

                    if (botonSeleccionado.BackColor == Color.LightCoral)
                    {
                       MessageBox.Show("No se puede cargar el pedido, ya que la mesa está reservada");
                       return;
                    }
                    else
                    {
                        
                    }

                    
                }
            }



        }
    }
}

