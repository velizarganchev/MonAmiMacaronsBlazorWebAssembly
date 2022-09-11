using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonAmiMacaronsBlazorWebAssembly.Shared
{
    public class OrderDetailsProductResponse
    {
        public int ProductId { get; set; }
        public string Title { get; set; } = String.Empty;
        public string ProductType { get; set; } = String.Empty ;
        public string ImageUrl { get; set; } = String.Empty;    
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
