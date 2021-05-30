using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorWebasmHosted.Server
{
    public partial class SchemaMigration
    {
        public long Version { get; set; }
        public bool Dirty { get; set; }
    }
}
