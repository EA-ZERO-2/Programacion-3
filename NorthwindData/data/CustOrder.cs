using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleDataLibrary.Data
{
    [Keyless]
    public partial class CustOrder
    {
        [StringLength(5)]
        public string? CustomerId { get; set; }
        [Column("ordermonth")]
        public int? Ordermonth { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
    }
}
