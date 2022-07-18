using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleDataLibrary.Data
{
    [Keyless]
    public partial class Ventascategorium
    {
        [Column("categoryname")]
        [StringLength(15)]
        public string Categoryname { get; set; } = null!;
        [Column("año")]
        public int? Año { get; set; }
        [Column("total", TypeName = "money")]
        public decimal? Total { get; set; }
    }
}
