// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ORDERS", Schema = "TESTPROD")]
    [Index(nameof(Wiptyp0), nameof(Wipnum0), nameof(Itmref0), Name = "ORDERS_ORD0", IsUnique = true)]
    [Index(nameof(Stofcy0), nameof(Itmref0), nameof(Enddat0), Name = "ORDERS_ORD1")]
    [Index(nameof(Itmref0), nameof(Enddat0), Name = "ORDERS_ORD2")]
    [Index(nameof(Stofcy0), nameof(Vcrtyp0), nameof(Vcrnum0), nameof(Vcrlin0), nameof(Vcrseq0), Name = "ORDERS_ORD3")]
    [Index(nameof(Itmref0), nameof(Stofcy0), nameof(Wiptyp0), Name = "ORDERS_ORD4")]
    public partial class Order
    {
        [Column("WIPTYP_0")]
        public byte Wiptyp0 { get; set; }
        [Column("WIPSTA_0")]
        public byte Wipsta0 { get; set; }
        [Required]
        [Column("WIPNUM_0")]
        [StringLength(20)]
        public string Wipnum0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Required]
        [Column("ORIFCY_0")]
        [StringLength(5)]
        public string Orifcy0 { get; set; }
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("PJT_0")]
        [StringLength(20)]
        public string Pjt0 { get; set; }
        [Required]
        [Column("BPRNUM_0")]
        [StringLength(15)]
        public string Bprnum0 { get; set; }
        [Column("VCRTYP_0")]
        public byte Vcrtyp0 { get; set; }
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Column("VCRLIN_0")]
        public int Vcrlin0 { get; set; }
        [Column("VCRSEQ_0")]
        public int Vcrseq0 { get; set; }
        [Column("STRDAT_0", TypeName = "datetime")]
        public DateTime Strdat0 { get; set; }
        [Column("ENDDAT_0", TypeName = "datetime")]
        public DateTime Enddat0 { get; set; }
        [Column("EXTQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Extqty0 { get; set; }
        [Column("CPLQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Cplqty0 { get; set; }
        [Column("RMNEXTQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Rmnextqty0 { get; set; }
        [Column("ALLQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Allqty0 { get; set; }
        [Column("SHTQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Shtqty0 { get; set; }
        [Column("MTOQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Mtoqty0 { get; set; }
        [Column("FMI_0")]
        public byte Fmi0 { get; set; }
        [Column("MRPMES_0")]
        public byte Mrpmes0 { get; set; }
        [Column("MRPDAT_0", TypeName = "datetime")]
        public DateTime Mrpdat0 { get; set; }
        [Column("MRPQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Mrpqty0 { get; set; }
        [Column("VCRTYPORI_0")]
        public byte Vcrtypori0 { get; set; }
        [Required]
        [Column("VCRNUMORI_0")]
        [StringLength(20)]
        public string Vcrnumori0 { get; set; }
        [Column("VCRLINORI_0")]
        public int Vcrlinori0 { get; set; }
        [Column("VCRSEQORI_0")]
        public int Vcrseqori0 { get; set; }
        [Required]
        [Column("ITMREFORI_0")]
        [StringLength(20)]
        public string Itmrefori0 { get; set; }
        [Column("BOMALTTYP_0")]
        public byte Bomalttyp0 { get; set; }
        [Column("BOMALT_0")]
        public short Bomalt0 { get; set; }
        [Column("BOMOPE_0")]
        public short Bomope0 { get; set; }
        [Column("BOMOFS_0")]
        public short Bomofs0 { get; set; }
        [Column("PIO_0")]
        public byte Pio0 { get; set; }
        [Column("ORI_0")]
        public byte Ori0 { get; set; }
        [Required]
        [Column("ABBFIL_0")]
        [StringLength(3)]
        public string Abbfil0 { get; set; }
        [Column("OPTFLG_0")]
        public byte Optflg0 { get; set; }
        [Required]
        [Column("MTOREF_0")]
        [StringLength(20)]
        public string Mtoref0 { get; set; }
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