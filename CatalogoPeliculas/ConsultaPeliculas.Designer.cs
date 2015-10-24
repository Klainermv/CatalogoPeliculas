namespace CatalogoPeliculas
{
    partial class ConsultaPeliculas
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
            this.PeliculasdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarcomboBox = new System.Windows.Forms.ComboBox();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Imprimirbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PeliculasdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PeliculasdataGridView
            // 
            this.PeliculasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeliculasdataGridView.Location = new System.Drawing.Point(12, 101);
            this.PeliculasdataGridView.Name = "PeliculasdataGridView";
            this.PeliculasdataGridView.Size = new System.Drawing.Size(531, 239);
            this.PeliculasdataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar por";
            // 
            // BuscarcomboBox
            // 
            this.BuscarcomboBox.FormattingEnabled = true;
            this.BuscarcomboBox.Items.AddRange(new object[] {
            "PeliculaId",
            "Titulo",
            "Director",
            "Idioma"});
            this.BuscarcomboBox.Location = new System.Drawing.Point(119, 45);
            this.BuscarcomboBox.Name = "BuscarcomboBox";
            this.BuscarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.BuscarcomboBox.TabIndex = 2;
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(246, 46);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(132, 20);
            this.BuscartextBox.TabIndex = 3;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(395, 45);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 4;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Imprimirbutton1
            // 
            this.Imprimirbutton1.Location = new System.Drawing.Point(491, 366);
            this.Imprimirbutton1.Name = "Imprimirbutton1";
            this.Imprimirbutton1.Size = new System.Drawing.Size(75, 23);
            this.Imprimirbutton1.TabIndex = 5;
            this.Imprimirbutton1.Text = "Imprimir";
            this.Imprimirbutton1.UseVisualStyleBackColor = true;
            this.Imprimirbutton1.Click += new System.EventHandler(this.Imprimirbutton1_Click);
            // 
            // ConsultaPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 401);
            this.Controls.Add(this.Imprimirbutton1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.BuscarcomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PeliculasdataGridView);
            this.Name = "ConsultaPeliculas";
            this.Text = "Consulta de Peliculas";
            ((System.ComponentModel.ISupportInitialize)(this.PeliculasdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PeliculasdataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BuscarcomboBox;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Imprimirbutton1;
    }
}