namespace StockProject.UI
{
    partial class FrmOrder
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
            this.DtlShopping = new System.Windows.Forms.DataGridView();
            this.BtnConfirmation = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.btnCountChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnShopping = new System.Windows.Forms.Button();
            this.lblorderId = new System.Windows.Forms.Label();
            this.lblproductId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtlShopping)).BeginInit();
            this.SuspendLayout();
            // 
            // DtlShopping
            // 
            this.DtlShopping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtlShopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtlShopping.Location = new System.Drawing.Point(12, 12);
            this.DtlShopping.Name = "DtlShopping";
            this.DtlShopping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtlShopping.Size = new System.Drawing.Size(656, 214);
            this.DtlShopping.TabIndex = 0;
            // 
            // BtnConfirmation
            // 
            this.BtnConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnConfirmation.Location = new System.Drawing.Point(12, 250);
            this.BtnConfirmation.Name = "BtnConfirmation";
            this.BtnConfirmation.Size = new System.Drawing.Size(115, 37);
            this.BtnConfirmation.TabIndex = 3;
            this.BtnConfirmation.Text = "Confirmation";
            this.BtnConfirmation.UseVisualStyleBackColor = true;
            this.BtnConfirmation.Click += new System.EventHandler(this.BtnConfirmation_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.Location = new System.Drawing.Point(133, 250);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(133, 37);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete Product";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnCountChange
            // 
            this.btnCountChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCountChange.Location = new System.Drawing.Point(272, 250);
            this.btnCountChange.Name = "btnCountChange";
            this.btnCountChange.Size = new System.Drawing.Size(115, 37);
            this.btnCountChange.TabIndex = 5;
            this.btnCountChange.Text = "Count Change";
            this.btnCountChange.UseVisualStyleBackColor = true;
            this.btnCountChange.Click += new System.EventHandler(this.btnCountChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(514, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total : ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotal.Location = new System.Drawing.Point(580, 260);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 7;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(445, 295);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Visible = false;
            // 
            // btnShopping
            // 
            this.btnShopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShopping.Location = new System.Drawing.Point(393, 250);
            this.btnShopping.Name = "btnShopping";
            this.btnShopping.Size = new System.Drawing.Size(115, 37);
            this.btnShopping.TabIndex = 5;
            this.btnShopping.Text = "<< Shopping";
            this.btnShopping.UseVisualStyleBackColor = true;
            this.btnShopping.Click += new System.EventHandler(this.btnShopping_Click);
            // 
            // lblorderId
            // 
            this.lblorderId.AutoSize = true;
            this.lblorderId.Location = new System.Drawing.Point(40, 308);
            this.lblorderId.Name = "lblorderId";
            this.lblorderId.Size = new System.Drawing.Size(0, 13);
            this.lblorderId.TabIndex = 9;
            this.lblorderId.Visible = false;
            // 
            // lblproductId
            // 
            this.lblproductId.AutoSize = true;
            this.lblproductId.Location = new System.Drawing.Point(130, 308);
            this.lblproductId.Name = "lblproductId";
            this.lblproductId.Size = new System.Drawing.Size(0, 13);
            this.lblproductId.TabIndex = 10;
            this.lblproductId.Visible = false;
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(680, 330);
            this.Controls.Add(this.lblproductId);
            this.Controls.Add(this.lblorderId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShopping);
            this.Controls.Add(this.btnCountChange);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnConfirmation);
            this.Controls.Add(this.DtlShopping);
            this.Name = "FrmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrder";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtlShopping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtlShopping;
        private System.Windows.Forms.Button BtnConfirmation;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button btnCountChange;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnShopping;
        public System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblorderId;
        private System.Windows.Forms.Label lblproductId;
    }
}