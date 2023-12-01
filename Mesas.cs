using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CantidadMesas = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarMesas(6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mesas = 0;
            if (CantidadMesasText.Text!= "")
            {
                mesas = Convert.ToInt32(CantidadMesasText.Text);
            }
            if (mesas > 0)
            {
                actualizarMesas(mesas);
            }
        }
        private void actualizarMesas(int NewCantidad)
        {
            if (NewCantidad > CantidadMesas)
            {
                for (int i = CantidadMesas+1; i <= NewCantidad; i++)
                {
                    Button Mesa = new Button();
                    Mesa.Text = "Mesa " + i.ToString();
                    Mesa.Name = "Mesa" + i.ToString();
                    Mesa.Parent = flowLayoutPanel1;
                    Mesa.Size = new System.Drawing.Size(143, 50);
                    Mesa.Tag = i;
                    Mesa.Click += MesaClick;
                }
                CantidadMesas = NewCantidad;
            }
            if(NewCantidad < CantidadMesas)
            {
                for (int i = flowLayoutPanel1.Controls.Count - 1; i >= 0; i--)
                {
                    flowLayoutPanel1.Controls[i].Dispose();
                }
                for (int i = 1; i <= NewCantidad; i++)
                {
                    Button Mesa = new Button();
                    Mesa.Text = "Mesa " + i.ToString();
                    Mesa.Name = "Mesa" + i.ToString();
                    Mesa.Parent = flowLayoutPanel1;
                    Mesa.Size = new System.Drawing.Size(143, 50);
                    Mesa.Tag = i;
                    Mesa.Click += MesaClick;
                }
                CantidadMesas = NewCantidad;
            }
        }
        private void MesaClick(object sender,EventArgs e) 
            {
                Button clickedButton = sender as Button;
                if (clickedButton != null)
                {
                    Form2 form = new Form2();
                    form.NumMesa = Convert.ToInt32(clickedButton.Tag);
                    form.Show();
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Focus();
        }

        private void panel1_Leave(object sender, EventArgs e)
        {
            panel1.Visible=false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
