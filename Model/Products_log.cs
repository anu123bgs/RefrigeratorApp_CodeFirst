namespace RefrigeratorApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Products_log
    {
        [Key]
        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }
        public double Quantity { get; set; }
        public System.DateTime AsOf { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public string Action { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
