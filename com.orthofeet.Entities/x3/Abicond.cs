// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ABICOND", Schema = "TESTPROD")]
    [Index(nameof(Cod0), Name = "ABICOND_AII0", IsUnique = true)]
    [Index(nameof(Ord0), nameof(Cod0), Name = "ABICOND_AII1", IsUnique = true)]
    [Index(nameof(Abm0), nameof(Codabf0), nameof(Cod0), Name = "ABICOND_AII2", IsUnique = true)]
    public partial class Abicond
    {
        [Required]
        [Column("COD_0")]
        [StringLength(10)]
        public string Cod0 { get; set; }
        [Column("ORD_0")]
        public short Ord0 { get; set; }
        [Required]
        [Column("ABM_0")]
        [StringLength(10)]
        public string Abm0 { get; set; }
        [Column("DES_0")]
        public int Des0 { get; set; }
        [Required]
        [Column("ACV_0")]
        [StringLength(5)]
        public string Acv0 { get; set; }
        [Required]
        [Column("CNDDEF_0")]
        [StringLength(250)]
        public string Cnddef0 { get; set; }
        [Required]
        [Column("CNDORA_0")]
        [StringLength(250)]
        public string Cndora0 { get; set; }
        [Required]
        [Column("CNDSQL_0")]
        [StringLength(250)]
        public string Cndsql0 { get; set; }
        [Column("TEX_0")]
        public int Tex0 { get; set; }
        [Required]
        [Column("CODABF_0")]
        [StringLength(10)]
        public string Codabf0 { get; set; }
        [Required]
        [Column("CODLNK_0")]
        [StringLength(10)]
        public string Codlnk0 { get; set; }
        [Required]
        [Column("EXPLNK_0")]
        [StringLength(80)]
        public string Explnk0 { get; set; }
        [Required]
        [Column("CODABF1_0")]
        [StringLength(10)]
        public string Codabf10 { get; set; }
        [Required]
        [Column("CODABF1_1")]
        [StringLength(10)]
        public string Codabf11 { get; set; }
        [Required]
        [Column("CODFLD1_0")]
        [StringLength(12)]
        public string Codfld10 { get; set; }
        [Required]
        [Column("CODFLD1_1")]
        [StringLength(12)]
        public string Codfld11 { get; set; }
        [Required]
        [Column("CODDIM1_0")]
        [StringLength(10)]
        public string Coddim10 { get; set; }
        [Required]
        [Column("CODDIM1_1")]
        [StringLength(10)]
        public string Coddim11 { get; set; }
        [Required]
        [Column("FLDDIM1_0")]
        [StringLength(12)]
        public string Flddim10 { get; set; }
        [Required]
        [Column("FLDDIM1_1")]
        [StringLength(12)]
        public string Flddim11 { get; set; }
        [Required]
        [Column("CODDIM2_0")]
        [StringLength(10)]
        public string Coddim20 { get; set; }
        [Required]
        [Column("CODDIM2_1")]
        [StringLength(10)]
        public string Coddim21 { get; set; }
        [Required]
        [Column("FLDDIM2_0")]
        [StringLength(12)]
        public string Flddim20 { get; set; }
        [Required]
        [Column("FLDDIM2_1")]
        [StringLength(12)]
        public string Flddim21 { get; set; }
        [Required]
        [Column("CODDIM3_0")]
        [StringLength(10)]
        public string Coddim30 { get; set; }
        [Required]
        [Column("CODDIM3_1")]
        [StringLength(10)]
        public string Coddim31 { get; set; }
        [Required]
        [Column("FLDDIM3_0")]
        [StringLength(12)]
        public string Flddim30 { get; set; }
        [Required]
        [Column("FLDDIM3_1")]
        [StringLength(12)]
        public string Flddim31 { get; set; }
        [Required]
        [Column("CODDIM4_0")]
        [StringLength(10)]
        public string Coddim40 { get; set; }
        [Required]
        [Column("CODDIM4_1")]
        [StringLength(10)]
        public string Coddim41 { get; set; }
        [Required]
        [Column("FLDDIM4_0")]
        [StringLength(12)]
        public string Flddim40 { get; set; }
        [Required]
        [Column("FLDDIM4_1")]
        [StringLength(12)]
        public string Flddim41 { get; set; }
        [Required]
        [Column("CODDIM5_0")]
        [StringLength(10)]
        public string Coddim50 { get; set; }
        [Required]
        [Column("CODDIM5_1")]
        [StringLength(10)]
        public string Coddim51 { get; set; }
        [Required]
        [Column("FLDDIM5_0")]
        [StringLength(12)]
        public string Flddim50 { get; set; }
        [Required]
        [Column("FLDDIM5_1")]
        [StringLength(12)]
        public string Flddim51 { get; set; }
        [Required]
        [Column("CODDIM6_0")]
        [StringLength(10)]
        public string Coddim60 { get; set; }
        [Required]
        [Column("CODDIM6_1")]
        [StringLength(10)]
        public string Coddim61 { get; set; }
        [Required]
        [Column("FLDDIM6_0")]
        [StringLength(12)]
        public string Flddim60 { get; set; }
        [Required]
        [Column("FLDDIM6_1")]
        [StringLength(12)]
        public string Flddim61 { get; set; }
        [Required]
        [Column("CODDIM7_0")]
        [StringLength(10)]
        public string Coddim70 { get; set; }
        [Required]
        [Column("CODDIM7_1")]
        [StringLength(10)]
        public string Coddim71 { get; set; }
        [Required]
        [Column("FLDDIM7_0")]
        [StringLength(12)]
        public string Flddim70 { get; set; }
        [Required]
        [Column("FLDDIM7_1")]
        [StringLength(12)]
        public string Flddim71 { get; set; }
        [Required]
        [Column("CODDIM8_0")]
        [StringLength(10)]
        public string Coddim80 { get; set; }
        [Required]
        [Column("CODDIM8_1")]
        [StringLength(10)]
        public string Coddim81 { get; set; }
        [Required]
        [Column("FLDDIM8_0")]
        [StringLength(12)]
        public string Flddim80 { get; set; }
        [Required]
        [Column("FLDDIM8_1")]
        [StringLength(12)]
        public string Flddim81 { get; set; }
        [Required]
        [Column("CODDIM9_0")]
        [StringLength(10)]
        public string Coddim90 { get; set; }
        [Required]
        [Column("CODDIM9_1")]
        [StringLength(10)]
        public string Coddim91 { get; set; }
        [Required]
        [Column("FLDDIM9_0")]
        [StringLength(12)]
        public string Flddim90 { get; set; }
        [Required]
        [Column("FLDDIM9_1")]
        [StringLength(12)]
        public string Flddim91 { get; set; }
        [Required]
        [Column("TYPOPT_0")]
        [StringLength(15)]
        public string Typopt0 { get; set; }
        [Required]
        [Column("TYPOPT_1")]
        [StringLength(15)]
        public string Typopt1 { get; set; }
        [Required]
        [Column("INTEVAL_0")]
        [StringLength(60)]
        public string Inteval0 { get; set; }
        [Required]
        [Column("INTVALTEX_0")]
        [StringLength(60)]
        public string Intvaltex0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}