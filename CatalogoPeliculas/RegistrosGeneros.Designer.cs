namespace CatalogoPeliculas
{
    partial class RegistrosGeneros
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Limpiarbutton2 = new System.Windows.Forms.Button();
            this.Guardarbutton3 = new System.Windows.Forms.Button();
            this.Eliminarbutton4 = new System.Windows.Forms.Button();
            this.GeneroIdtextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GeneroId:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(242, 31);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 2;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // Limpiarbutton2
            // 
            this.Limpiarbutton2.Location = new System.Drawing.Point(29, 167);
            this.Limpiarbutton2.Name = "Limpiarbutton2";
            this.Limpiarbutton2.Size = new System.Drawing.Size(75, 23);
            this.Limpiarbutton2.TabIndex = 3;
            this.Limpiarbutton2.Text = "Limpiar";
            this.Limpiarbutton2.UseVisualStyleBackColor = true;
            this.Limpiarbutton2.Click += new System.EventHandler(this.Limpiarbutton2_Click);
            // 
            // Guardarbutton3
            // 
            this.Guardarbutton3.Location = new System.Drawing.Point(123, 167);
            this.Guardarbutton3.Name = "Guardarbutton3";
            this.Guardarbutton3.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton3.TabIndex = 4;
            this.Guardarbutton3.Text = "Guardar";
            this.Guardarbutton3.UseVisualStyleBackColor = true;
            this.Guardarbutton3.Click += new System.EventHandler(this.Guardarbutton3_Click);
            // 
            // Eliminarbutton4
            // 
            this.Eliminarbutton4.Location = new System.Drawing.Point(219, 167);
            this.Eliminarbutton4.Name = "Eliminarbutton4";
            this.Eliminarbutton4.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton4.TabIndex = 5;
            this.Eliminarbutton4.Text = "Eliminar";
            this.Eliminarbutton4.UseVisualStyleBackColor = true;
            this.Eliminarbutton4.Click += new System.EventHandler(this.Eliminarbutton4_Click);
            // 
            // GeneroIdtextBox
            // 
            this.GeneroIdtextBox.Location = new System.Drawing.Point(98, 34);
            this.GeneroIdtextBox.Name = "GeneroIdtextBox";
            this.GeneroIdtextBox.Size = new System.Drawing.Size(100, 20);
            this.GeneroIdtextBox.TabIndex = 6;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(98, 76);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(100, 20);
            this.DescripciontextBox.TabIndex = 7;
            // 
            // RegistrosGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 236);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.GeneroIdtextBox);
            this.Controls.Add(this.Eliminarbutton4);
            this.Controls.Add(this.Guardarbutton3);
            this.Controls.Add(this.Limpiarbutton2);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrosGeneros";
            this.Text = "Registros de Generos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Limpiarbutton2;
        private System.Windows.Forms.Button Guardarbutton3;
        private System.Windows.Forms.Button Eliminarbutton4;
        private System.Windows.Forms.TextBox GeneroIdtextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
    }
}