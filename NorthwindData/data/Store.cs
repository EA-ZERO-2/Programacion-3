using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleDataLibrary.Data
{
    [Table("Store")]
    public partial class Store
    {
        [Key]
        [Column("StoreID")]
        public int StoreId { get; set; }
        [StringLength(30)]
        public string StoreName { get; set; } = null!;
        [StringLength(30)]
        public string Address1 { get; set; } = null!;
        [StringLength(30)]
        public string? Address2 { get; set; }
        [StringLength(25)]
        public string City { get; set; } = null!;
        [StringLength(8)]
        [Unicode(false)]
        public string PostCode { get; set; } = null!;
    }
}
