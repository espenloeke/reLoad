using Entities.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Model
{
    public class Order
    {
        public int Id;
        public string CustomerId;
        public Guid OrderRequestId;

        public DateTime OrderedDate;
        
        public DateTime OrderValidFrom;
        public DateTime OrderValidTo;

        public Customer Customer;

        public Pickup Pickup;
        public Delivery Delivery;

        public Transporter Transporter;
        
        public List<OrderItem> Items;

        protected Order() { }

        public Order CreateFromOrderRequest(OrderRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
