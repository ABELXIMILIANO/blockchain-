namespace LibroContable
{
    partial class BlockchainView
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
            this.flowLayoutBlochainItem = new System.Windows.Forms.FlowLayoutPanel();
            this.blockChainItem1 = new LibroContable.View.BlockChainItem();
            this.lblTitleBlockchain = new System.Windows.Forms.Label();
            this.flowLayoutBlochainItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutBlochainItem
            // 
            this.flowLayoutBlochainItem.AutoScroll = true;
            this.flowLayoutBlochainItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutBlochainItem.Controls.Add(this.blockChainItem1);
            this.flowLayoutBlochainItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutBlochainItem.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutBlochainItem.Location = new System.Drawing.Point(0, 173);
            this.flowLayoutBlochainItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutBlochainItem.Name = "flowLayoutBlochainItem";
            this.flowLayoutBlochainItem.Size = new System.Drawing.Size(1143, 795);
            this.flowLayoutBlochainItem.TabIndex = 0;
            this.flowLayoutBlochainItem.WrapContents = false;
            // 
            // blockChainItem1
            // 
            this.blockChainItem1.Asientos = null;
            this.blockChainItem1.FechaLibro = null;
            this.blockChainItem1.IdLibro = null;
            this.blockChainItem1.Location = new System.Drawing.Point(6, 8);
            this.blockChainItem1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.blockChainItem1.Name = "blockChainItem1";
            this.blockChainItem1.Size = new System.Drawing.Size(1139, 598);
            this.blockChainItem1.TabIndex = 0;
            // 
            // lblTitleBlockchain
            // 
            this.lblTitleBlockchain.AutoSize = true;
            this.lblTitleBlockchain.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleBlockchain.Location = new System.Drawing.Point(329, 120);
            this.lblTitleBlockchain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleBlockchain.Name = "lblTitleBlockchain";
            this.lblTitleBlockchain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitleBlockchain.Size = new System.Drawing.Size(295, 48);
            this.lblTitleBlockchain.TabIndex = 1;
            this.lblTitleBlockchain.Text = "Listado Bloques:";
            // 
            // BlockchainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1143, 968);
            this.Controls.Add(this.lblTitleBlockchain);
            this.Controls.Add(this.flowLayoutBlochainItem);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BlockchainView";
            this.RightToLeftLayout = true;
            this.Text = "BlockChain";
            this.flowLayoutBlochainItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutBlochainItem;
        private View.BlockChainItem blockChainItem1;
        private Label lblTitleBlockchain;
    }
}