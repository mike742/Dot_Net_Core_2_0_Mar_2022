using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Core_2_0_Mar_2022
{
    [Serializable()]
    public class ProductDto : ISerializable
    {
        public string SupplierIds { get; set; }
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        //public decimal? StandardCost { get; set; }
        //public decimal ListPrice { get; set; }
        //public int? ReorderLevel { get; set; }
        //public int? TargetLevel { get; set; }
        //public string QuantityPerUnit { get; set; }
        //public bool Discontinued { get; set; }
        //public int? MinimumReorderQuantity { get; set; }
        //public string Category { get; set; }
        //public byte[] Attachments { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("SupplierIds", SupplierIds);
            info.AddValue("Id", Id);
            info.AddValue("ProductCode", ProductCode);
            info.AddValue("ProductName", ProductName);
            info.AddValue("Description", Description);
        }
        public ProductDto() { }
        public ProductDto(SerializationInfo info, StreamingContext context)
        {
            SupplierIds = (string)info.GetValue("SupplierIds", typeof(string));
            Id = (int)info.GetValue("Id", typeof(int));
            ProductCode = (string)info.GetValue("ProductCode", typeof(string));
            ProductName = (string)info.GetValue("ProductName", typeof(string));
            Description = (string)info.GetValue("Description", typeof(string));
        }
    }
}
