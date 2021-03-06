// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ORDOOPAR", Schema = "TESTPROD")]
    [Index(nameof(Id0), Name = "ORDOOPAR_ORO0", IsUnique = true)]
    public partial class Ordoopar
    {
        [Required]
        [Column("ID_0")]
        [StringLength(10)]
        public string Id0 { get; set; }
        [Required]
        [Column("INTIT_0")]
        [StringLength(30)]
        public string Intit0 { get; set; }
        [Required]
        [Column("OPEPIT_0")]
        [StringLength(10)]
        public string Opepit0 { get; set; }
        [Required]
        [Column("ITMPIT_0")]
        [StringLength(10)]
        public string Itmpit0 { get; set; }
        [Required]
        [Column("BPCPIT_0")]
        [StringLength(10)]
        public string Bpcpit0 { get; set; }
        [Required]
        [Column("PJTPIT_0")]
        [StringLength(10)]
        public string Pjtpit0 { get; set; }
        [Required]
        [Column("ORDPIT_0")]
        [StringLength(10)]
        public string Ordpit0 { get; set; }
        [Required]
        [Column("MWSPIT_0")]
        [StringLength(10)]
        public string Mwspit0 { get; set; }
        [Required]
        [Column("TWCPIT_0")]
        [StringLength(10)]
        public string Twcpit0 { get; set; }
        [Required]
        [Column("WSTPIT_0")]
        [StringLength(10)]
        public string Wstpit0 { get; set; }
        [Required]
        [Column("RPLPIT_0")]
        [StringLength(10)]
        public string Rplpit0 { get; set; }
        [Required]
        [Column("RSSPIT_0")]
        [StringLength(10)]
        public string Rsspit0 { get; set; }
        [Required]
        [Column("BOMPIT_0")]
        [StringLength(10)]
        public string Bompit0 { get; set; }
        [Column("GRUBOMFLG_0")]
        public byte Grubomflg0 { get; set; }
        [Required]
        [Column("POFPIT_0")]
        [StringLength(10)]
        public string Pofpit0 { get; set; }
        [Required]
        [Column("STOPIT_0")]
        [StringLength(10)]
        public string Stopit0 { get; set; }
        [Column("WOMAR_0")]
        public short Womar0 { get; set; }
        [Required]
        [Column("DRTRCP_0")]
        [StringLength(250)]
        public string Drtrcp0 { get; set; }
        [Required]
        [Column("DRTSTO_0")]
        [StringLength(250)]
        public string Drtsto0 { get; set; }
        [Required]
        [Column("DRTISS_0")]
        [StringLength(250)]
        public string Drtiss0 { get; set; }
        [Column("ORTFLG_0")]
        public byte Ortflg0 { get; set; }
        [Column("ORTPLNFLG_0")]
        public byte Ortplnflg0 { get; set; }
        [Required]
        [Column("ORTDRTBIN_0")]
        [StringLength(250)]
        public string Ortdrtbin0 { get; set; }
        [Required]
        [Column("ORTCLIBIN_0")]
        [StringLength(250)]
        public string Ortclibin0 { get; set; }
        [Required]
        [Column("ORTENM_0")]
        [StringLength(50)]
        public string Ortenm0 { get; set; }
        [Column("ORTLTI_0")]
        public short Ortlti0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}