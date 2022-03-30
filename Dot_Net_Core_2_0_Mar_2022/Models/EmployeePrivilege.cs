using System;
using System.Collections.Generic;

#nullable disable

namespace Dot_Net_Core_2_0_Mar_2022.Models
{
    public partial class EmployeePrivilege
    {
        public int EmployeeId { get; set; }
        public int PrivilegeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Privilege Privilege { get; set; }
    }
}
