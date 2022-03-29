using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Core_2_0_Mar_2022
{
    [Serializable()]
    public class Employee : ISerializable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double? Salary { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("FirstName", FirstName);
            info.AddValue("LastName", LastName);
            info.AddValue("Salary", Salary);
        }
        public Employee() { }

        public Employee(SerializationInfo info, StreamingContext context)
        {
            Id = (int)info.GetValue("Id", typeof(int));
            FirstName = (string)info.GetValue("FirstName", typeof(string));
            LastName = (string)info.GetValue("LastName", typeof(string));
            Salary = (double)info.GetValue("Salary", typeof(double));
        }

        public override string ToString()
        {
            return $"{Id}: {FirstName} {LastName} - ${Salary}";

        }
    }
}
