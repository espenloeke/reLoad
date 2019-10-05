using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Api.Order
{
    public class OrderRequest
    {
        public Guid OrderRequestId;

        public DateTime OrderValidFrom;
        public DateTime OrderValidTo;        

        public OrderRequestPickup Pickup;
        public OrderRequestDelivery Delivery;        

        public List<OrderRequestOrderItem> Items;        
    }
}
