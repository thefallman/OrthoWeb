using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.orthofeet.Entities
{
    [Table("SORDERQ", Schema = "PROD")]
    public class OrderLine
    {
        [Key]
        public int ROWID { get; set; }
        public string SOHNUM_0 { get; set; }
        public int SOPLIN_0 { get; set; }
        public int SOQSEQ_0 { get; set; }
        public string CPY_0 { get; set; }
        public byte SOHCAT_0 { get; set; }
        public string SALFCY_0 { get; set; }
        public string BPCORD_0 { get; set; }
        public string BPAADD_0 { get; set; }
        public string ITMREF_0 { get; set; }
        public string STOFCY_0 { get; set; }
        public string USEPLC_0 { get; set; }
        public byte CAD_0 { get; set; }
        public short YEA_0 { get; set; }
        public short MON_0 { get; set; }
        public short DLVDAY_0 { get; set; }
        public short WEE_0 { get; set; }
        public DateTime ORDDAT_0 { get; set; }
        public DateTime DEMDLVDAT_0 { get; set; }
        public string DEMDLVHOU_0 { get; set; }
        public string DEMDLVREF_0 { get; set; }
        public int IMPNUMLIG_0 { get; set; }
        public DateTime SHIDAT_0 { get; set; }
        public string SHIHOU_0 { get; set; }
        public DateTime EXTDLVDAT_0 { get; set; }
        public byte SOQSTA_0 { get; set; }
        public byte INVFLG_0 { get; set; }
        public byte DEMSTA_0 { get; set; }
        public string DEMNUM_0 { get; set; }
        public byte STOMGTCOD_0 { get; set; }
        public string LOT_0 { get; set; }
        public string STA_0 { get; set; }
        public string LOC_0 { get; set; }
        public byte ALLTYP_0 { get; set; }
        public byte DSPLINFLG_0 { get; set; }
        public short DDTANUM_0 { get; set; }
        public short DDTANUM_1 { get; set; }
        public short DDTANUM_2 { get; set; }
        public short DDTANUM_3 { get; set; }
        public short DDTANUM_4 { get; set; }
        public short DDTANUM_5 { get; set; }
        public short DDTANUM_6 { get; set; }
        public short DDTANUM_7 { get; set; }
        public short DDTANUM_8 { get; set; }
        public decimal DDTANOT_0 { get; set; }
        public decimal DDTANOT_1 { get; set; }
        public decimal DDTANOT_2 { get; set; }
        public decimal DDTANOT_3 { get; set; }
        public decimal DDTANOT_4 { get; set; }
        public decimal DDTANOT_5 { get; set; }
        public decimal DDTANOT_6 { get; set; }
        public decimal DDTANOT_7 { get; set; }
        public decimal DDTANOT_8 { get; set; }
        public decimal ORIQTY_0 { get; set; }
        public decimal QTY_0 { get; set; }
        public decimal SHTQTY_0 { get; set; }
        public decimal ALLQTY_0 { get; set; }
        public decimal ODLQTY_0 { get; set; }
        public decimal DLVQTY_0 { get; set; }
        public decimal INVQTY_0 { get; set; }
        public decimal TDLQTY_0 { get; set; }
        public decimal LPRQTY_0 { get; set; }
        public decimal OPRQTY_0 { get; set; }
        public decimal PREQTY_0 { get; set; }
        public decimal QTYSTU_0 { get; set; }
        public decimal SHTQTYSTU_0 { get; set; }
        public decimal ALLQTYSTU_0 { get; set; }
        public decimal ODLQTYSTU_0 { get; set; }
        public decimal DLVQTYSTU_0 { get; set; }
        public decimal INVQTYSTU_0 { get; set; }
        public decimal TDLQTYSTU_0 { get; set; }
        public decimal LPRQTYSTU_0 { get; set; }
        public decimal OPRQTYSTU_0 { get; set; }
        public decimal PREQTYSTU_0 { get; set; }
        public string PRECOD_0 { get; set; }
        public byte DRN_0 { get; set; }
        public byte DLVPIO_0 { get; set; }
        public short DLVPIOCMP_0 { get; set; }
        public string BPTNUM_0 { get; set; }
        public string MDL_0 { get; set; }
        public short DAYLTI_0 { get; set; }
        public string PCK_0 { get; set; }
        public decimal PCKCAP_0 { get; set; }
        public string SOQTEX_0 { get; set; }
        public string SDHNUM_0 { get; set; }
        public int SDDLIN_0 { get; set; }
        public byte FMI_0 { get; set; }
        public string FMINUM_0 { get; set; }
        public int FMILIN_0 { get; set; }
        public int FMISEQ_0 { get; set; }
        public string POHNUM_0 { get; set; }
        public int POPLIN_0 { get; set; }
        public int POQSEQ_0 { get; set; }
        public DateTime PERSTRDAT_0 { get; set; }
        public DateTime PERENDDAT_0 { get; set; }
        public short PERNBRDAY_0 { get; set; }
        public string GEOCOD_0 { get; set; }
        public string INSCTYFLG_0 { get; set; }
        public string VTS_0 { get; set; }
        public string VTC_0 { get; set; }
        public string TAXGEOFLG_0 { get; set; }
        public byte TAXFLG_0 { get; set; }
        public byte TAXREGFLG_0 { get; set; }
        public decimal RATTAXLIN_0 { get; set; }
        public decimal BASTAXLIN_0 { get; set; }
        public byte OCNPRNBOM_0 { get; set; }
        public byte NDEPRNBOM_0 { get; set; }
        public byte INVPRNBOM_0 { get; set; }
        public string CCLREN_0 { get; set; }
        public DateTime CCLDAT_0 { get; set; }
        public decimal PITFLG_0 { get; set; }
        public int EXPNUM_0 { get; set; }
        public decimal DSPLINWEI_0 { get; set; }
        public decimal DSPLINVOL_0 { get; set; }
        public string DSPWEU_0 { get; set; }
        public string DSPVOU_0 { get; set; }
        public string CREUSR_0 { get; set; }
        public DateTime CREDAT_0 { get; set; }
        public string UPDUSR_0 { get; set; }
        public DateTime UPDDAT_0 { get; set; }
        public short YEDILINENO_0 { get; set; }
        
        //[ForeignKey(nameof(SOHNUM_0))]
        public virtual OrderHeader Order { get; set;}

    }
}