﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("PARMTO", Schema = "TESTPROD")]
    [Index(nameof(Ptocod0), Name = "PARMTO_PTO0", IsUnique = true)]
    public partial class Parmto
    {
        [Required]
        [Column("PTOCOD_0")]
        [StringLength(5)]
        public string Ptocod0 { get; set; }
        [Required]
        [Column("PTODES_0")]
        [StringLength(30)]
        public string Ptodes0 { get; set; }
        [Required]
        [Column("PTOSHO_0")]
        [StringLength(10)]
        public string Ptosho0 { get; set; }
        [Column("PTOAUT_0")]
        public byte Ptoaut0 { get; set; }
        [Column("PTOREAL_0")]
        public byte Ptoreal0 { get; set; }
        [Column("REAL4DEM_0")]
        public byte Real4dem0 { get; set; }
        [Column("REAL4RESS_0")]
        public byte Real4ress0 { get; set; }
        [Column("FRCPRO_0")]
        public byte Frcpro0 { get; set; }
        [Column("DIRALL_0")]
        public byte Dirall0 { get; set; }
        [Column("PTODIR_0")]
        public byte Ptodir0 { get; set; }
        [Column("PIOMOD_0")]
        public byte Piomod0 { get; set; }
        [Column("PIOFCT_0")]
        public short Piofct0 { get; set; }
        [Column("SHTMOD_0")]
        public byte Shtmod0 { get; set; }
        [Column("SHTFCT_0")]
        public short Shtfct0 { get; set; }
        [Column("DEMMOD_0")]
        public byte Demmod0 { get; set; }
        [Column("DEMFCT_0")]
        public short Demfct0 { get; set; }
        [Column("DEMCAT_0")]
        public byte Demcat0 { get; set; }
        [Column("PTOHORFLG_0")]
        public byte Ptohorflg0 { get; set; }
        [Column("PTOHOR_0")]
        public short Ptohor0 { get; set; }
        [Column("PJTFLT_0")]
        public byte Pjtflt0 { get; set; }
        [Column("PJTFLT_1")]
        public byte Pjtflt1 { get; set; }
        [Column("PJTFLT_2")]
        public byte Pjtflt2 { get; set; }
        [Column("PJTFLT_3")]
        public byte Pjtflt3 { get; set; }
        [Column("PJTFLT_4")]
        public byte Pjtflt4 { get; set; }
        [Column("UNTFLT_0")]
        public byte Untflt0 { get; set; }
        [Column("UNTFLT_1")]
        public byte Untflt1 { get; set; }
        [Column("UNTFLT_2")]
        public byte Untflt2 { get; set; }
        [Column("UNTFLT_3")]
        public byte Untflt3 { get; set; }
        [Column("UNTFLT_4")]
        public byte Untflt4 { get; set; }
        [Column("QTYFLT_0")]
        public byte Qtyflt0 { get; set; }
        [Column("QTYFLT_1")]
        public byte Qtyflt1 { get; set; }
        [Column("QTYFLT_2")]
        public byte Qtyflt2 { get; set; }
        [Column("QTYFLT_3")]
        public byte Qtyflt3 { get; set; }
        [Column("QTYFLT_4")]
        public byte Qtyflt4 { get; set; }
        [Column("QTYPCTUP_0", TypeName = "numeric(10, 4)")]
        public decimal Qtypctup0 { get; set; }
        [Column("QTYPCTUP_1", TypeName = "numeric(10, 4)")]
        public decimal Qtypctup1 { get; set; }
        [Column("QTYPCTUP_2", TypeName = "numeric(10, 4)")]
        public decimal Qtypctup2 { get; set; }
        [Column("QTYPCTUP_3", TypeName = "numeric(10, 4)")]
        public decimal Qtypctup3 { get; set; }
        [Column("QTYPCTUP_4", TypeName = "numeric(10, 4)")]
        public decimal Qtypctup4 { get; set; }
        [Column("QTYPCTDOWN_0", TypeName = "numeric(10, 4)")]
        public decimal Qtypctdown0 { get; set; }
        [Column("QTYPCTDOWN_1", TypeName = "numeric(10, 4)")]
        public decimal Qtypctdown1 { get; set; }
        [Column("QTYPCTDOWN_2", TypeName = "numeric(10, 4)")]
        public decimal Qtypctdown2 { get; set; }
        [Column("QTYPCTDOWN_3", TypeName = "numeric(10, 4)")]
        public decimal Qtypctdown3 { get; set; }
        [Column("QTYPCTDOWN_4", TypeName = "numeric(10, 4)")]
        public decimal Qtypctdown4 { get; set; }
        [Column("BPSFLT_0")]
        public byte Bpsflt0 { get; set; }
        [Column("BPSFLT_1")]
        public byte Bpsflt1 { get; set; }
        [Column("BPSFLT_2")]
        public byte Bpsflt2 { get; set; }
        [Column("BPSFLT_3")]
        public byte Bpsflt3 { get; set; }
        [Column("BPSFLT_4")]
        public byte Bpsflt4 { get; set; }
        [Column("DATFLT_0")]
        public byte Datflt0 { get; set; }
        [Column("DATFLT_1")]
        public byte Datflt1 { get; set; }
        [Column("DATFLT_2")]
        public byte Datflt2 { get; set; }
        [Column("DATFLT_3")]
        public byte Datflt3 { get; set; }
        [Column("DATFLT_4")]
        public byte Datflt4 { get; set; }
        [Column("DATMARUP_0")]
        public short Datmarup0 { get; set; }
        [Column("DATMARUP_1")]
        public short Datmarup1 { get; set; }
        [Column("DATMARUP_2")]
        public short Datmarup2 { get; set; }
        [Column("DATMARUP_3")]
        public short Datmarup3 { get; set; }
        [Column("DATMARUP_4")]
        public short Datmarup4 { get; set; }
        [Column("DATMARDOWN_0")]
        public short Datmardown0 { get; set; }
        [Column("DATMARDOWN_1")]
        public short Datmardown1 { get; set; }
        [Column("DATMARDOWN_2")]
        public short Datmardown2 { get; set; }
        [Column("DATMARDOWN_3")]
        public short Datmardown3 { get; set; }
        [Column("DATMARDOWN_4")]
        public short Datmardown4 { get; set; }
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