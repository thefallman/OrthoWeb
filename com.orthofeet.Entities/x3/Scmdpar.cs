// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SCMDPAR", Schema = "TESTPROD")]
    [Index(nameof(Id0), Name = "SCMDPAR_SDP0", IsUnique = true)]
    public partial class Scmdpar
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
        [Column("ITMPIT_0")]
        [StringLength(10)]
        public string Itmpit0 { get; set; }
        [Required]
        [Column("ITMFOR_0")]
        [StringLength(3)]
        public string Itmfor0 { get; set; }
        [Required]
        [Column("BPCPIT_0")]
        [StringLength(10)]
        public string Bpcpit0 { get; set; }
        [Required]
        [Column("FCYPIT_0")]
        [StringLength(10)]
        public string Fcypit0 { get; set; }
        [Required]
        [Column("ITMFCYPIT_0")]
        [StringLength(10)]
        public string Itmfcypit0 { get; set; }
        [Column("SOHGRU_0")]
        public byte Sohgru0 { get; set; }
        [Required]
        [Column("SOHFOR_0")]
        [StringLength(3)]
        public string Sohfor0 { get; set; }
        [Required]
        [Column("HISSOHPIT_0")]
        [StringLength(10)]
        public string Hissohpit0 { get; set; }
        [Column("HISSOHFLG_0")]
        public byte Hissohflg0 { get; set; }
        [Column("HISSDHFLG_0")]
        public byte Hissdhflg0 { get; set; }
        [Required]
        [Column("SDHFOR_0")]
        [StringLength(3)]
        public string Sdhfor0 { get; set; }
        [Required]
        [Column("SOHPIT_0")]
        [StringLength(10)]
        public string Sohpit0 { get; set; }
        [Column("SOSRAZFLG_0")]
        public byte Sosrazflg0 { get; set; }
        [Column("SOSDLTFLG_0")]
        public byte Sosdltflg0 { get; set; }
        [Required]
        [Column("SOSPIT_0")]
        [StringLength(10)]
        public string Sospit0 { get; set; }
        [Required]
        [Column("DRTRCP_0")]
        [StringLength(250)]
        public string Drtrcp0 { get; set; }
        [Required]
        [Column("DRTISS_0")]
        [StringLength(250)]
        public string Drtiss0 { get; set; }
        [Required]
        [Column("DRTSTO_0")]
        [StringLength(250)]
        public string Drtsto0 { get; set; }
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