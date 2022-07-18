using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleDataLibrary.Data
{
    [Keyless]
    public partial class TotalDeOrdenesPorProveedor
    {
        [Column("Nombre Proveedor")]
        [StringLength(40)]
        public string NombreProveedor { get; set; } = null!;
        [Column("Total Ordenes")]
        public int? TotalOrdenes { get; set; }
    }
}
