using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable disable

namespace BlazorWebasmHosted.Shared
{
    public partial class Classyear
    {
        public Classyear()
        {
            Students = new HashSet<Student>();
        }

        public int ClassId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int Year { get; set; }
        public string Classname { get; set; }

        [JsonIgnore]
        public virtual ICollection<Student> Students { get; set; }
    }
}
