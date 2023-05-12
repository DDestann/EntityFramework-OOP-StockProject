namespace StockProject.UI
{
    partial class FrmProduct
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
            this.BtnShopping = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DrpCategory = new System.Windows.Forms.ComboBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.DtlShopping = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.btnShowShopping = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtlShopping)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnShopping
            // 
            this.BtnShopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnShopping.Location = new System.Drawing.Point(105, 283);
            this.BtnShopping.Name = "BtnShopping";
            this.BtnShopping.Size = new System.Drawing.Size(133, 37);
            this.BtnShopping.TabIndex = 7;
            this.BtnShopping.Text = "Add Shopping";
            this.BtnShopping.UseVisualStyleBackColor = true;
            this.BtnShopping.Click += new System.EventHandler(this.BtnAddShopping_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(372, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Count";
            // 
            // DrpCategory
            // 
            this.DrpCategory.FormattingEnabled = true;
            this.DrpCategory.Location = new System.Drawing.Point(153, 26);
            this.DrpCategory.Name = "DrpCategory";
            this.DrpCategory.Size = new System.Drawing.Size(169, 21);
            this.DrpCategory.TabIndex = 8;
            this.DrpCategory.SelectedIndexChanged += new System.EventHandler(this.DrpCategory_SelectedIndexChanged);
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCount.Location = new System.Drawing.Point(438, 24);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(74, 22);
            this.txtCount.TabIndex = 9;
            this.txtCount.Text = "1";
            // 
            // DtlShopping
            // 
            this.DtlShopping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtlShopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtlShopping.Location = new System.Drawing.Point(12, 68);
            this.DtlShopping.Name = "DtlShopping";
            this.DtlShopping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtlShopping.Size = new System.Drawing.Size(555, 196);
            this.DtlShopping.TabIndex = 10;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(477, 295);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 11;
            this.lblId.Visible = false;
            // 
            // btnShowShopping
            // 
            this.btnShowShopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowShopping.Location = new System.Drawing.Point(286, 283);
            this.btnShowShopping.Name = "btnShowShopping";
            this.btnShowShopping.Size = new System.Drawing.Size(133, 37);
            this.btnShowShopping.TabIndex = 7;
            this.btnShowShopping.Text = "Show Shopping";
            this.btnShowShopping.UseVisualStyleBackColor = true;
            this.btnShowShopping.Click += new System.EventHandler(this.btnShowShopping_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(579, 332);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.DtlShopping);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.DrpCategory);
            this.Controls.Add(this.btnShowShopping);
            this.Controls.Add(this.BtnShopping);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtlShopping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShopping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DrpCategory;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.DataGridView DtlShopping;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnShowShopping;
    }
}