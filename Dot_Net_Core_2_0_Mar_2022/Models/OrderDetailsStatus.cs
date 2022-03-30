using System;
using System.Collections.Generic;

#nullable disable

namespace Dot_Net_Core_2_0_Mar_2022.Models
{
    public partial class OrderDetailsStatus
    {
        public OrderDetailsStatus()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
