namespace Parcial_2
{
    partial class fmConversor
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
            this.lblGalonesLitros = new System.Windows.Forms.Label();
            this.lblLitrosGalones = new System.Windows.Forms.Label();
            this.btnGL = new System.Windows.Forms.Button();
            this.btnLG = new System.Windows.Forms.Button();
            this.txtGL = new System.Windows.Forms.TextBox();
            this.txtLG = new System.Windows.Forms.TextBox();
            this.txtGalones = new System.Windows.Forms.TextBox();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGalonesLitros
            // 
            this.lblGalonesLitros.AutoSize = true;
            this.lblGalonesLitros.Location = new System.Drawing.Point(88, 99);
            this.lblGalonesLitros.Name = "lblGalonesLitros";
            this.lblGalonesLitros.Size = new System.Drawing.Size(125, 20);
            this.lblGalonesLitros.TabIndex = 0;
            this.lblGalonesLitros.Text = "Galones a Litros";
            // 
            // lblLitrosGalones
            // 
            this.lblLitrosGalones.AutoSize = true;
            this.lblLitrosGalones.Location = new System.Drawing.Point(88, 168);
            this.lblLitrosGalones.Name = "lblLitrosGalones";
            this.lblLitrosGalones.Size = new System.Drawing.Size(125, 20);
            this.lblLitrosGalones.TabIndex = 1;
            this.lblLitrosGalones.Text = "Litros a Galones";
            // 
            // btnGL
            // 
            this.btnGL.Location = new System.Drawing.Point(463, 94);
            this.btnGL.Name = "btnGL";
            this.btnGL.Size = new System.Drawing.Size(63, 31);
            this.btnGL.TabIndex = 2;
            this.btnGL.Text = "->";
            this.btnGL.UseVisualStyleBackColor = true;
            this.btnGL.Click += new System.EventHandler(this.btnGL_Click);
            // 
            // btnLG
            // 
            this.btnLG.Location = new System.Drawing.Point(463, 163);
            this.btnLG.Name = "btnLG";
            this.btnLG.Size = new System.Drawing.Size(63, 31);
            this.btnLG.TabIndex = 3;
            this.btnLG.Text = "->";
            this.btnLG.UseVisualStyleBackColor = true;
            this.btnLG.Click += new System.EventHandler(this.btnLG_Click);
            // 
            // txtGL
            // 
            this.txtGL.Location = new System.Drawing.Point(593, 93);
            this.txtGL.Name = "txtGL";
            this.txtGL.Size = new System.Drawing.Size(129, 26);
            this.txtGL.TabIndex = 4;
            this.txtGL.TextChanged += new System.EventHandler(this.txtGL_TextChanged);
            // 
            // txtLG
            // 
            this.txtLG.Location = new System.Drawing.Point(593, 162);
            this.txtLG.Name = "txtLG";
            this.txtLG.Size = new System.Drawing.Size(129, 26);
            this.txtLG.TabIndex = 5;
            this.txtLG.TextChanged += new System.EventHandler(this.txtLG_TextChanged);
            // 
            // txtGalones
            // 
            this.txtGalones.Location = new System.Drawing.Point(264, 99);
            this.txtGalones.Name = "txtGalones";
            this.txtGalones.Size = new System.Drawing.Size(129, 26);
            this.txtGalones.TabIndex = 6;
            this.txtGalones.TextChanged += new System.EventHandler(this.txtGalones_TextChanged);
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(264, 168);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(129, 26);
            this.txtLitros.TabIndex = 7;
            this.txtLitros.TextChanged += new System.EventHandler(this.txtLitros_TextChanged);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(593, 273);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(114, 44);
            this.btnHistorial.TabIndex = 8;
            this.btnHistorial.Text = "Ver Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // fmConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.txtGalones);
            this.Controls.Add(this.txtLG);
            this.Controls.Add(this.txtGL);
            this.Controls.Add(this.btnLG);
            this.Controls.Add(this.btnGL);
            this.Controls.Add(this.lblLitrosGalones);
            this.Controls.Add(this.lblGalonesLitros);
            this.Name = "fmConversor";
            this.Text = "Conversor Numerico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGalonesLitros;
        private System.Windows.Forms.Label lblLitrosGalones;
        private System.Windows.Forms.Button btnGL;
        private System.Windows.Forms.Button btnLG;
        private System.Windows.Forms.TextBox txtGL;
        private System.Windows.Forms.TextBox txtLG;
        private System.Windows.Forms.TextBox txtGalones;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Button btnHistorial;
    }
}

