using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleDataLibrary.Data
{
    [Keyless]
    public partial class PivoteDeTotaleVenta
    {
        [Column("CategoryID")]
        public int? CategoryId { get; set; }
        [StringLength(40)]
        public string ProductName { get; set; } = null!;
        [Column("1996", TypeName = "numeric(38, 2)")]
        public decimal? _1996 { get; set; }
        [Column("1997", TypeName = "numeric(38, 2)")]
        public decimal? _1997 { get; set; }
        [Column("1998", TypeName = "numeric(38, 2)")]
        public decimal? _1998 { get; set; }
    }
}
