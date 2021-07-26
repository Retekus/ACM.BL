using Retekus.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order : EntityBase, ILoggable
    {
        public Order()
        {
        }
        public Order(int inputOrderID)
        {
            orderID = inputOrderID;
            orderItems = new List<OrderItem>(); 
        }

        public int customerID { get; set; }
        public int orderID { get; private set; }
        public int shippingAdressID { get; set; }
        public List<OrderItem> orderItems { get; set; }
        public DateTimeOffset? orderDate { get; set; }
        public override string ToString() => $"{orderID}";


        public Order Retrive(int orderID)
        {
            return new Order();
        }

        public List<Order> Retrive()
        {
            return new List<Order>();
        }

        public bool Save()
        {
            return true;
        }

        public override bool Validate()
        {
            var isValid = false;

            if (orderDate == null) isValid = false;

            return isValid;
        }

        public string log() =>
                  $" {orderID} Date: {this.orderDate.Value.Date} Status: {this. entityState.ToString()}";
    }
}
