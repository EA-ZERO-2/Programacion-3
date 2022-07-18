using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleDataLibrary.Data
{
    [Keyless]
    public partial class VentasAnioEmpleado
    {
        public int EmployeeId { get; set; }
        [StringLength(31)]
        public string Nombre { get; set; } = null!;
        public int? Anio { get; set; }
        [Column(TypeName = "numeric(38, 2)")]
        public decimal? SubTotal { get; set; }
    }
}
