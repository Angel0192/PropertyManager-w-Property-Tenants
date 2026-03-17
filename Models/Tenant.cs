using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyManager.Models
{
    public class Tenant
    {
        public Property Property { get; set; } = null!;

        // Tenant ID
        public int TenantID{get; set;}

        // First Name
        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName{get; set;}

        // Last Name
        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName{get; set;}

        // Email
        [EmailAddress]
        public required string Email{get; set;}

        // Phone Number
        public required string PhoneNum{get; set;}

        // Property ID (FK)
        public int PropertyID{get; set;}
    }
}