// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("GACCTMP", Schema = "TESTPROD")]
    [Index(nameof(Typ0), nameof(Num0), Name = "GACCTMP_HAT0", IsUnique = true)]
    [Index(nameof(Numpce0), Name = "GACCTMP_HAT1")]
    public partial class Gacctmp
    {
        [Column("FLG_0")]
        public short Flg0 { get; set; }
        [Column("NUMPCE_0")]
        public int Numpce0 { get; set; }
        [Required]
        [Column("TYP_0")]
        [StringLength(5)]
        public string Typ0 { get; set; }
        [Required]
        [Column("NUM_0")]
        [StringLength(20)]
        public string Num0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("JOU_0")]
        [StringLength(5)]
        public string Jou0 { get; set; }
        [Required]
        [Column("BOLLATO_0")]
        [StringLength(1)]
        public string Bollato0 { get; set; }
        [Column("FIY_0")]
        public short Fiy0 { get; set; }
        [Column("PER_0")]
        public short Per0 { get; set; }
        [Column("ACCDAT_0", TypeName = "datetime")]
        public DateTime Accdat0 { get; set; }
        [Column("ENTDAT_0", TypeName = "datetime")]
        public DateTime Entdat0 { get; set; }
        [Column("VALDAT_0", TypeName = "datetime")]
        public DateTime Valdat0 { get; set; }
        [Column("DUDDAT_0", TypeName = "datetime")]
        public DateTime Duddat0 { get; set; }
        [Column("BANDAT_0", TypeName = "datetime")]
        public DateTime Bandat0 { get; set; }
        [Column("RATDAT_0", TypeName = "datetime")]
        public DateTime Ratdat0 { get; set; }
        [Column("CAT_0")]
        public byte Cat0 { get; set; }
        [Column("STA_0")]
        public byte Sta0 { get; set; }
        [Column("FNLPSTDAT_0", TypeName = "datetime")]
        public DateTime Fnlpstdat0 { get; set; }
        [Column("ORIMOD_0")]
        public byte Orimod0 { get; set; }
        [Required]
        [Column("DACDIA_0")]
        [StringLength(5)]
        public string Dacdia0 { get; set; }
        [Column("FLGDAS_0")]
        public byte Flgdas0 { get; set; }
        [Column("FLGFUP_0")]
        public byte Flgfup0 { get; set; }
        [Column("FLGPAZ_0")]
        public byte Flgpaz0 { get; set; }
        [Column("FLGREP_0")]
        public byte Flgrep0 { get; set; }
        [Column("FLGGEN_0")]
        public byte Flggen0 { get; set; }
        [Column("TYPDUD_0")]
        public byte Typdud0 { get; set; }
        [Required]
        [Column("BANCIB_0")]
        [StringLength(20)]
        public string Bancib0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("TYPRAT_0")]
        public byte Typrat0 { get; set; }
        [Required]
        [Column("LED_0")]
        [StringLength(3)]
        public string Led0 { get; set; }
        [Required]
        [Column("LED_1")]
        [StringLength(3)]
        public string Led1 { get; set; }
        [Required]
        [Column("LED_2")]
        [StringLength(3)]
        public string Led2 { get; set; }
        [Required]
        [Column("LED_3")]
        [StringLength(3)]
        public string Led3 { get; set; }
        [Required]
        [Column("LED_4")]
        [StringLength(3)]
        public string Led4 { get; set; }
        [Required]
        [Column("LED_5")]
        [StringLength(3)]
        public string Led5 { get; set; }
        [Required]
        [Column("LED_6")]
        [StringLength(3)]
        public string Led6 { get; set; }
        [Required]
        [Column("LED_7")]
        [StringLength(3)]
        public string Led7 { get; set; }
        [Required]
        [Column("LED_8")]
        [StringLength(3)]
        public string Led8 { get; set; }
        [Required]
        [Column("LED_9")]
        [StringLength(3)]
        public string Led9 { get; set; }
        [Required]
        [Column("CURLED_0")]
        [StringLength(3)]
        public string Curled0 { get; set; }
        [Required]
        [Column("CURLED_1")]
        [StringLength(3)]
        public string Curled1 { get; set; }
        [Required]
        [Column("CURLED_2")]
        [StringLength(3)]
        public string Curled2 { get; set; }
        [Required]
        [Column("CURLED_3")]
        [StringLength(3)]
        public string Curled3 { get; set; }
        [Required]
        [Column("CURLED_4")]
        [StringLength(3)]
        public string Curled4 { get; set; }
        [Required]
        [Column("CURLED_5")]
        [StringLength(3)]
        public string Curled5 { get; set; }
        [Required]
        [Column("CURLED_6")]
        [StringLength(3)]
        public string Curled6 { get; set; }
        [Required]
        [Column("CURLED_7")]
        [StringLength(3)]
        public string Curled7 { get; set; }
        [Required]
        [Column("CURLED_8")]
        [StringLength(3)]
        public string Curled8 { get; set; }
        [Required]
        [Column("CURLED_9")]
        [StringLength(3)]
        public string Curled9 { get; set; }
        [Column("RATMLT_0", TypeName = "numeric(21, 10)")]
        public decimal Ratmlt0 { get; set; }
        [Column("RATMLT_1", TypeName = "numeric(21, 10)")]
        public decimal Ratmlt1 { get; set; }
        [Column("RATMLT_2", TypeName = "numeric(21, 10)")]
        public decimal Ratmlt2 { get; set; }
        [Column("RATMLT_3", TypeName = "numeric(21, 10)")]
        public decimal Ratmlt3 { get; set; }
        [Column("RATMLT_4", TypeName = "numeric(21, 10)")]
        public decimal Ratmlt4 { get; set; }
        [Column("RATMLT_5", TypeName = "numeric(21, 10)")]
        public decimal Ratmlt5 { get; set; }
        [Column("RATMLT_6", TypeName = "numeric(21, 10)")]
        public decimal Ratmlt6 { get; set; }
        [Column("RATMLT_7", TypeName = "numeric(21, 10)")]
        public decimal Ratmlt7 { get; set; }
        [Column("RATMLT_8", TypeName = "numeric(21, 10)")]
        public decimal Ratmlt8 { get; set; }
        [Column("RATMLT_9", TypeName = "numeric(21, 10)")]
        public decimal Ratmlt9 { get; set; }
        [Column("RATDIV_0", TypeName = "numeric(21, 10)")]
        public decimal Ratdiv0 { get; set; }
        [Column("RATDIV_1", TypeName = "numeric(21, 10)")]
        public decimal Ratdiv1 { get; set; }
        [Column("RATDIV_2", TypeName = "numeric(21, 10)")]
        public decimal Ratdiv2 { get; set; }
        [Column("RATDIV_3", TypeName = "numeric(21, 10)")]
        public decimal Ratdiv3 { get; set; }
        [Column("RATDIV_4", TypeName = "numeric(21, 10)")]
        public decimal Ratdiv4 { get; set; }
        [Column("RATDIV_5", TypeName = "numeric(21, 10)")]
        public decimal Ratdiv5 { get; set; }
        [Column("RATDIV_6", TypeName = "numeric(21, 10)")]
        public decimal Ratdiv6 { get; set; }
        [Column("RATDIV_7", TypeName = "numeric(21, 10)")]
        public decimal Ratdiv7 { get; set; }
        [Column("RATDIV_8", TypeName = "numeric(21, 10)")]
        public decimal Ratdiv8 { get; set; }
        [Column("RATDIV_9", TypeName = "numeric(21, 10)")]
        public decimal Ratdiv9 { get; set; }
        [Required]
        [Column("DESVCR_0")]
        [StringLength(30)]
        public string Desvcr0 { get; set; }
        [Required]
        [Column("REF_0")]
        [StringLength(30)]
        public string Ref0 { get; set; }
        [Required]
        [Column("BPRVCR_0")]
        [StringLength(20)]
        public string Bprvcr0 { get; set; }
        [Column("BPRDATVCR_0", TypeName = "datetime")]
        public DateTime Bprdatvcr0 { get; set; }
        [Required]
        [Column("REFSIM_0")]
        [StringLength(20)]
        public string Refsim0 { get; set; }
        [Required]
        [Column("REFINT_0")]
        [StringLength(25)]
        public string Refint0 { get; set; }
        [Column("NUMDCL_0")]
        public int Numdcl0 { get; set; }
        [Column("RVS_0")]
        public byte Rvs0 { get; set; }
        [Column("RVSDAT_0", TypeName = "datetime")]
        public DateTime Rvsdat0 { get; set; }
        [Required]
        [Column("RVSORITYP_0")]
        [StringLength(5)]
        public string Rvsorityp0 { get; set; }
        [Required]
        [Column("RVSORINUM_0")]
        [StringLength(20)]
        public string Rvsorinum0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}