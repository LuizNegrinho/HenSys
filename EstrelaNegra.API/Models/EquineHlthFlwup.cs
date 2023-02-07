﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EstrelaNegra.API.Models
{
    [Table("EQUINE_HLTH_FLWUP")]
    public partial class EquineHlthFlwup
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("HORSE_ID")]
        public int? HorseId { get; set; }
        [Column("VERM_IVE", TypeName = "datetime")]
        public DateTime? VermIve { get; set; }
        [Column("VERM_FEB", TypeName = "datetime")]
        public DateTime? VermFeb { get; set; }
        [Column("DORAMECTINA", TypeName = "datetime")]
        public DateTime? Doramectina { get; set; }
        [Column("POURON", TypeName = "datetime")]
        public DateTime? Pouron { get; set; }
        [Column("TRIEQUI", TypeName = "datetime")]
        public DateTime? Triequi { get; set; }
        [Column("LEX8", TypeName = "datetime")]
        public DateTime? Lex8 { get; set; }
        [Column("ENCEFALOGEN", TypeName = "datetime")]
        public DateTime? Encefalogen { get; set; }
        [Column("GARROTILHO", TypeName = "datetime")]
        public DateTime? Garrotilho { get; set; }
        [Column("RAIVA", TypeName = "datetime")]
        public DateTime? Raiva { get; set; }
        [Column("HERPES", TypeName = "datetime")]
        public DateTime? Herpes { get; set; }
        [Column("LEPTO", TypeName = "datetime")]
        public DateTime? Lepto { get; set; }

        [ForeignKey("HorseId")]
        [InverseProperty("EquineHlthFlwup")]
        public virtual Equine Horse { get; set; }
    }
}