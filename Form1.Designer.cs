namespace UI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CantidadMesasButton = new System.Windows.Forms.Button();
            this.CantidadMesasTextbox = new System.Windows.Forms.TextBox();
            this.MesasCantidadLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MesasAbiertas = new System.Windows.Forms.Label();
            this.MesasDisponibles = new System.Windows.Forms.Label();
            this.CubiertosButton = new System.Windows.Forms.Button();
            this.CubiertosTextbox = new System.Windows.Forms.TextBox();
            this.CubiertosLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(450, 400);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // CantidadMesasButton
            // 
            this.CantidadMesasButton.Location = new System.Drawing.Point(161, 88);
            this.CantidadMesasButton.Name = "CantidadMesasButton";
            this.CantidadMesasButton.Size = new System.Drawing.Size(100, 31);
            this.CantidadMesasButton.TabIndex = 0;
            this.CantidadMesasButton.Text = "Actualizar Mesas";
            this.CantidadMesasButton.UseVisualStyleBackColor = true;
            this.CantidadMesasButton.Click += new System.EventHandler(this.CantidadMesas_Click);
            // 
            // CantidadMesasTextbox
            // 
            this.CantidadMesasTextbox.Location = new System.Drawing.Point(161, 55);
            this.CantidadMesasTextbox.Name = "CantidadMesasTextbox";
            this.CantidadMesasTextbox.Size = new System.Drawing.Size(100, 20);
            this.CantidadMesasTextbox.TabIndex = 2;
            // 
            // MesasCantidadLabel
            // 
            this.MesasCantidadLabel.AutoSize = true;
            this.MesasCantidadLabel.Location = new System.Drawing.Point(158, 29);
            this.MesasCantidadLabel.Name = "MesasCantidadLabel";
            this.MesasCantidadLabel.Size = new System.Drawing.Size(84, 13);
            this.MesasCantidadLabel.TabIndex = 3;
            this.MesasCantidadLabel.Text = "Nueva Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mesas Abiertas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mesas Disponibles";
            // 
            // MesasAbiertas
            // 
            this.MesasAbiertas.AutoSize = true;
            this.MesasAbiertas.Location = new System.Drawing.Point(519, 113);
            this.MesasAbiertas.Name = "MesasAbiertas";
            this.MesasAbiertas.Size = new System.Drawing.Size(13, 13);
            this.MesasAbiertas.TabIndex = 6;
            this.MesasAbiertas.Text = "0";
            // 
            // MesasDisponibles
            // 
            this.MesasDisponibles.AutoSize = true;
            this.MesasDisponibles.Location = new System.Drawing.Point(519, 208);
            this.MesasDisponibles.Name = "MesasDisponibles";
            this.MesasDisponibles.Size = new System.Drawing.Size(13, 13);
            this.MesasDisponibles.TabIndex = 7;
            this.MesasDisponibles.Text = "0";
            // 
            // CubiertosButton
            // 
            this.CubiertosButton.Location = new System.Drawing.Point(25, 96);
            this.CubiertosButton.Name = "CubiertosButton";
            this.CubiertosButton.Size = new System.Drawing.Size(75, 23);
            this.CubiertosButton.TabIndex = 8;
            this.CubiertosButton.Text = "Confirmar";
            this.CubiertosButton.UseVisualStyleBackColor = true;
            this.CubiertosButton.Click += new System.EventHandler(this.Cubiertos_Click_1);
            // 
            // CubiertosTextbox
            // 
            this.CubiertosTextbox.Location = new System.Drawing.Point(25, 55);
            this.CubiertosTextbox.Name = "CubiertosTextbox";
            this.CubiertosTextbox.Size = new System.Drawing.Size(100, 20);
            this.CubiertosTextbox.TabIndex = 9;
            // 
            // CubiertosLabel
            // 
            this.CubiertosLabel.AutoSize = true;
            this.CubiertosLabel.Location = new System.Drawing.Point(22, 29);
            this.CubiertosLabel.Name = "CubiertosLabel";
            this.CubiertosLabel.Size = new System.Drawing.Size(98, 13);
            this.CubiertosLabel.TabIndex = 10;
            this.CubiertosLabel.Text = "Precio de cubiertos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(587, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Config";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.CubiertosLabel);
            this.panel1.Controls.Add(this.CubiertosButton);
            this.panel1.Controls.Add(this.CubiertosTextbox);
            this.panel1.Controls.Add(this.MesasCantidadLabel);
            this.panel1.Controls.Add(this.CantidadMesasTextbox);
            this.panel1.Controls.Add(this.CantidadMesasButton);
            this.panel1.Location = new System.Drawing.Point(361, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 143);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            this.panel1.Leave += new System.EventHandler(this.panel1_Leave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(261, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MesasDisponibles);
            this.Controls.Add(this.MesasAbiertas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CantidadMesasButton;
        private System.Windows.Forms.TextBox CantidadMesasTextbox;
        private System.Windows.Forms.Label MesasCantidadLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MesasAbiertas;
        private System.Windows.Forms.Label MesasDisponibles;
        private System.Windows.Forms.Button CubiertosButton;
        private System.Windows.Forms.TextBox CubiertosTextbox;
        private System.Windows.Forms.Label CubiertosLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
    }
}

