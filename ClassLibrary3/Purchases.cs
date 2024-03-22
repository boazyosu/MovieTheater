using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieModels
{
    public class Purchases
    {
        public int PurchaseId { get; set; }
        public string PurchaseUser { get; set; }
        public string PurchaseDate { get; set; }
        public int TotalPayment { get; set; }
        public bool PayedFor { get; set; }
        public string PurchaseMov { get; set; }

    }
}
