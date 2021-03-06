// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("GCOMMITD", Schema = "TESTPROD")]
    [Index(nameof(Num0), nameof(Lin0), Name = "GCOMMITD_CMD0", IsUnique = true)]
    public partial class Gcommitd
    {
        [Required]
        [Column("NUM_0")]
        [StringLength(20)]
        public string Num0 { get; set; }
        [Column("LIN_0")]
        public short Lin0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("FCYLIN_0")]
        [StringLength(5)]
        public string Fcylin0 { get; set; }
        [Required]
        [Column("BPRACC_0")]
        [StringLength(15)]
        public string Bpracc0 { get; set; }
        [Column("ACCDAT_0", TypeName = "datetime")]
        public DateTime Accdat0 { get; set; }
        [Column("FIY_0")]
        public short Fiy0 { get; set; }
        [Column("PER_0")]
        public short Per0 { get; set; }
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
        [Column("LEDTYP_0")]
        public byte Ledtyp0 { get; set; }
        [Column("LEDTYP_1")]
        public byte Ledtyp1 { get; set; }
        [Column("LEDTYP_2")]
        public byte Ledtyp2 { get; set; }
        [Column("LEDTYP_3")]
        public byte Ledtyp3 { get; set; }
        [Column("LEDTYP_4")]
        public byte Ledtyp4 { get; set; }
        [Column("LEDTYP_5")]
        public byte Ledtyp5 { get; set; }
        [Column("LEDTYP_6")]
        public byte Ledtyp6 { get; set; }
        [Column("LEDTYP_7")]
        public byte Ledtyp7 { get; set; }
        [Column("LEDTYP_8")]
        public byte Ledtyp8 { get; set; }
        [Column("LEDTYP_9")]
        public byte Ledtyp9 { get; set; }
        [Required]
        [Column("COA_0")]
        [StringLength(3)]
        public string Coa0 { get; set; }
        [Required]
        [Column("COA_1")]
        [StringLength(3)]
        public string Coa1 { get; set; }
        [Required]
        [Column("COA_2")]
        [StringLength(3)]
        public string Coa2 { get; set; }
        [Required]
        [Column("COA_3")]
        [StringLength(3)]
        public string Coa3 { get; set; }
        [Required]
        [Column("COA_4")]
        [StringLength(3)]
        public string Coa4 { get; set; }
        [Required]
        [Column("COA_5")]
        [StringLength(3)]
        public string Coa5 { get; set; }
        [Required]
        [Column("COA_6")]
        [StringLength(3)]
        public string Coa6 { get; set; }
        [Required]
        [Column("COA_7")]
        [StringLength(3)]
        public string Coa7 { get; set; }
        [Required]
        [Column("COA_8")]
        [StringLength(3)]
        public string Coa8 { get; set; }
        [Required]
        [Column("COA_9")]
        [StringLength(3)]
        public string Coa9 { get; set; }
        [Required]
        [Column("ACC_0")]
        [StringLength(15)]
        public string Acc0 { get; set; }
        [Required]
        [Column("ACC_1")]
        [StringLength(15)]
        public string Acc1 { get; set; }
        [Required]
        [Column("ACC_2")]
        [StringLength(15)]
        public string Acc2 { get; set; }
        [Required]
        [Column("ACC_3")]
        [StringLength(15)]
        public string Acc3 { get; set; }
        [Required]
        [Column("ACC_4")]
        [StringLength(15)]
        public string Acc4 { get; set; }
        [Required]
        [Column("ACC_5")]
        [StringLength(15)]
        public string Acc5 { get; set; }
        [Required]
        [Column("ACC_6")]
        [StringLength(15)]
        public string Acc6 { get; set; }
        [Required]
        [Column("ACC_7")]
        [StringLength(15)]
        public string Acc7 { get; set; }
        [Required]
        [Column("ACC_8")]
        [StringLength(15)]
        public string Acc8 { get; set; }
        [Required]
        [Column("ACC_9")]
        [StringLength(15)]
        public string Acc9 { get; set; }
        [Required]
        [Column("DIE_0")]
        [StringLength(3)]
        public string Die0 { get; set; }
        [Required]
        [Column("DIE_1")]
        [StringLength(3)]
        public string Die1 { get; set; }
        [Required]
        [Column("DIE_2")]
        [StringLength(3)]
        public string Die2 { get; set; }
        [Required]
        [Column("DIE_3")]
        [StringLength(3)]
        public string Die3 { get; set; }
        [Required]
        [Column("DIE_4")]
        [StringLength(3)]
        public string Die4 { get; set; }
        [Required]
        [Column("DIE_5")]
        [StringLength(3)]
        public string Die5 { get; set; }
        [Required]
        [Column("DIE_6")]
        [StringLength(3)]
        public string Die6 { get; set; }
        [Required]
        [Column("DIE_7")]
        [StringLength(3)]
        public string Die7 { get; set; }
        [Required]
        [Column("DIE_8")]
        [StringLength(3)]
        public string Die8 { get; set; }
        [Required]
        [Column("DIE_9")]
        [StringLength(3)]
        public string Die9 { get; set; }
        [Required]
        [Column("DIE_10")]
        [StringLength(3)]
        public string Die10 { get; set; }
        [Required]
        [Column("DIE_11")]
        [StringLength(3)]
        public string Die11 { get; set; }
        [Required]
        [Column("DIE_12")]
        [StringLength(3)]
        public string Die12 { get; set; }
        [Required]
        [Column("DIE_13")]
        [StringLength(3)]
        public string Die13 { get; set; }
        [Required]
        [Column("DIE_14")]
        [StringLength(3)]
        public string Die14 { get; set; }
        [Required]
        [Column("DIE_15")]
        [StringLength(3)]
        public string Die15 { get; set; }
        [Required]
        [Column("DIE_16")]
        [StringLength(3)]
        public string Die16 { get; set; }
        [Required]
        [Column("DIE_17")]
        [StringLength(3)]
        public string Die17 { get; set; }
        [Required]
        [Column("DIE_18")]
        [StringLength(3)]
        public string Die18 { get; set; }
        [Required]
        [Column("DIE_19")]
        [StringLength(3)]
        public string Die19 { get; set; }
        [Required]
        [Column("CCE_0")]
        [StringLength(15)]
        public string Cce0 { get; set; }
        [Required]
        [Column("CCE_1")]
        [StringLength(15)]
        public string Cce1 { get; set; }
        [Required]
        [Column("CCE_2")]
        [StringLength(15)]
        public string Cce2 { get; set; }
        [Required]
        [Column("CCE_3")]
        [StringLength(15)]
        public string Cce3 { get; set; }
        [Required]
        [Column("CCE_4")]
        [StringLength(15)]
        public string Cce4 { get; set; }
        [Required]
        [Column("CCE_5")]
        [StringLength(15)]
        public string Cce5 { get; set; }
        [Required]
        [Column("CCE_6")]
        [StringLength(15)]
        public string Cce6 { get; set; }
        [Required]
        [Column("CCE_7")]
        [StringLength(15)]
        public string Cce7 { get; set; }
        [Required]
        [Column("CCE_8")]
        [StringLength(15)]
        public string Cce8 { get; set; }
        [Required]
        [Column("CCE_9")]
        [StringLength(15)]
        public string Cce9 { get; set; }
        [Required]
        [Column("CCE_10")]
        [StringLength(15)]
        public string Cce10 { get; set; }
        [Required]
        [Column("CCE_11")]
        [StringLength(15)]
        public string Cce11 { get; set; }
        [Required]
        [Column("CCE_12")]
        [StringLength(15)]
        public string Cce12 { get; set; }
        [Required]
        [Column("CCE_13")]
        [StringLength(15)]
        public string Cce13 { get; set; }
        [Required]
        [Column("CCE_14")]
        [StringLength(15)]
        public string Cce14 { get; set; }
        [Required]
        [Column("CCE_15")]
        [StringLength(15)]
        public string Cce15 { get; set; }
        [Required]
        [Column("CCE_16")]
        [StringLength(15)]
        public string Cce16 { get; set; }
        [Required]
        [Column("CCE_17")]
        [StringLength(15)]
        public string Cce17 { get; set; }
        [Required]
        [Column("CCE_18")]
        [StringLength(15)]
        public string Cce18 { get; set; }
        [Required]
        [Column("CCE_19")]
        [StringLength(15)]
        public string Cce19 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(30)]
        public string Des0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("AMTCUR_0", TypeName = "numeric(27, 13)")]
        public decimal Amtcur0 { get; set; }
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
        [Column("AMTLED_0", TypeName = "numeric(27, 13)")]
        public decimal Amtled0 { get; set; }
        [Column("AMTLED_1", TypeName = "numeric(27, 13)")]
        public decimal Amtled1 { get; set; }
        [Column("AMTLED_2", TypeName = "numeric(27, 13)")]
        public decimal Amtled2 { get; set; }
        [Column("AMTLED_3", TypeName = "numeric(27, 13)")]
        public decimal Amtled3 { get; set; }
        [Column("AMTLED_4", TypeName = "numeric(27, 13)")]
        public decimal Amtled4 { get; set; }
        [Column("AMTLED_5", TypeName = "numeric(27, 13)")]
        public decimal Amtled5 { get; set; }
        [Column("AMTLED_6", TypeName = "numeric(27, 13)")]
        public decimal Amtled6 { get; set; }
        [Column("AMTLED_7", TypeName = "numeric(27, 13)")]
        public decimal Amtled7 { get; set; }
        [Column("AMTLED_8", TypeName = "numeric(27, 13)")]
        public decimal Amtled8 { get; set; }
        [Column("AMTLED_9", TypeName = "numeric(27, 13)")]
        public decimal Amtled9 { get; set; }
        [Required]
        [Column("UOM_0")]
        [StringLength(3)]
        public string Uom0 { get; set; }
        [Column("QTY_0", TypeName = "numeric(28, 13)")]
        public decimal Qty0 { get; set; }
        [Column("GRDACT_0")]
        public byte Grdact0 { get; set; }
        [Column("GRDPCE_0")]
        public byte Grdpce0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}