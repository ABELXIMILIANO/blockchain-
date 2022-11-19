namespace LibroContable
{
    partial class CargaCuentaView
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
            this.btnCargarCuenta = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.labelCodigoCuenta = new System.Windows.Forms.Label();
            this.labelDenominacion = new System.Windows.Forms.Label();
            this.txtCodigoCuenta = new System.Windows.Forms.TextBox();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCargarCuenta
            // 
            this.btnCargarCuenta.Location = new System.Drawing.Point(693, 317);
            this.btnCargarCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargarCuenta.Name = "btnCargarCuenta";
            this.btnCargarCuenta.Size = new System.Drawing.Size(107, 38);
            this.btnCargarCuenta.TabIndex = 0;
            this.btnCargarCuenta.Text = "Cargar";
            this.btnCargarCuenta.UseVisualStyleBackColor = true;
            this.btnCargarCuenta.Click += new System.EventHandler(this.btnCargarCuenta_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(13, 683);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 38);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // labelCodigoCuenta
            // 
            this.labelCodigoCuenta.AutoSize = true;
            this.labelCodigoCuenta.Location = new System.Drawing.Point(349, 263);
            this.labelCodigoCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCodigoCuenta.Name = "labelCodigoCuenta";
            this.labelCodigoCuenta.Size = new System.Drawing.Size(135, 25);
            this.labelCodigoCuenta.TabIndex = 2;
            this.labelCodigoCuenta.Text = "Codigo Cuenta:";
            // 
            // labelDenominacion
            // 
            this.labelDenominacion.AutoSize = true;
            this.labelDenominacion.Location = new System.Drawing.Point(349, 322);
            this.labelDenominacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDenominacion.Name = "labelDenominacion";
            this.labelDenominacion.Size = new System.Drawing.Size(131, 25);
            this.labelDenominacion.TabIndex = 3;
            this.labelDenominacion.Text = "Denominacion:";
            // 
            // txtCodigoCuenta
            // 
            this.txtCodigoCuenta.Location = new System.Drawing.Point(486, 258);
            this.txtCodigoCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoCuenta.Name = "txtCodigoCuenta";
            this.txtCodigoCuenta.Size = new System.Drawing.Size(141, 31);
            this.txtCodigoCuenta.TabIndex = 4;
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Location = new System.Drawing.Point(486, 317);
            this.txtDenominacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(141, 31);
            this.txtDenominacion.TabIndex = 5;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(349, 127);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 32);
            this.lblError.TabIndex = 10;
            // 
            // CargaCuentaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtDenominacion);
            this.Controls.Add(this.txtCodigoCuenta);
            this.Controls.Add(this.labelDenominacion);
            this.Controls.Add(this.labelCodigoCuenta);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCargarCuenta);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CargaCuentaView";
            this.Text = "Carga Cuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCargarCuenta;
        private Button btnVolver;
        private Label labelCodigoCuenta;
        private Label labelDenominacion;
        private TextBox txtCodigoCuenta;
        private TextBox txtDenominacion;
        private Label lblError;
    }
}