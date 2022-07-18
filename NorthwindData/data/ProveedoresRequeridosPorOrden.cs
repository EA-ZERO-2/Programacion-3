using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleDataLibrary.Data
{
    [Keyless]
    public partial class ProveedoresRequeridosPorOrden
    {
        public int OrderId { get; set; }
        public int? CantidadProveedores { get; set; }
    }
}
