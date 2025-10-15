namespace Laboratorio_14
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tsbBuscar = new System.Windows.Forms.Button();
            this.tsbCancelar = new System.Windows.Forms.Button();
            this.tsbEliminar = new System.Windows.Forms.Button();
            this.tsbGuardar = new System.Windows.Forms.Button();
            this.tsbNuevo = new System.Windows.Forms.Button();
            this.tstId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.BackgroundImage")));
            this.tsbBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbBuscar.Location = new System.Drawing.Point(634, 2);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(72, 64);
            this.tsbBuscar.TabIndex = 0;
            this.tsbBuscar.UseVisualStyleBackColor = true;
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.BackgroundImage")));
            this.tsbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbCancelar.Location = new System.Drawing.Point(183, 3);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(69, 65);
            this.tsbCancelar.TabIndex = 1;
            this.tsbCancelar.UseVisualStyleBackColor = true;
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.BackgroundImage")));
            this.tsbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbEliminar.Location = new System.Drawing.Point(258, 3);
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(65, 63);
            this.tsbEliminar.TabIndex = 2;
            this.tsbEliminar.UseVisualStyleBackColor = true;
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.BackgroundImage")));
            this.tsbGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbGuardar.Location = new System.Drawing.Point(102, 3);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(75, 70);
            this.tsbGuardar.TabIndex = 3;
            this.tsbGuardar.UseVisualStyleBackColor = true;
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.BackgroundImage")));
            this.tsbNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbNuevo.Location = new System.Drawing.Point(27, 3);
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(69, 65);
            this.tsbNuevo.TabIndex = 4;
            this.tsbNuevo.UseVisualStyleBackColor = true;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tstId
            // 
            this.tstId.Location = new System.Drawing.Point(473, 25);
            this.tstId.Name = "tstId";
            this.tstId.Size = new System.Drawing.Size(155, 26);
            this.tstId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar por ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stock";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(49, 198);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(107, 26);
            this.txtId.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(303, 198);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(343, 26);
            this.txtNombre.TabIndex = 12;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(49, 299);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(107, 26);
            this.txtPrecio.TabIndex = 13;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(303, 299);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(107, 26);
            this.txtStock.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(49, 374);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 39);
            this.button6.TabIndex = 15;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tstId);
            this.Controls.Add(this.tsbNuevo);
            this.Controls.Add(this.tsbGuardar);
            this.Controls.Add(this.tsbEliminar);
            this.Controls.Add(this.tsbCancelar);
            this.Controls.Add(this.tsbBuscar);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tsbBuscar;
        private System.Windows.Forms.Button tsbCancelar;
        private System.Windows.Forms.Button tsbEliminar;
        private System.Windows.Forms.Button tsbGuardar;
        private System.Windows.Forms.Button tsbNuevo;
        private System.Windows.Forms.TextBox tstId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button button6;
    }
}

