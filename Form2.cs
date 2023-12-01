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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int NumMesa = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            MesaLabel.Text = "Mesa " + NumMesa.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.Enabled = false;
                ModificarButton.Visible = false;
                EliminarButton.Visible = false;
                AgregarButton.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Enabled = true;
                ModificarButton.Visible = true;
                EliminarButton.Visible = true;
                AgregarButton.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
