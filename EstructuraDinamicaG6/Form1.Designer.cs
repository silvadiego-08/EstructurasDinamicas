namespace EstructuraDinamicaG6
{
    partial class FrmPilaDS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEdad = new Label();
            btnAgregar = new Button();
            tbEdad = new TextBox();
            lblEdades = new Label();
            btnEliminar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(58, 53);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(46, 20);
            lblEdad.TabIndex = 0;
            lblEdad.Text = "Edad:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(149, 86);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 36);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tbEdad
            // 
            tbEdad.Location = new Point(110, 53);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(125, 27);
            tbEdad.TabIndex = 2;
            // 
            // lblEdades
            // 
            lblEdades.AutoSize = true;
            lblEdades.Location = new Point(58, 170);
            lblEdades.Name = "lblEdades";
            lblEdades.Size = new Size(60, 20);
            lblEdades.TabIndex = 3;
            lblEdades.Text = "Edades:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(257, 86);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 36);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(149, 275);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 5;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmPilaDS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 450);
            Controls.Add(button1);
            Controls.Add(btnEliminar);
            Controls.Add(lblEdades);
            Controls.Add(tbEdad);
            Controls.Add(btnAgregar);
            Controls.Add(lblEdad);
            Name = "FrmPilaDS";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEdad;
        private Button btnAgregar;
        private TextBox tbEdad;
        private Label lblEdades;
        private Button btnEliminar;
        private Button button1;
    }
}
