using System;
using System.Collections.Generic;

namespace ContactAPI.Models
{
    public partial class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? JobTitle { get; set; }
        public int? FkCompanyId { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public int? FkProvinceId { get; set; }
        public string? PostalCode { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Comments { get; set; }
        public DateTime? DateLastContact { get; set; }

        public virtual Company? FkCompany { get; set; }
        public virtual Province? FkProvince { get; set; }
    }
}
