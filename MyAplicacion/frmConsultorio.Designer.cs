namespace MyAplicacion
{
    partial class FrmConsultorio
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
            btnClientes = new Button();
            btnDoctores = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(41, 130);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(94, 29);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnDoctores
            // 
            btnDoctores.Location = new Point(41, 189);
            btnDoctores.Name = "btnDoctores";
            btnDoctores.Size = new Size(94, 29);
            btnDoctores.TabIndex = 1;
            btnDoctores.Text = "Doctores";
            btnDoctores.UseVisualStyleBackColor = true;
            // 
            // FrmConsultorio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 487);
            Controls.Add(btnDoctores);
            Controls.Add(btnClientes);
            Name = "FrmConsultorio";
            Text = "Consultorio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnDoctores;
    }
}
