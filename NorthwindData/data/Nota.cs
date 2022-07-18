using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleDataLibrary.Data
{
    [Keyless]
    [Table("NOTAS")]
    public partial class Nota
    {
        [Column("GradoID")]
        [StringLength(50)]
        [Unicode(false)]
        public string GradoId { get; set; } = null!;
        [Column("Asignatura_ID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? AsignaturaId { get; set; }
        [Column("IDAlumno")]
        [StringLength(50)]
        [Unicode(false)]
        public string Idalumno { get; set; } = null!;
        [Column("CAT_ID")]
        [Unicode(false)]
        public string CatId { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime FechaT1 { get; set; }
        public int? Trimestre1 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string EstadoT1 { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime FechaT2 { get; set; }
        public int? Trimestre2 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string EstadoT2 { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime FechaT3 { get; set; }
        public int? Trimestre3 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string EstadoT3 { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime FechaT4 { get; set; }
        public int? Trimestre4 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string EstadoT4 { get; set; } = null!;
        [Column("NOTAFINAL")]
        public double? Notafinal { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Estado { get; set; } = null!;
    }
}
