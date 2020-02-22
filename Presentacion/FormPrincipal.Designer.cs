namespace Presentacion
{
    partial class FormPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCiclos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCiclo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlumnosDelCiclo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlumnosAsignados = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvAlumnosDelCiclo = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvEmpresasParaElCiclo = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAlumnosAsignados = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosDelCiclo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresasParaElCiclo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosAsignados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciclos:";
            // 
            // cmbCiclos
            // 
            this.cmbCiclos.FormattingEnabled = true;
            this.cmbCiclos.Location = new System.Drawing.Point(67, 30);
            this.cmbCiclos.Name = "cmbCiclos";
            this.cmbCiclos.Size = new System.Drawing.Size(221, 21);
            this.cmbCiclos.TabIndex = 1;
            this.cmbCiclos.SelectedIndexChanged += new System.EventHandler(this.cmbCiclos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Ciclo:";
            // 
            // txtNombreCiclo
            // 
            this.txtNombreCiclo.Location = new System.Drawing.Point(384, 31);
            this.txtNombreCiclo.Name = "txtNombreCiclo";
            this.txtNombreCiclo.Size = new System.Drawing.Size(206, 20);
            this.txtNombreCiclo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alumnos/as del ciclo:";
            // 
            // txtAlumnosDelCiclo
            // 
            this.txtAlumnosDelCiclo.Location = new System.Drawing.Point(721, 32);
            this.txtAlumnosDelCiclo.Name = "txtAlumnosDelCiclo";
            this.txtAlumnosDelCiclo.Size = new System.Drawing.Size(44, 20);
            this.txtAlumnosDelCiclo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(786, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alumnos/as asignados:";
            // 
            // txtAlumnosAsignados
            // 
            this.txtAlumnosAsignados.Location = new System.Drawing.Point(906, 32);
            this.txtAlumnosAsignados.Name = "txtAlumnosAsignados";
            this.txtAlumnosAsignados.Size = new System.Drawing.Size(44, 20);
            this.txtAlumnosAsignados.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alumnos/as del ciclo";
            // 
            // dgvAlumnosDelCiclo
            // 
            this.dgvAlumnosDelCiclo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnosDelCiclo.Location = new System.Drawing.Point(29, 98);
            this.dgvAlumnosDelCiclo.Name = "dgvAlumnosDelCiclo";
            this.dgvAlumnosDelCiclo.Size = new System.Drawing.Size(397, 207);
            this.dgvAlumnosDelCiclo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Empresas para el ciclo (ordenadas alfabéticamente)";
            // 
            // dgvEmpresasParaElCiclo
            // 
            this.dgvEmpresasParaElCiclo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresasParaElCiclo.Location = new System.Drawing.Point(450, 98);
            this.dgvEmpresasParaElCiclo.Name = "dgvEmpresasParaElCiclo";
            this.dgvEmpresasParaElCiclo.Size = new System.Drawing.Size(500, 468);
            this.dgvEmpresasParaElCiclo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Alumnos/as del ciclo con empresa ya asignada";
            // 
            // dgvAlumnosAsignados
            // 
            this.dgvAlumnosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnosAsignados.Location = new System.Drawing.Point(29, 337);
            this.dgvAlumnosAsignados.Name = "dgvAlumnosAsignados";
            this.dgvAlumnosAsignados.Size = new System.Drawing.Size(397, 229);
            this.dgvAlumnosAsignados.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Asignar Empresa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAlumnosAsignados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvEmpresasParaElCiclo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvAlumnosDelCiclo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAlumnosAsignados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlumnosDelCiclo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreCiclo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCiclos);
            this.Controls.Add(this.label1);
            this.Name = "FormPrincipal";
            this.Text = "Consultas por ciclo";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosDelCiclo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresasParaElCiclo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosAsignados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCiclos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCiclo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlumnosDelCiclo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlumnosAsignados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvAlumnosDelCiclo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvEmpresasParaElCiclo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvAlumnosAsignados;
        private System.Windows.Forms.Button button1;
    }
}

