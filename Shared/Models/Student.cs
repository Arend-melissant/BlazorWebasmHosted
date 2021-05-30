using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorWebasmHosted.Shared
{
    public partial class Student
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Dob { get; set; }
        public int ClassId { get; set; }
        public int StudentStatus { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        public virtual Classyear Class { get; set; }
    }
}
