﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("APTLVW", Schema = "TESTPROD")]
    [Index(nameof(Apvcod0), Name = "APTLVW_APV0", IsUnique = true)]
    public partial class Aptlvw
    {
        [Required]
        [Column("APVCOD_0")]
        [StringLength(10)]
        public string Apvcod0 { get; set; }
        [Required]
        [Column("SRCCODTYP_0")]
        [StringLength(4)]
        public string Srccodtyp0 { get; set; }
        [Required]
        [Column("SRCCOD_0")]
        [StringLength(10)]
        public string Srccod0 { get; set; }
        [Required]
        [Column("SRCPARCOD_0")]
        [StringLength(10)]
        public string Srcparcod0 { get; set; }
        [Required]
        [Column("SRCPARCOD_1")]
        [StringLength(10)]
        public string Srcparcod1 { get; set; }
        [Required]
        [Column("SRCPARCOD_2")]
        [StringLength(10)]
        public string Srcparcod2 { get; set; }
        [Required]
        [Column("SRCPARCOD_3")]
        [StringLength(10)]
        public string Srcparcod3 { get; set; }
        [Required]
        [Column("SRCPARCOD_4")]
        [StringLength(10)]
        public string Srcparcod4 { get; set; }
        [Required]
        [Column("SRCPARCOD_5")]
        [StringLength(10)]
        public string Srcparcod5 { get; set; }
        [Required]
        [Column("SRCPARCOD_6")]
        [StringLength(10)]
        public string Srcparcod6 { get; set; }
        [Required]
        [Column("SRCPARCOD_7")]
        [StringLength(10)]
        public string Srcparcod7 { get; set; }
        [Required]
        [Column("SRCPARCOD_8")]
        [StringLength(10)]
        public string Srcparcod8 { get; set; }
        [Required]
        [Column("SRCPARCOD_9")]
        [StringLength(10)]
        public string Srcparcod9 { get; set; }
        [Required]
        [Column("SRCPARCOD_10")]
        [StringLength(10)]
        public string Srcparcod10 { get; set; }
        [Required]
        [Column("SRCPARCOD_11")]
        [StringLength(10)]
        public string Srcparcod11 { get; set; }
        [Required]
        [Column("SRCPARCOD_12")]
        [StringLength(10)]
        public string Srcparcod12 { get; set; }
        [Required]
        [Column("SRCPARCOD_13")]
        [StringLength(10)]
        public string Srcparcod13 { get; set; }
        [Required]
        [Column("SRCPARCOD_14")]
        [StringLength(10)]
        public string Srcparcod14 { get; set; }
        [Required]
        [Column("SRCPARCOD_15")]
        [StringLength(10)]
        public string Srcparcod15 { get; set; }
        [Required]
        [Column("SRCPARCOD_16")]
        [StringLength(10)]
        public string Srcparcod16 { get; set; }
        [Required]
        [Column("SRCPARCOD_17")]
        [StringLength(10)]
        public string Srcparcod17 { get; set; }
        [Required]
        [Column("SRCPARCOD_18")]
        [StringLength(10)]
        public string Srcparcod18 { get; set; }
        [Required]
        [Column("SRCPARCOD_19")]
        [StringLength(10)]
        public string Srcparcod19 { get; set; }
        [Required]
        [Column("SRCPARFOR_0")]
        [StringLength(80)]
        public string Srcparfor0 { get; set; }
        [Required]
        [Column("SRCPARFOR_1")]
        [StringLength(80)]
        public string Srcparfor1 { get; set; }
        [Required]
        [Column("SRCPARFOR_2")]
        [StringLength(80)]
        public string Srcparfor2 { get; set; }
        [Required]
        [Column("SRCPARFOR_3")]
        [StringLength(80)]
        public string Srcparfor3 { get; set; }
        [Required]
        [Column("SRCPARFOR_4")]
        [StringLength(80)]
        public string Srcparfor4 { get; set; }
        [Required]
        [Column("SRCPARFOR_5")]
        [StringLength(80)]
        public string Srcparfor5 { get; set; }
        [Required]
        [Column("SRCPARFOR_6")]
        [StringLength(80)]
        public string Srcparfor6 { get; set; }
        [Required]
        [Column("SRCPARFOR_7")]
        [StringLength(80)]
        public string Srcparfor7 { get; set; }
        [Required]
        [Column("SRCPARFOR_8")]
        [StringLength(80)]
        public string Srcparfor8 { get; set; }
        [Required]
        [Column("SRCPARFOR_9")]
        [StringLength(80)]
        public string Srcparfor9 { get; set; }
        [Required]
        [Column("SRCPARFOR_10")]
        [StringLength(80)]
        public string Srcparfor10 { get; set; }
        [Required]
        [Column("SRCPARFOR_11")]
        [StringLength(80)]
        public string Srcparfor11 { get; set; }
        [Required]
        [Column("SRCPARFOR_12")]
        [StringLength(80)]
        public string Srcparfor12 { get; set; }
        [Required]
        [Column("SRCPARFOR_13")]
        [StringLength(80)]
        public string Srcparfor13 { get; set; }
        [Required]
        [Column("SRCPARFOR_14")]
        [StringLength(80)]
        public string Srcparfor14 { get; set; }
        [Required]
        [Column("SRCPARFOR_15")]
        [StringLength(80)]
        public string Srcparfor15 { get; set; }
        [Required]
        [Column("SRCPARFOR_16")]
        [StringLength(80)]
        public string Srcparfor16 { get; set; }
        [Required]
        [Column("SRCPARFOR_17")]
        [StringLength(80)]
        public string Srcparfor17 { get; set; }
        [Required]
        [Column("SRCPARFOR_18")]
        [StringLength(80)]
        public string Srcparfor18 { get; set; }
        [Required]
        [Column("SRCPARFOR_19")]
        [StringLength(80)]
        public string Srcparfor19 { get; set; }
        [Column("SRCPARNBR_0")]
        public short Srcparnbr0 { get; set; }
        [Required]
        [Column("CMPCODTYP_0")]
        [StringLength(4)]
        public string Cmpcodtyp0 { get; set; }
        [Required]
        [Column("CMPPARCOD_0")]
        [StringLength(10)]
        public string Cmpparcod0 { get; set; }
        [Required]
        [Column("CMPPARCOD_1")]
        [StringLength(10)]
        public string Cmpparcod1 { get; set; }
        [Required]
        [Column("CMPPARCOD_2")]
        [StringLength(10)]
        public string Cmpparcod2 { get; set; }
        [Required]
        [Column("CMPPARCOD_3")]
        [StringLength(10)]
        public string Cmpparcod3 { get; set; }
        [Required]
        [Column("CMPPARCOD_4")]
        [StringLength(10)]
        public string Cmpparcod4 { get; set; }
        [Required]
        [Column("CMPPARCOD_5")]
        [StringLength(10)]
        public string Cmpparcod5 { get; set; }
        [Required]
        [Column("CMPPARCOD_6")]
        [StringLength(10)]
        public string Cmpparcod6 { get; set; }
        [Required]
        [Column("CMPPARCOD_7")]
        [StringLength(10)]
        public string Cmpparcod7 { get; set; }
        [Required]
        [Column("CMPPARCOD_8")]
        [StringLength(10)]
        public string Cmpparcod8 { get; set; }
        [Required]
        [Column("CMPPARCOD_9")]
        [StringLength(10)]
        public string Cmpparcod9 { get; set; }
        [Required]
        [Column("CMPPARCOD_10")]
        [StringLength(10)]
        public string Cmpparcod10 { get; set; }
        [Required]
        [Column("CMPPARCOD_11")]
        [StringLength(10)]
        public string Cmpparcod11 { get; set; }
        [Required]
        [Column("CMPPARCOD_12")]
        [StringLength(10)]
        public string Cmpparcod12 { get; set; }
        [Required]
        [Column("CMPPARCOD_13")]
        [StringLength(10)]
        public string Cmpparcod13 { get; set; }
        [Required]
        [Column("CMPPARCOD_14")]
        [StringLength(10)]
        public string Cmpparcod14 { get; set; }
        [Required]
        [Column("CMPPARCOD_15")]
        [StringLength(10)]
        public string Cmpparcod15 { get; set; }
        [Required]
        [Column("CMPPARCOD_16")]
        [StringLength(10)]
        public string Cmpparcod16 { get; set; }
        [Required]
        [Column("CMPPARCOD_17")]
        [StringLength(10)]
        public string Cmpparcod17 { get; set; }
        [Required]
        [Column("CMPPARCOD_18")]
        [StringLength(10)]
        public string Cmpparcod18 { get; set; }
        [Required]
        [Column("CMPPARCOD_19")]
        [StringLength(10)]
        public string Cmpparcod19 { get; set; }
        [Required]
        [Column("CMPPARFOR_0")]
        [StringLength(80)]
        public string Cmpparfor0 { get; set; }
        [Required]
        [Column("CMPPARFOR_1")]
        [StringLength(80)]
        public string Cmpparfor1 { get; set; }
        [Required]
        [Column("CMPPARFOR_2")]
        [StringLength(80)]
        public string Cmpparfor2 { get; set; }
        [Required]
        [Column("CMPPARFOR_3")]
        [StringLength(80)]
        public string Cmpparfor3 { get; set; }
        [Required]
        [Column("CMPPARFOR_4")]
        [StringLength(80)]
        public string Cmpparfor4 { get; set; }
        [Required]
        [Column("CMPPARFOR_5")]
        [StringLength(80)]
        public string Cmpparfor5 { get; set; }
        [Required]
        [Column("CMPPARFOR_6")]
        [StringLength(80)]
        public string Cmpparfor6 { get; set; }
        [Required]
        [Column("CMPPARFOR_7")]
        [StringLength(80)]
        public string Cmpparfor7 { get; set; }
        [Required]
        [Column("CMPPARFOR_8")]
        [StringLength(80)]
        public string Cmpparfor8 { get; set; }
        [Required]
        [Column("CMPPARFOR_9")]
        [StringLength(80)]
        public string Cmpparfor9 { get; set; }
        [Required]
        [Column("CMPPARFOR_10")]
        [StringLength(80)]
        public string Cmpparfor10 { get; set; }
        [Required]
        [Column("CMPPARFOR_11")]
        [StringLength(80)]
        public string Cmpparfor11 { get; set; }
        [Required]
        [Column("CMPPARFOR_12")]
        [StringLength(80)]
        public string Cmpparfor12 { get; set; }
        [Required]
        [Column("CMPPARFOR_13")]
        [StringLength(80)]
        public string Cmpparfor13 { get; set; }
        [Required]
        [Column("CMPPARFOR_14")]
        [StringLength(80)]
        public string Cmpparfor14 { get; set; }
        [Required]
        [Column("CMPPARFOR_15")]
        [StringLength(80)]
        public string Cmpparfor15 { get; set; }
        [Required]
        [Column("CMPPARFOR_16")]
        [StringLength(80)]
        public string Cmpparfor16 { get; set; }
        [Required]
        [Column("CMPPARFOR_17")]
        [StringLength(80)]
        public string Cmpparfor17 { get; set; }
        [Required]
        [Column("CMPPARFOR_18")]
        [StringLength(80)]
        public string Cmpparfor18 { get; set; }
        [Required]
        [Column("CMPPARFOR_19")]
        [StringLength(80)]
        public string Cmpparfor19 { get; set; }
        [Column("CMPPARNBR_0")]
        public short Cmpparnbr0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}