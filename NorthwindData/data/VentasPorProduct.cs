using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleDataLibrary.Data
{
    [Keyless]
    public partial class VentasPorProduct
    {
        public int ProductId { get; set; }
        [StringLength(40)]
        public string ProductName { get; set; } = null!;
        public int? CategoryId { get; set; }
        public int OrderId { get; set; }
        [StringLength(5)]
        public string? CustomerId { get; set; }
        public int? Anio { get; set; }
        public short Quantity { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public float Discount { get; set; }
        [Column(TypeName = "numeric(19, 2)")]
        public decimal? Total { get; set; }
    }
}
