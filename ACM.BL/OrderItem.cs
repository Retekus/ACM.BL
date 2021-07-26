using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem() : this(0)
        {
        }
        public OrderItem(int inputOrderItemID)
        {
            orderItemID = inputOrderItemID;
        }
        public int orderItemID { get; private set; }
        public int productID { get; set; }
        public decimal? purchausePrise { get; set; }
        public int quantity { get; set; }

        public OrderItem Retrive(int orderItemID)
        {
            return new OrderItem();
        }

        public List<OrderItem> Retrive()
        {
            return new List<OrderItem>();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (quantity <= 0) isValid = false;
            if (productID <= 0) isValid = false;
            if (purchausePrise == null) isValid = false;

            return isValid;
        }

    }
}
