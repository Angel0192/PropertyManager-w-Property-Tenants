using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyManager.Models
{
    public class Tenant
    {
        // 1. Make this nullable so the form doesn't require a full Property object
        public Property? Property { get; set; } 

        public int TenantID { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        // 2. Remove 'required' so the Edit form doesn't fail if these are missing
        public string? Email { get; set; }
        public string? PhoneNum { get; set; }

        public int PropertyID { get; set; }
    }
}