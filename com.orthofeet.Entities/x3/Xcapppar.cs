// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("XCAPPPAR", Schema = "TESTPROD")]
    [Index(nameof(Appid0), Name = "XCAPPPAR_XC00", IsUnique = true)]
    [Index(nameof(Lan0), Name = "XCAPPPAR_XC01", IsUnique = true)]
    public partial class Xcapppar
    {
        [Required]
        [Column("APPID_0")]
        [StringLength(100)]
        public string Appid0 { get; set; }
        [Required]
        [Column("LAN_0")]
        [StringLength(3)]
        public string Lan0 { get; set; }
        [Required]
        [Column("SPSLAN_0")]
        [StringLength(2)]
        public string Spslan0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}