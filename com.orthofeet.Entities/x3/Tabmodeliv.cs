// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TABMODELIV", Schema = "TESTPROD")]
    [Index(nameof(Mdl0), Name = "TABMODELIV_TMD0", IsUnique = true)]
    public partial class Tabmodeliv
    {
        [Required]
        [Column("MDL_0")]
        [StringLength(5)]
        public string Mdl0 { get; set; }
        [Required]
        [Column("LANDESSHO_0")]
        [StringLength(60)]
        public string Landessho0 { get; set; }
        [Required]
        [Column("EECICT_0")]
        [StringLength(20)]
        public string Eecict0 { get; set; }
        [Column("EECLOC_0")]
        public short Eecloc0 { get; set; }
        [Column("EECTRN_0")]
        public short Eectrn0 { get; set; }
        [Required]
        [Column("REGION_0")]
        [StringLength(1)]
        public string Region0 { get; set; }
        [Required]
        [Column("PORT_0")]
        [StringLength(1)]
        public string Port0 { get; set; }
        [Required]
        [Column("AIRPORT_0")]
        [StringLength(1)]
        public string Airport0 { get; set; }
        [Required]
        [Column("GFY_0")]
        [StringLength(5)]
        public string Gfy0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}