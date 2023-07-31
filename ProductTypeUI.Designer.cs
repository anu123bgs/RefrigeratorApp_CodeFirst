namespace RefrigeratorApp
{
    partial class ProductTypeUI
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
            btnAdd = new System.Windows.Forms.Button();
            tbName = new System.Windows.Forms.TextBox();
            lblName = new System.Windows.Forms.Label();
            tbMeasUnit = new System.Windows.Forms.TextBox();
            lblMeasUnit = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(95, 179);
            btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(114, 42);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Save";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbName
            // 
            tbName.Location = new System.Drawing.Point(111, 64);
            tbName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbName.Name = "tbName";
            tbName.Size = new System.Drawing.Size(140, 23);
            tbName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(19, 67);
            lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(84, 15);
            lblName.TabIndex = 9;
            lblName.Text = "Product Name";
            // 
            // tbMeasUnit
            // 
            tbMeasUnit.Location = new System.Drawing.Point(111, 119);
            tbMeasUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbMeasUnit.Name = "tbMeasUnit";
            tbMeasUnit.Size = new System.Drawing.Size(140, 23);
            tbMeasUnit.TabIndex = 2;
            // 
            // lblMeasUnit
            // 
            lblMeasUnit.AutoSize = true;
            lblMeasUnit.Location = new System.Drawing.Point(19, 122);
            lblMeasUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMeasUnit.Name = "lblMeasUnit";
            lblMeasUnit.Size = new System.Drawing.Size(63, 15);
            lblMeasUnit.TabIndex = 12;
            lblMeasUnit.Text = "Meas. Unit";
            // 
            // ProductTypeUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(354, 297);
            Controls.Add(tbMeasUnit);
            Controls.Add(lblMeasUnit);
            Controls.Add(btnAdd);
            Controls.Add(tbName);
            Controls.Add(lblName);
            Name = "ProductTypeUI";
            Text = "Add New Product Types";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbMeasUnit;
        private System.Windows.Forms.Label lblMeasUnit;
    }
}