using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleDataLibrary.Data
{
    [Keyless]
    public partial class OrdenConProducto
    {
        public int IdProducto { get; set; }
        [StringLength(40)]
        public string ProductName { get; set; } = null!;
        public int IdOrden { get; set; }
    }
}
