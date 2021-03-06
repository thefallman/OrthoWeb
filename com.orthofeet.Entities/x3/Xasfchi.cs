// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("XASFCHIS", Schema = "TESTPROD")]
    [Index(nameof(Empnum0), nameof(Sfctyp0), nameof(Vcrnum0), nameof(Sfcseq0), nameof(Hisseq0), Name = "XASFCHIS_XAJ0", IsUnique = true)]
    [Index(nameof(Vcrnum0), nameof(Openum0), Name = "XASFCHIS_XAJ1")]
    public partial class Xasfchi
    {
        [Column("EMPNUM_0")]
        public short Empnum0 { get; set; }
        [Column("STRDAT_0", TypeName = "datetime")]
        public DateTime Strdat0 { get; set; }
        [Required]
        [Column("STRTIM_0")]
        [StringLength(8)]
        public string Strtim0 { get; set; }
        [Column("ENDDAT_0", TypeName = "datetime")]
        public DateTime Enddat0 { get; set; }
        [Required]
        [Column("ENDTIM_0")]
        [StringLength(8)]
        public string Endtim0 { get; set; }
        [Column("ASTRDAT_0", TypeName = "datetime")]
        public DateTime Astrdat0 { get; set; }
        [Required]
        [Column("ASTRTIM_0")]
        [StringLength(5)]
        public string Astrtim0 { get; set; }
        [Column("AENDDAT_0", TypeName = "datetime")]
        public DateTime Aenddat0 { get; set; }
        [Required]
        [Column("AENDTIM_0")]
        [StringLength(5)]
        public string Aendtim0 { get; set; }
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Column("SFCSEQ_0")]
        public int Sfcseq0 { get; set; }
        [Column("HISSEQ_0")]
        public int Hisseq0 { get; set; }
        [Column("SFCTYP_0")]
        public byte Sfctyp0 { get; set; }
        [Column("OPENUM_0")]
        public short Openum0 { get; set; }
        [Column("HOUR_0", TypeName = "numeric(14, 3)")]
        public decimal Hour0 { get; set; }
        [Column("MINUTE_0", TypeName = "numeric(14, 3)")]
        public decimal Minute0 { get; set; }
        [Column("CPLQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Cplqty0 { get; set; }
        [Column("REJCPLQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Rejcplqty0 { get; set; }
        [Required]
        [Column("OPEUOM_0")]
        [StringLength(3)]
        public string Opeuom0 { get; set; }
        [Required]
        [Column("WCLOSE_0")]
        [StringLength(1)]
        public string Wclose0 { get; set; }
        [Required]
        [Column("INDREF_0")]
        [StringLength(3)]
        public string Indref0 { get; set; }
        [Column("TEAM_0")]
        public short Team0 { get; set; }
        [Column("SHIDAT_0", TypeName = "datetime")]
        public DateTime Shidat0 { get; set; }
        [Column("NUMMACH_0")]
        public int Nummach0 { get; set; }
        [Column("NUMJOBS_0")]
        public int Numjobs0 { get; set; }
        [Required]
        [Column("CPLLAB_0")]
        [StringLength(8)]
        public string Cpllab0 { get; set; }
        [Required]
        [Column("CPLWST_0")]
        [StringLength(8)]
        public string Cplwst0 { get; set; }
        [Column("SCANUM_0")]
        public short Scanum0 { get; set; }
        [Column("EXCFLG_0")]
        public int Excflg0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREFUN_0")]
        [StringLength(10)]
        public string Crefun0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("UPDFUN_0")]
        [StringLength(10)]
        public string Updfun0 { get; set; }
        [Column("TIMMAC_0", TypeName = "numeric(13, 5)")]
        public decimal Timmac0 { get; set; }
        [Column("TIMLAB_0", TypeName = "numeric(13, 5)")]
        public decimal Timlab0 { get; set; }
        [Column("LABCOE_0", TypeName = "numeric(10, 4)")]
        public decimal Labcoe0 { get; set; }
        [Column("POSDAT_0", TypeName = "datetime")]
        public DateTime Posdat0 { get; set; }
        [Column("CHGRAT_0", TypeName = "numeric(23, 11)")]
        public decimal Chgrat0 { get; set; }
        [Column("STDCHGRAT_0", TypeName = "numeric(13, 1)")]
        public decimal Stdchgrat0 { get; set; }
        [Required]
        [Column("REF_0")]
        [StringLength(50)]
        public string Ref0 { get; set; }
        [Required]
        [Column("SHIFT_0")]
        [StringLength(6)]
        public string Shift0 { get; set; }
        [Required]
        [Column("SCASCHO_0")]
        [StringLength(10)]
        public string Scascho0 { get; set; }
        [Column("WSTTYP_0")]
        public byte Wsttyp0 { get; set; }
        [Column("FLGTIM_0")]
        public byte Flgtim0 { get; set; }
        [Required]
        [Column("MFGTRKNUM_0")]
        [StringLength(20)]
        public string Mfgtrknum0 { get; set; }
        [Required]
        [Column("MFGFCY_0")]
        [StringLength(5)]
        public string Mfgfcy0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}