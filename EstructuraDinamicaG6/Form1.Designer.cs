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
            lbEdades = new Label();
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
            // 
            // tbEdad
            // 
            tbEdad.Location = new Point(110, 53);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(125, 27);
            tbEdad.TabIndex = 2;
            // 
            // lbEdades
            // 
            lbEdades.AutoSize = true;
            lbEdades.Location = new Point(58, 170);
            lbEdades.Name = "lbEdades";
            lbEdades.Size = new Size(60, 20);
            lbEdades.TabIndex = 3;
            lbEdades.Text = "Edades:";
            // 
            // FrmPilaDS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 450);
            Controls.Add(lbEdades);
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
        private Label lbEdades;
    }
}
