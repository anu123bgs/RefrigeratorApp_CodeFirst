using RefrigeratorApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorApp
{
    public static class AppHelper
    {
        static Product product_ = new Product();
        static ProductContext dbContext_ = new ProductContext();
        public static List<ProductInfo> GetAllLiveProducts()
        {
            List<ProductInfo> productList = new List<ProductInfo>();
            DateTime today = DateTime.Now.Date;
            productList = (from p in dbContext_.products
                           join c in dbContext_.productTypes on p.ProductTypeId equals c.ProductTypeId
                           where p.ExpiryDate >= today
                           where p.Quantity > 0
                           select new ProductInfo
                           {
                               ProductName = c.ProductName,
                               Quantity = p.Quantity,
                               MeasUnit = c.MesUnit,
                               ExpiryDate = p.ExpiryDate
                           }).ToList();

            return productList;
        }
        public static void HandleProductExpiry()
        {
            List<ProductInfo> productList = GetAllLiveProducts();
            StringBuilder expiryMsg = new StringBuilder("Below Products are expiring soon. Please remove them before expiry. \n");
            StringBuilder expiredMsg = new StringBuilder("Below products are removed from stock because of expiry date. Please remove them from Fridge. \n");
            List<ProductInfo> expiringProductList = new List<ProductInfo>();
            bool productsExpiring = false;
            foreach (ProductInfo product in productList)
            {
                if (product != null)
                {
                    if (product.ExpiryDate <= DateTime.Now.AddDays(1))
                    {
                        expiryMsg.Append($"Product: {product.ProductName} ==> Expiry Date: {product.ExpiryDate.Date} \n");
                        productsExpiring = true;
                    }
                    if (product.ExpiryDate == DateTime.Now.Date)
                    {
                        expiredMsg.Append($"Product: {product.ProductName} ==> Expiry Date: {product.ExpiryDate.Date} \n");
                        expiringProductList.Add(product);
                    }
                }
            }
            if (productsExpiring)
                MessageBox.Show(expiryMsg.ToString(), "Products Expiring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (expiringProductList.Count() > 0)
            {
                RemoveExpiredProducts(expiringProductList);
                MessageBox.Show(expiredMsg.ToString(), "Removed Expired Products", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private static void RemoveExpiredProducts(List<ProductInfo> productList)
        {
            foreach (ProductInfo product in productList)
            {
                int productTypeId = AppHelper.GetProductId(product.ProductName);
                Product prod = dbContext_.products.Where(p => p.ProductTypeId == productTypeId)
                    .Where(p => p.ExpiryDate == product.ExpiryDate).FirstOrDefault();
                dbContext_.products.Remove(prod);
                dbContext_.SaveChanges();
                UpdateHistory(prod, product.Quantity, "Expired");
            }
        }
        public static int GetProductId(string productName)
        {
            return (from x in dbContext_.productTypes where x.ProductName == productName select x.ProductTypeId).First();
        }
        public static void UpdateHistory(Product product, double quantity, string action)
        {
            Products_log prod = new Products_log();
            prod.ProductTypeId = product.ProductTypeId;
            prod.Quantity = quantity;
            prod.AsOf = product.AsOf;
            prod.ExpiryDate = product.ExpiryDate;
            prod.Action = action.ToUpper();
            dbContext_.products_log.Add(prod);
            dbContext_.SaveChanges();
        }
        public static void ShowMessage(string msgType)
        {
            string message = string.Empty;
            switch (msgType)
            {
                case "Add":
                    message = "Select a product and enter quantity and then click Add";
                    break;
                case "Consume":
                    message = "Select a row from below grid, update consumed quantity and then click Consume";
                    break;
                case "CheckStock":
                    message = "Select a product and click Check Stock to check available quantity.";
                    break;
            }
            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
