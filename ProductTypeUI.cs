using RefrigeratorApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RefrigeratorApp
{
    public partial class ProductTypeUI : Form
    {
        ProductType productType_ = new ProductType();
        ProductContext dbContext_ = new ProductContext();
        public ProductTypeUI()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            productType_.ProductName = tbName.Text;
            productType_.MesUnit = tbMeasUnit.Text;
            dbContext_.productTypes.Add(productType_);
            dbContext_.SaveChanges();
            this.Close();
        }
    }
}
