using System.ComponentModel.DataAnnotations;

namespace stock_n_shopping.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int CartID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; }
    }
}
