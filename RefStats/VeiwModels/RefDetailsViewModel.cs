using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefStats.VeiwModels
{
    public class RefDetailsViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RefNumber { get; set; }
        public string BirthDate { get; set; }
        public string Category { get; set; }
        public string Distrikt { get; set; }
        public string StreetAddress { get; set; }
        public string Zipcode { get; set; }
        public string County { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
    }
}
