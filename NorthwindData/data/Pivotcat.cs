using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleDataLibrary.Data
{
    [Keyless]
    [Table("pivotcat")]
    public partial class Pivotcat
    {
        public int? CategoryId { get; set; }
        [Column("1996")]
        public int? _1996 { get; set; }
        [Column("1997")]
        public int? _1997 { get; set; }
        [Column("1998")]
        public int? _1998 { get; set; }
    }
}
