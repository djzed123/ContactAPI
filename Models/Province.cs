using System;
using System.Collections.Generic;

namespace ContactAPI.Models
{
    public partial class Province
    {
        public Province()
        {
            People = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
