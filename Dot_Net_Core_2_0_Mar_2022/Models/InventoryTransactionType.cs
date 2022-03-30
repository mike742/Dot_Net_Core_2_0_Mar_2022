using System;
using System.Collections.Generic;

#nullable disable

namespace Dot_Net_Core_2_0_Mar_2022.Models
{
    public partial class InventoryTransactionType
    {
        public InventoryTransactionType()
        {
            InventoryTransactions = new HashSet<InventoryTransaction>();
        }

        public sbyte Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; }
    }
}
