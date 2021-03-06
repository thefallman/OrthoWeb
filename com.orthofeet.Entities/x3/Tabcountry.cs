// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TABCOUNTRY", Schema = "TESTPROD")]
    [Index(nameof(Cry0), Name = "TABCOUNTRY_TCY0", IsUnique = true)]
    public partial class Tabcountry
    {
        [Required]
        [Column("CRY_0")]
        [StringLength(3)]
        public string Cry0 { get; set; }
        [Required]
        [Column("EECCOD_0")]
        [StringLength(3)]
        public string Eeccod0 { get; set; }
        [Required]
        [Column("CINSEE_0")]
        [StringLength(5)]
        public string Cinsee0 { get; set; }
        [Required]
        [Column("ISO_0")]
        [StringLength(3)]
        public string Iso0 { get; set; }
        [Required]
        [Column("ISONUM_0")]
        [StringLength(3)]
        public string Isonum0 { get; set; }
        [Required]
        [Column("LAN_0")]
        [StringLength(3)]
        public string Lan0 { get; set; }
        [Column("EECFLG_0")]
        public byte Eecflg0 { get; set; }
        [Column("EECDAT_0", TypeName = "datetime")]
        public DateTime Eecdat0 { get; set; }
        [Required]
        [Column("CTLPRG_0")]
        [StringLength(30)]
        public string Ctlprg0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Required]
        [Column("NAFFMT_0")]
        [StringLength(30)]
        public string Naffmt0 { get; set; }
        [Required]
        [Column("TELFMT_0")]
        [StringLength(30)]
        public string Telfmt0 { get; set; }
        [Required]
        [Column("POSCODFMT_0")]
        [StringLength(30)]
        public string Poscodfmt0 { get; set; }
        [Required]
        [Column("POSCODCRY_0")]
        [StringLength(30)]
        public string Poscodcry0 { get; set; }
        [Required]
        [Column("CTYCODFMT_0")]
        [StringLength(30)]
        public string Ctycodfmt0 { get; set; }
        [Required]
        [Column("CTYNUMFMT_0")]
        [StringLength(30)]
        public string Ctynumfmt0 { get; set; }
        [Required]
        [Column("ADRCODFMT_0")]
        [StringLength(30)]
        public string Adrcodfmt0 { get; set; }
        [Required]
        [Column("ADRNAM_0")]
        [StringLength(20)]
        public string Adrnam0 { get; set; }
        [Required]
        [Column("ADRNAM_1")]
        [StringLength(20)]
        public string Adrnam1 { get; set; }
        [Required]
        [Column("ADRNAM_2")]
        [StringLength(20)]
        public string Adrnam2 { get; set; }
        [Required]
        [Column("BIDFMT_0")]
        [StringLength(30)]
        public string Bidfmt0 { get; set; }
        [Required]
        [Column("PABFMT_0")]
        [StringLength(30)]
        public string Pabfmt0 { get; set; }
        [Required]
        [Column("BIDCRY_0")]
        [StringLength(30)]
        public string Bidcry0 { get; set; }
        [Required]
        [Column("CRNFMT_0")]
        [StringLength(30)]
        public string Crnfmt0 { get; set; }
        [Required]
        [Column("CRTFMT_0")]
        [StringLength(30)]
        public string Crtfmt0 { get; set; }
        [Required]
        [Column("NIDFMT_0")]
        [StringLength(30)]
        public string Nidfmt0 { get; set; }
        [Required]
        [Column("EECFMT_0")]
        [StringLength(30)]
        public string Eecfmt0 { get; set; }
        [Column("CRNFMTFLG_0")]
        public byte Crnfmtflg0 { get; set; }
        [Column("CRTFMTFLG_0")]
        public byte Crtfmtflg0 { get; set; }
        [Column("NIDFMTFLG_0")]
        public byte Nidfmtflg0 { get; set; }
        [Column("EECFMTFLG_0")]
        public byte Eecfmtflg0 { get; set; }
        [Column("NAFFMTFLG_0")]
        public byte Naffmtflg0 { get; set; }
        [Required]
        [Column("SUBDIVFMT_0")]
        [StringLength(30)]
        public string Subdivfmt0 { get; set; }
        [Required]
        [Column("CRYVATNUM_0")]
        [StringLength(3)]
        public string Cryvatnum0 { get; set; }
        [Required]
        [Column("CONTINENT_0")]
        [StringLength(20)]
        public string Continent0 { get; set; }
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
        [Column("ETAT_0")]
        public byte Etat0 { get; set; }
        [Column("ETATFLG_0")]
        public byte Etatflg0 { get; set; }
        [Column("ETATFLG2_0")]
        public byte Etatflg20 { get; set; }
        [Required]
        [Column("ETATFMT_0")]
        [StringLength(30)]
        public string Etatfmt0 { get; set; }
        [Required]
        [Column("ETATFMT2_0")]
        [StringLength(30)]
        public string Etatfmt20 { get; set; }
        [Column("POSCODCTL_0")]
        public byte Poscodctl0 { get; set; }
        [Column("BIDCTL_0")]
        public byte Bidctl0 { get; set; }
        [Column("BANLNG_0")]
        public short Banlng0 { get; set; }
        [Column("FLIBAN_0")]
        public byte Fliban0 { get; set; }
        [Column("POSOBL_0")]
        public byte Posobl0 { get; set; }
        [Column("CRNOBL_0")]
        public byte Crnobl0 { get; set; }
        [Column("CRTOBL_0")]
        public byte Crtobl0 { get; set; }
        [Required]
        [Column("TELTCY_0")]
        [StringLength(10)]
        public string Teltcy0 { get; set; }
        [Required]
        [Column("TELREG_0")]
        [StringLength(10)]
        public string Telreg0 { get; set; }
        [Column("FLGSEPA_0")]
        public byte Flgsepa0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}