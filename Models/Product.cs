using System.ComponentModel.DataAnnotations;

namespace stock_n_shopping.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockQuantity { get; set; }
        public int? CategoryID { get; set; }
    }
}
