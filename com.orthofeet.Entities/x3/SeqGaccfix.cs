﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Keyless]
    [Table("$SEQ_GACCFIX", Schema = "TESTPROD")]
    public partial class SeqGaccfix
    {
        [Column("id", TypeName = "numeric(38, 0)")]
        public decimal Id { get; set; }
    }
}