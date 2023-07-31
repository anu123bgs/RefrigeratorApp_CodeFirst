namespace RefrigeratorApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ProductType
    {
        [Key]
        public int ProductTypeId { get; set; }
        public string ProductName { get; set; }
        public string MesUnit { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Products_log> Products_log { get; set; }
    }
}
