namespace RefrigeratorApp
{
    partial class RefrigeratorUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbProducts = new System.Windows.Forms.ComboBox();
            lblProducts = new System.Windows.Forms.Label();
            lblQuantity = new System.Windows.Forms.Label();
            tbQuantity = new System.Windows.Forms.TextBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            lblExpiry = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            btnAdd = new System.Windows.Forms.Button();
            btnConsume = new System.Windows.Forms.Button();
            btnStockCheck = new System.Windows.Forms.Button();
            btnCheckHistory = new System.Windows.Forms.Button();
            btnAddProdType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbProducts
            // 
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new System.Drawing.Point(99, 57);
            cbProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new System.Drawing.Size(140, 23);
            cbProducts.TabIndex = 0;
            cbProducts.Text = "Select Product";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Location = new System.Drawing.Point(14, 60);
            lblProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new System.Drawing.Size(54, 15);
            lblProducts.TabIndex = 1;
            lblProducts.Text = "Products";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new System.Drawing.Point(14, 112);
            lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new System.Drawing.Size(53, 15);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity";
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new System.Drawing.Point(99, 108);
            tbQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new System.Drawing.Size(140, 23);
            tbQuantity.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(99, 158);
            dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(209, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // lblExpiry
            // 
            lblExpiry.AutoSize = true;
            lblExpiry.Location = new System.Drawing.Point(14, 165);
            lblExpiry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExpiry.Name = "lblExpiry";
            lblExpiry.Size = new System.Drawing.Size(63, 15);
            lblExpiry.TabIndex = 6;
            lblExpiry.Text = "ExpiryDate";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(18, 243);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(587, 250);
            dataGridView1.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(364, 68);
            btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(114, 42);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnConsume
            // 
            btnConsume.Location = new System.Drawing.Point(364, 126);
            btnConsume.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnConsume.Name = "btnConsume";
            btnConsume.Size = new System.Drawing.Size(114, 42);
            btnConsume.TabIndex = 4;
            btnConsume.Text = "Consume Product";
            btnConsume.UseVisualStyleBackColor = true;
            btnConsume.Click += btnConsume_Click;
            // 
            // btnStockCheck
            // 
            btnStockCheck.Location = new System.Drawing.Point(490, 69);
            btnStockCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnStockCheck.Name = "btnStockCheck";
            btnStockCheck.Size = new System.Drawing.Size(114, 42);
            btnStockCheck.TabIndex = 5;
            btnStockCheck.Text = "Check Stock";
            btnStockCheck.UseVisualStyleBackColor = true;
            btnStockCheck.Click += btnStockCheck_Click;
            // 
            // btnCheckHistory
            // 
            btnCheckHistory.Location = new System.Drawing.Point(490, 126);
            btnCheckHistory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCheckHistory.Name = "btnCheckHistory";
            btnCheckHistory.Size = new System.Drawing.Size(114, 42);
            btnCheckHistory.TabIndex = 6;
            btnCheckHistory.Text = "Check History";
            btnCheckHistory.UseVisualStyleBackColor = true;
            btnCheckHistory.Click += btnCheckHistory_Click;
            // 
            // btnAddProdType
            // 
            btnAddProdType.Location = new System.Drawing.Point(429, 184);
            btnAddProdType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddProdType.Name = "btnAddProdType";
            btnAddProdType.Size = new System.Drawing.Size(114, 42);
            btnAddProdType.TabIndex = 8;
            btnAddProdType.Text = "Add New Product Type";
            btnAddProdType.UseVisualStyleBackColor = true;
            btnAddProdType.Click += btnAddProdType_Click;
            // 
            // RefrigeratorUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(636, 519);
            Controls.Add(btnAddProdType);
            Controls.Add(btnCheckHistory);
            Controls.Add(btnStockCheck);
            Controls.Add(btnConsume);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(lblExpiry);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(lblProducts);
            Controls.Add(cbProducts);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "RefrigeratorUI";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "RefrigeratorApp";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnConsume;
        private System.Windows.Forms.Button btnStockCheck;
        private System.Windows.Forms.Button btnCheckHistory;
        private System.Windows.Forms.Button btnAddProdType;
    }
}
