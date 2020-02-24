namespace Presentacion
{
    partial class FormRetirarEmpresa
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
            this.cmbCiclos = new System.Windows.Forms.ComboBox();
            this.cmbAlumnos = new System.Windows.Forms.ComboBox();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciclo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alumnos/as del ciclo";
            // 
            // cmbCiclos
            // 
            this.cmbCiclos.FormattingEnabled = true;
            this.cmbCiclos.Location = new System.Drawing.Point(57, 16);
            this.cmbCiclos.Name = "cmbCiclos";
            this.cmbCiclos.Size = new System.Drawing.Size(210, 21);
            this.cmbCiclos.TabIndex = 2;
            this.cmbCiclos.SelectedIndexChanged += new System.EventHandler(this.cmbCiclos_SelectedIndexChanged);
            // 
            // cmbAlumnos
            // 
            this.cmbAlumnos.FormattingEnabled = true;
            this.cmbAlumnos.Location = new System.Drawing.Point(132, 53);
            this.cmbAlumnos.Name = "cmbAlumnos";
            this.cmbAlumnos.Size = new System.Drawing.Size(135, 21);
            this.cmbAlumnos.TabIndex = 3;
            this.cmbAlumnos.SelectedIndexChanged += new System.EventHandler(this.cmbAlumnos_SelectedIndexChanged);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(39, 94);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(75, 23);
            this.btnRetirar.TabIndex = 4;
            this.btnRetirar.Text = "&Retirar empresa";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(152, 94);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormRetirarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 140);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.cmbAlumnos);
            this.Controls.Add(this.cmbCiclos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRetirarEmpresa";
            this.Text = "FormRetirarEmpresa";
            this.Load += new System.EventHandler(this.FormRetirarEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCiclos;
        private System.Windows.Forms.ComboBox cmbAlumnos;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnVolver;
    }
}