using System;
using System.Collections.Generic;

#nullable disable

namespace Dot_Net_Core_2_0_Mar_2022.Models
{
    public partial class Privilege
    {
        public Privilege()
        {
            EmployeePrivileges = new HashSet<EmployeePrivilege>();
        }

        public int Id { get; set; }
        public string PrivilegeName { get; set; }

        public virtual ICollection<EmployeePrivilege> EmployeePrivileges { get; set; }
    }
}
