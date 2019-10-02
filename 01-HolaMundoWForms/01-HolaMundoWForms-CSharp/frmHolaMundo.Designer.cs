namespace _01_HolaMundoWForms_CSharp
{
    partial class frmHolaMundo
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lbErrorN = new System.Windows.Forms.Label();
            this.lbErrorPA = new System.Windows.Forms.Label();
            this.lbPrimerApellido = new System.Windows.Forms.Label();
            this.tbPrimerApellido = new System.Windows.Forms.TextBox();
            this.lbErrorSA = new System.Windows.Forms.Label();
            this.segundoApellido = new System.Windows.Forms.Label();
            this.tbSegundoApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(272, 33);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(149, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(272, 158);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Mostrar";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnSaludo_Click);
            // 
            // lbErrorN
            // 
            this.lbErrorN.AutoSize = true;
            this.lbErrorN.ForeColor = System.Drawing.Color.Red;
            this.lbErrorN.Location = new System.Drawing.Point(378, 36);
            this.lbErrorN.Name = "lbErrorN";
            this.lbErrorN.Size = new System.Drawing.Size(0, 13);
            this.lbErrorN.TabIndex = 3;
            // 
            // lbErrorPA
            // 
            this.lbErrorPA.AutoSize = true;
            this.lbErrorPA.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPA.Location = new System.Drawing.Point(378, 62);
            this.lbErrorPA.Name = "lbErrorPA";
            this.lbErrorPA.Size = new System.Drawing.Size(0, 13);
            this.lbErrorPA.TabIndex = 6;
            // 
            // lbPrimerApellido
            // 
            this.lbPrimerApellido.AutoSize = true;
            this.lbPrimerApellido.Location = new System.Drawing.Point(149, 59);
            this.lbPrimerApellido.Name = "lbPrimerApellido";
            this.lbPrimerApellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPrimerApellido.Size = new System.Drawing.Size(79, 13);
            this.lbPrimerApellido.TabIndex = 5;
            this.lbPrimerApellido.Text = "Primer Apellido:";
            // 
            // tbPrimerApellido
            // 
            this.tbPrimerApellido.Location = new System.Drawing.Point(272, 59);
            this.tbPrimerApellido.Name = "tbPrimerApellido";
            this.tbPrimerApellido.Size = new System.Drawing.Size(100, 20);
            this.tbPrimerApellido.TabIndex = 1;
            // 
            // lbErrorSA
            // 
            this.lbErrorSA.AutoSize = true;
            this.lbErrorSA.ForeColor = System.Drawing.Color.Red;
            this.lbErrorSA.Location = new System.Drawing.Point(378, 88);
            this.lbErrorSA.Name = "lbErrorSA";
            this.lbErrorSA.Size = new System.Drawing.Size(0, 13);
            this.lbErrorSA.TabIndex = 9;
            // 
            // segundoApellido
            // 
            this.segundoApellido.AutoSize = true;
            this.segundoApellido.Location = new System.Drawing.Point(149, 85);
            this.segundoApellido.Name = "segundoApellido";
            this.segundoApellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.segundoApellido.Size = new System.Drawing.Size(93, 13);
            this.segundoApellido.TabIndex = 8;
            this.segundoApellido.Text = "Segundo Apellido:";
            // 
            // tbSegundoApellido
            // 
            this.tbSegundoApellido.Location = new System.Drawing.Point(272, 85);
            this.tbSegundoApellido.Name = "tbSegundoApellido";
            this.tbSegundoApellido.Size = new System.Drawing.Size(100, 20);
            this.tbSegundoApellido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fecha de Nacimiento:";
            // 
            // datFechaNacimiento
            // 
            this.datFechaNacimiento.Location = new System.Drawing.Point(272, 117);
            this.datFechaNacimiento.Name = "datFechaNacimiento";
            this.datFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.datFechaNacimiento.TabIndex = 3;
            this.datFechaNacimiento.Value = new System.DateTime(2019, 9, 30, 0, 0, 0, 0);
            // 
            // frmHolaMundo
            // 
            this.AcceptButton = this.btnImprimir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datFechaNacimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbErrorSA);
            this.Controls.Add(this.segundoApellido);
            this.Controls.Add(this.tbSegundoApellido);
            this.Controls.Add(this.lbErrorPA);
            this.Controls.Add(this.lbPrimerApellido);
            this.Controls.Add(this.tbPrimerApellido);
            this.Controls.Add(this.lbErrorN);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbNombre);
            this.Name = "frmHolaMundo";
            this.Text = "Formulario CSharp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lbErrorN;
        private System.Windows.Forms.Label lbErrorPA;
        private System.Windows.Forms.Label lbPrimerApellido;
        private System.Windows.Forms.TextBox tbPrimerApellido;
        private System.Windows.Forms.Label lbErrorSA;
        private System.Windows.Forms.Label segundoApellido;
        private System.Windows.Forms.TextBox tbSegundoApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datFechaNacimiento;
    }
}

