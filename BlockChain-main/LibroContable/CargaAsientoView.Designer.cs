namespace LibroContable
{
    partial class CargaAsientoView
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
            this.gbCargaMovimiento = new System.Windows.Forms.GroupBox();
            this.lblHaber = new System.Windows.Forms.Label();
            this.lblDebe = new System.Windows.Forms.Label();
            this.lblCuentaListBox = new System.Windows.Forms.Label();
            this.listBoxCuenta = new System.Windows.Forms.ListBox();
            this.txtHaber = new System.Windows.Forms.TextBox();
            this.txtDebe = new System.Windows.Forms.TextBox();
            this.btnAgregarMovimiento = new System.Windows.Forms.Button();
            this.dataGridMovimientos = new System.Windows.Forms.DataGridView();
            this.CodigoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargarAsiento = new System.Windows.Forms.Button();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.gbCargaMovimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCargaMovimiento
            // 
            this.gbCargaMovimiento.BackColor = System.Drawing.SystemColors.Info;
            this.gbCargaMovimiento.Controls.Add(this.lblHaber);
            this.gbCargaMovimiento.Controls.Add(this.lblDebe);
            this.gbCargaMovimiento.Controls.Add(this.lblCuentaListBox);
            this.gbCargaMovimiento.Controls.Add(this.listBoxCuenta);
            this.gbCargaMovimiento.Controls.Add(this.txtHaber);
            this.gbCargaMovimiento.Controls.Add(this.txtDebe);
            this.gbCargaMovimiento.Controls.Add(this.btnAgregarMovimiento);
            this.gbCargaMovimiento.Location = new System.Drawing.Point(494, 24);
            this.gbCargaMovimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCargaMovimiento.Name = "gbCargaMovimiento";
            this.gbCargaMovimiento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCargaMovimiento.Size = new System.Drawing.Size(466, 260);
            this.gbCargaMovimiento.TabIndex = 0;
            this.gbCargaMovimiento.TabStop = false;
            this.gbCargaMovimiento.Text = "Agregar Movimiento";
            // 
            // lblHaber
            // 
            this.lblHaber.AutoSize = true;
            this.lblHaber.Location = new System.Drawing.Point(16, 122);
            this.lblHaber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHaber.Name = "lblHaber";
            this.lblHaber.Size = new System.Drawing.Size(64, 25);
            this.lblHaber.TabIndex = 6;
            this.lblHaber.Text = "Haber:";
            // 
            // lblDebe
            // 
            this.lblDebe.AutoSize = true;
            this.lblDebe.Location = new System.Drawing.Point(19, 55);
            this.lblDebe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDebe.Name = "lblDebe";
            this.lblDebe.Size = new System.Drawing.Size(58, 25);
            this.lblDebe.TabIndex = 5;
            this.lblDebe.Text = "Debe:";
            // 
            // lblCuentaListBox
            // 
            this.lblCuentaListBox.AutoSize = true;
            this.lblCuentaListBox.Location = new System.Drawing.Point(16, 197);
            this.lblCuentaListBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuentaListBox.Name = "lblCuentaListBox";
            this.lblCuentaListBox.Size = new System.Drawing.Size(71, 25);
            this.lblCuentaListBox.TabIndex = 4;
            this.lblCuentaListBox.Text = "Cuenta:";
            // 
            // listBoxCuenta
            // 
            this.listBoxCuenta.FormattingEnabled = true;
            this.listBoxCuenta.ItemHeight = 25;
            this.listBoxCuenta.Location = new System.Drawing.Point(96, 197);
            this.listBoxCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxCuenta.Name = "listBoxCuenta";
            this.listBoxCuenta.Size = new System.Drawing.Size(198, 29);
            this.listBoxCuenta.TabIndex = 3;
            // 
            // txtHaber
            // 
            this.txtHaber.Location = new System.Drawing.Point(96, 117);
            this.txtHaber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHaber.Name = "txtHaber";
            this.txtHaber.Size = new System.Drawing.Size(198, 31);
            this.txtHaber.TabIndex = 2;
            // 
            // txtDebe
            // 
            this.txtDebe.Location = new System.Drawing.Point(96, 50);
            this.txtDebe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDebe.Name = "txtDebe";
            this.txtDebe.Size = new System.Drawing.Size(198, 31);
            this.txtDebe.TabIndex = 1;
            // 
            // btnAgregarMovimiento
            // 
            this.btnAgregarMovimiento.Location = new System.Drawing.Point(341, 109);
            this.btnAgregarMovimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarMovimiento.Name = "btnAgregarMovimiento";
            this.btnAgregarMovimiento.Size = new System.Drawing.Size(107, 38);
            this.btnAgregarMovimiento.TabIndex = 0;
            this.btnAgregarMovimiento.Text = "Agregar";
            this.btnAgregarMovimiento.UseVisualStyleBackColor = true;
            this.btnAgregarMovimiento.Click += new System.EventHandler(this.btnAgregarMovimiento_Click);
            // 
            // dataGridMovimientos
            // 
            this.dataGridMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCuenta,
            this.DescripcionCuenta,
            this.Debe,
            this.Haber});
            this.dataGridMovimientos.Location = new System.Drawing.Point(17, 322);
            this.dataGridMovimientos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridMovimientos.Name = "dataGridMovimientos";
            this.dataGridMovimientos.RowHeadersWidth = 62;
            this.dataGridMovimientos.RowTemplate.Height = 25;
            this.dataGridMovimientos.Size = new System.Drawing.Size(1109, 408);
            this.dataGridMovimientos.TabIndex = 1;
            // 
            // CodigoCuenta
            // 
            this.CodigoCuenta.HeaderText = "Cuenta";
            this.CodigoCuenta.MinimumWidth = 8;
            this.CodigoCuenta.Name = "CodigoCuenta";
            this.CodigoCuenta.ReadOnly = true;
            this.CodigoCuenta.Width = 150;
            // 
            // DescripcionCuenta
            // 
            this.DescripcionCuenta.HeaderText = "Descripcion";
            this.DescripcionCuenta.MinimumWidth = 8;
            this.DescripcionCuenta.Name = "DescripcionCuenta";
            this.DescripcionCuenta.ReadOnly = true;
            this.DescripcionCuenta.Width = 150;
            // 
            // Debe
            // 
            this.Debe.HeaderText = "Debe";
            this.Debe.MinimumWidth = 8;
            this.Debe.Name = "Debe";
            this.Debe.ReadOnly = true;
            this.Debe.Width = 150;
            // 
            // Haber
            // 
            this.Haber.HeaderText = "Haber";
            this.Haber.MinimumWidth = 8;
            this.Haber.Name = "Haber";
            this.Haber.ReadOnly = true;
            this.Haber.Width = 150;
            // 
            // btnCargarAsiento
            // 
            this.btnCargarAsiento.Location = new System.Drawing.Point(999, 207);
            this.btnCargarAsiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargarAsiento.Name = "btnCargarAsiento";
            this.btnCargarAsiento.Size = new System.Drawing.Size(127, 77);
            this.btnCargarAsiento.TabIndex = 2;
            this.btnCargarAsiento.Text = "Confirmar Asiento";
            this.btnCargarAsiento.UseVisualStyleBackColor = true;
            this.btnCargarAsiento.Click += new System.EventHandler(this.btnCargarAsiento_Click);
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(17, 147);
            this.lblConcepto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(93, 25);
            this.lblConcepto.TabIndex = 8;
            this.lblConcepto.Text = "Concepto:";
            // 
            // txtConcepto
            // 
            this.txtConcepto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtConcepto.Location = new System.Drawing.Point(127, 147);
            this.txtConcepto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(250, 31);
            this.txtConcepto.TabIndex = 7;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(691, 78);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 32);
            this.lblError.TabIndex = 9;
            // 
            // CargaAsientoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.btnCargarAsiento);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.dataGridMovimientos);
            this.Controls.Add(this.gbCargaMovimiento);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CargaAsientoView";
            this.Text = "Carga Asiento";
            this.gbCargaMovimiento.ResumeLayout(false);
            this.gbCargaMovimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbCargaMovimiento;
        private Button btnAgregarMovimiento;
        private DataGridView dataGridMovimientos;
        private Button btnCargarAsiento;
        private Label lblCuentaListBox;
        private ListBox listBoxCuenta;
        private TextBox txtHaber;
        private TextBox txtDebe;
        private Label lblHaber;
        private Label lblDebe;
        private Label lblConcepto;
        private TextBox txtConcepto;
        private DataGridViewTextBoxColumn CodigoCuenta;
        private DataGridViewTextBoxColumn DescripcionCuenta;
        private DataGridViewTextBoxColumn Debe;
        private DataGridViewTextBoxColumn Haber;
        private Label lblError;
    }
}