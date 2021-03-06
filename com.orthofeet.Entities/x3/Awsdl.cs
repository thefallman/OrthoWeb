// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AWSDL", Schema = "TESTPROD")]
    [Index(nameof(Cwsdl0), Name = "AWSDL_AXL0", IsUnique = true)]
    public partial class Awsdl
    {
        [Required]
        [Column("CWSDL_0")]
        [StringLength(10)]
        public string Cwsdl0 { get; set; }
        [Required]
        [Column("LWSDL_0")]
        [StringLength(30)]
        public string Lwsdl0 { get; set; }
        [Required]
        [Column("ABRWSDL_0")]
        [StringLength(3)]
        public string Abrwsdl0 { get; set; }
        [Column("DGENWSDL_0", TypeName = "datetime")]
        public DateTime Dgenwsdl0 { get; set; }
        [Required]
        [Column("HGENWSDL_0")]
        [StringLength(10)]
        public string Hgenwsdl0 { get; set; }
        [Required]
        [Column("PGENWSDL_0")]
        [StringLength(5)]
        public string Pgenwsdl0 { get; set; }
        [Required]
        [Column("NAMWSDL_0")]
        [StringLength(30)]
        public string Namwsdl0 { get; set; }
        [Required]
        [Column("PREFSP_0")]
        [StringLength(10)]
        public string Prefsp0 { get; set; }
        [Required]
        [Column("WSDLDEF_0")]
        public string Wsdldef0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}