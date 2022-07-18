using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleDataLibrary.Data
{
    [Keyless]
    public partial class Ordersbyemployeeyear
    {
        [Column("employeeid")]
        public int Employeeid { get; set; }
        [StringLength(31)]
        public string Nombre { get; set; } = null!;
        public int? Anio { get; set; }
        [Column("total", TypeName = "numeric(8, 2)")]
        public decimal? Total { get; set; }
    }
}
