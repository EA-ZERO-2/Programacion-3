using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleDataLibrary.Data
{
    [Keyless]
    public partial class VorderDetailsSupplierd
    {
        public int? Yr { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int? SupplierId { get; set; }
        [StringLength(40)]
        public string CompanyName { get; set; } = null!;
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float PorcentajeDiscount { get; set; }
        [Column(TypeName = "money")]
        public decimal? Subtotal { get; set; }
    }
}
