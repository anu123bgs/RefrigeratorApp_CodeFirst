using System;
using System.Collections.Generic;
using System.Text;

namespace RefrigeratorApp.Model
{
    public class ProductInfo
    {
        public string ProductName { get; set; }
        public double Quantity { get; set; }
        public string MeasUnit { get; set; }
        public System.DateTime AddedOn { get; set; }
        public System.DateTime ExpiryDate { get; set; }
    }
    public class ProductInfo_log
    {
        public string ProductName { get; set; }
        public double Quantity { get; set; }
        public string Action { get; set; }
        public System.DateTime AsOf { get; set; }
        public System.DateTime ExpiryDate { get; set; }
    }
}
