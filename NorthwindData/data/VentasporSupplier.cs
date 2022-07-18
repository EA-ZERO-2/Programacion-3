using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleDataLibrary.Data
{
    [Keyless]
    public partial class VentasporSupplier
    {
        public int SupplierId { get; set; }
        [StringLength(40)]
        public string ProductName { get; set; } = null!;
        [StringLength(40)]
        public string ShipperName { get; set; } = null!;
        public int OrderId { get; set; }
        [Column("CustomerID")]
        [StringLength(5)]
        public string? CustomerId { get; set; }
        [Column("anio")]
        public int? Anio { get; set; }
        public short Quantity { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public float Discount { get; set; }
        [Column(TypeName = "numeric(19, 2)")]
        public decimal? Total { get; set; }
    }
}
