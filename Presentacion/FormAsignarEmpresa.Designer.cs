namespace Presentacion
{
    partial class FormAsignarEmpresa
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
            this.txtTutorEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmbCiclos = new System.Windows.Forms.ComboBox();
            this.cmbAlumnosDelCiclo = new System.Windows.Forms.ComboBox();
            this.cmbEmpresasParaElCiclo = new System.Windows.Forms.ComboBox();
            this.cmbTutorInstituto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtTutorEmpresa
            // 
            this.txtTutorEmpresa.Location = new System.Drawing.Point(395, 108);
            this.txtTutorEmpresa.Name = "txtTutorEmpresa";
            this.txtTutorEmpresa.Size = new System.Drawing.Size(130, 20);
            this.txtTutorEmpresa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ciclo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alumnos/as del ciclo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Empresa para el ciclo (ordenada alfabéticamente)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tutor/a del instituto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tutor/a de la empresa";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(186, 159);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 6;
            this.btnAsignar.Text = "&Asignar empresa";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(280, 159);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmbCiclos
            // 
            this.cmbCiclos.FormattingEnabled = true;
            this.cmbCiclos.Location = new System.Drawing.Point(66, 25);
            this.cmbCiclos.Name = "cmbCiclos";
            this.cmbCiclos.Size = new System.Drawing.Size(195, 21);
            this.cmbCiclos.TabIndex = 8;
            this.cmbCiclos.SelectedIndexChanged += new System.EventHandler(this.cmbCiclos_SelectedIndexChanged);
            // 
            // cmbAlumnosDelCiclo
            // 
            this.cmbAlumnosDelCiclo.FormattingEnabled = true;
            this.cmbAlumnosDelCiclo.Location = new System.Drawing.Point(388, 25);
            this.cmbAlumnosDelCiclo.Name = "cmbAlumnosDelCiclo";
            this.cmbAlumnosDelCiclo.Size = new System.Drawing.Size(137, 21);
            this.cmbAlumnosDelCiclo.TabIndex = 9;
            // 
            // cmbEmpresasParaElCiclo
            // 
            this.cmbEmpresasParaElCiclo.FormattingEnabled = true;
            this.cmbEmpresasParaElCiclo.Location = new System.Drawing.Point(280, 65);
            this.cmbEmpresasParaElCiclo.Name = "cmbEmpresasParaElCiclo";
            this.cmbEmpresasParaElCiclo.Size = new System.Drawing.Size(245, 21);
            this.cmbEmpresasParaElCiclo.TabIndex = 10;
            // 
            // cmbTutorInstituto
            // 
            this.cmbTutorInstituto.FormattingEnabled = true;
            this.cmbTutorInstituto.Location = new System.Drawing.Point(126, 108);
            this.cmbTutorInstituto.Name = "cmbTutorInstituto";
            this.cmbTutorInstituto.Size = new System.Drawing.Size(135, 21);
            this.cmbTutorInstituto.TabIndex = 11;
            // 
            // FormAsignarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 202);
            this.Controls.Add(this.cmbTutorInstituto);
            this.Controls.Add(this.cmbEmpresasParaElCiclo);
            this.Controls.Add(this.cmbAlumnosDelCiclo);
            this.Controls.Add(this.cmbCiclos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTutorEmpresa);
            this.Name = "FormAsignarEmpresa";
            this.Text = "FormAsignarEmpresa";
            this.Load += new System.EventHandler(this.FormAsignarEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTutorEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cmbCiclos;
        private System.Windows.Forms.ComboBox cmbAlumnosDelCiclo;
        private System.Windows.Forms.ComboBox cmbEmpresasParaElCiclo;
        private System.Windows.Forms.ComboBox cmbTutorInstituto;
    }
}