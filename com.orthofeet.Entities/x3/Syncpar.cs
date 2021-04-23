﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SYNCPAR", Schema = "TESTPROD")]
    [Index(nameof(Sypusr0), Name = "SYNCPAR_SYP0", IsUnique = true)]
    public partial class Syncpar
    {
        [Required]
        [Column("SYPUSR_0")]
        [StringLength(5)]
        public string Sypusr0 { get; set; }
        [Required]
        [Column("OTKUSR_0")]
        [StringLength(10)]
        public string Otkusr0 { get; set; }
        [Column("COROTKCRE_0")]
        public byte Corotkcre0 { get; set; }
        [Column("COROTKUPD_0")]
        public byte Corotkupd0 { get; set; }
        [Column("COROTKDLT_0")]
        public byte Corotkdlt0 { get; set; }
        [Column("CORADXCRE_0")]
        public byte Coradxcre0 { get; set; }
        [Column("CORADXUPD_0")]
        public byte Coradxupd0 { get; set; }
        [Column("CORADXDLT_0")]
        public byte Coradxdlt0 { get; set; }
        [Column("TSKOTKCRE_0")]
        public byte Tskotkcre0 { get; set; }
        [Column("TSKOTKUPD_0")]
        public byte Tskotkupd0 { get; set; }
        [Column("TSKOTKDLT_0")]
        public byte Tskotkdlt0 { get; set; }
        [Column("TSKADXCRE_0")]
        public byte Tskadxcre0 { get; set; }
        [Column("TSKADXUPD_0")]
        public byte Tskadxupd0 { get; set; }
        [Column("TSKADXDLT_0")]
        public byte Tskadxdlt0 { get; set; }
        [Column("CLLOTKCRE_0")]
        public byte Cllotkcre0 { get; set; }
        [Column("CLLOTKUPD_0")]
        public byte Cllotkupd0 { get; set; }
        [Column("CLLOTKDLT_0")]
        public byte Cllotkdlt0 { get; set; }
        [Column("CLLADXCRE_0")]
        public byte Clladxcre0 { get; set; }
        [Column("CLLADXUPD_0")]
        public byte Clladxupd0 { get; set; }
        [Column("CLLADXDLT_0")]
        public byte Clladxdlt0 { get; set; }
        [Column("BAPOTKCRE_0")]
        public byte Bapotkcre0 { get; set; }
        [Column("BAPOTKUPD_0")]
        public byte Bapotkupd0 { get; set; }
        [Column("BAPOTKDLT_0")]
        public byte Bapotkdlt0 { get; set; }
        [Column("BAPADXCRE_0")]
        public byte Bapadxcre0 { get; set; }
        [Column("BAPADXUPD_0")]
        public byte Bapadxupd0 { get; set; }
        [Column("BAPADXDLT_0")]
        public byte Bapadxdlt0 { get; set; }
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