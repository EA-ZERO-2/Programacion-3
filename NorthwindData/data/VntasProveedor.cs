using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleDataLibrary.Data
{
    [Keyless]
    [Table("VntasProveedor")]
    public partial class VntasProveedor
    {
        [StringLength(40)]
        public string CompanyName { get; set; } = null!;
        [Column("total", TypeName = "numeric(19, 2)")]
        public decimal? Total { get; set; }
        [Column("año")]
        public int? Año { get; set; }
    }
}
