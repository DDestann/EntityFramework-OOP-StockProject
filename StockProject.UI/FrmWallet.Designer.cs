namespace StockProject.UI
{
    partial class FrmWallet
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
            this.btnConfirmation = new System.Windows.Forms.Button();
            this.btnShopping = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtAdwallet = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.txtWallet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfirmation.Location = new System.Drawing.Point(100, 105);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(120, 37);
            this.btnConfirmation.TabIndex = 7;
            this.btnConfirmation.Text = "Confirmation";
            this.btnConfirmation.UseVisualStyleBackColor = true;
            this.btnConfirmation.Click += new System.EventHandler(this.btnConfirmation_Click);
            // 
            // btnShopping
            // 
            this.btnShopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShopping.Location = new System.Drawing.Point(241, 105);
            this.btnShopping.Name = "btnShopping";
            this.btnShopping.Size = new System.Drawing.Size(120, 37);
            this.btnShopping.TabIndex = 7;
            this.btnShopping.Text = "<<<Shopping";
            this.btnShopping.UseVisualStyleBackColor = true;
            this.btnShopping.Click += new System.EventHandler(this.btnShopping_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 159);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(84, 159);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Visible = false;
            // 
            // txtAdwallet
            // 
            this.txtAdwallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdwallet.Location = new System.Drawing.Point(114, 63);
            this.txtAdwallet.Multiline = true;
            this.txtAdwallet.Name = "txtAdwallet";
            this.txtAdwallet.Size = new System.Drawing.Size(236, 31);
            this.txtAdwallet.TabIndex = 13;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb.Location = new System.Drawing.Point(24, 69);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(84, 16);
            this.lb.TabIndex = 12;
            this.lb.Text = "Add Wallet";
            // 
            // txtWallet
            // 
            this.txtWallet.Enabled = false;
            this.txtWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtWallet.Location = new System.Drawing.Point(114, 18);
            this.txtWallet.Multiline = true;
            this.txtWallet.Name = "txtWallet";
            this.txtWallet.Size = new System.Drawing.Size(236, 31);
            this.txtWallet.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Wallet";
            // 
            // FrmWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(402, 183);
            this.Controls.Add(this.txtWallet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdwallet);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnShopping);
            this.Controls.Add(this.btnConfirmation);
            this.Name = "FrmWallet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmWallet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmation;
        private System.Windows.Forms.Button btnShopping;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.TextBox txtAdwallet;
        private System.Windows.Forms.Label lb;
        public System.Windows.Forms.TextBox txtWallet;
        private System.Windows.Forms.Label label3;
    }
}