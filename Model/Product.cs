namespace RefrigeratorApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Product
    {
        [Key]
        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }
        public double Quantity { get; set; }
        public System.DateTime AsOf { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public ProductType ProductType { get; set; }
    }
}
