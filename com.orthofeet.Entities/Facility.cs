using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.orthofeet.Entities
{
    [Table("FACILITY", Schema = "PROD")]
    public class Facility
    {
        [Key]
        public int ROWID { get; set; }
        public string ACCCOD_0 { get; set; }
        public string BIDNUM_0 { get; set; }
        public string BPAADD_0 { get; set; }
        public string BPTNUM_0 { get; set; }
        public string CCE_0 { get; set; }
        public string CCE_1 { get; set; }
        public string CCE_10 { get; set; }
        public string CCE_11 { get; set; }
        public string CCE_12 { get; set; }
        public string CCE_13 { get; set; }
        public string CCE_14 { get; set; }
        public string CCE_15 { get; set; }
        public string CCE_16 { get; set; }
        public string CCE_17 { get; set; }
        public string CCE_18 { get; set; }
        public string CCE_19 { get; set; }
        public string CCE_2 { get; set; }
        public string CCE_3 { get; set; }
        public string CCE_4 { get; set; }
        public string CCE_5 { get; set; }
        public string CCE_6 { get; set; }
        public string CCE_7 { get; set; }
        public string CCE_8 { get; set; }
        public string CCE_9 { get; set; }
        public string CNTNAM_0 { get; set; }
        public DateTime CREDAT_0 { get; set; }
        public string CREUSR_0 { get; set; }
        public string CRN_0 { get; set; }
        public string CRY_0 { get; set; }
        public string DADFCY_0 { get; set; }
        public byte DADFLG_0 { get; set; }
        public string DIE_0 { get; set; }
        public string DIE_1 { get; set; }
        public string DIE_10 { get; set; }
        public string DIE_11 { get; set; }
        public string DIE_12 { get; set; }
        public string DIE_13 { get; set; }
        public string DIE_14 { get; set; }
        public string DIE_15 { get; set; }
        public string DIE_16 { get; set; }
        public string DIE_17 { get; set; }
        public string DIE_18 { get; set; }
        public string DIE_19 { get; set; }
        public string DIE_2 { get; set; }
        public string DIE_3 { get; set; }
        public string DIE_4 { get; set; }
        public string DIE_5 { get; set; }
        public string DIE_6 { get; set; }
        public string DIE_7 { get; set; }
        public string DIE_8 { get; set; }
        public string DIE_9 { get; set; }
        public string FCY_0 { get; set; }
        public string FCYNAM_0 { get; set; }
        public string FCYSHO_0 { get; set; }
        public byte FINFLG_0 { get; set; }
        public string FINRSPFCY_0 { get; set; }
        public string GEOCOD_0 { get; set; }
        public string INSCTYFLG_0 { get; set; }
        public string IVYFCY_0 { get; set; }
        public short IVYFLG_0 { get; set; }
        public string LEG_0 { get; set; }
        public string LEGCPY_0 { get; set; }
        public byte MFGFLG_0 { get; set; }
        public string MFGWRH_0 { get; set; }
        public string MFPWRH_0 { get; set; }
        public string MFRWRH_0 { get; set; }
        public string NAF_0 { get; set; }
        public string PAYBAN_0 { get; set; }
        public byte PURFLG_0 { get; set; }
        public string RCPWRH_0 { get; set; }

        public string RTNWRH_0 { get; set; }
        public byte SALFLG_0 { get; set; }
        public string SCCWRH_0 { get; set; }
        public string SCOWRH_0 { get; set; }
        public string SHIWRH_0 { get; set; }
        public string TRAWRH_0 { get; set; }
        public string TRFWRH_0 { get; set; }
        public DateTime UPDDAT_0 { get; set; }
        public string UPDUSR_0 { get; set; }
        public string UVYCOD_0 { get; set; }
        public byte UVYDAY_0 { get; set; }
        public byte UVYDAY_1 { get; set; }
        public byte UVYDAY_2 { get; set; }
        public byte UVYDAY_3 { get; set; }
        public byte UVYDAY_4 { get; set; }
        public byte UVYDAY_5 { get; set; }
        public byte UVYDAY_6 { get; set; }
        public byte WRHFLG_0 { get; set; }
        public short WRHGES_0 { get; set; }
        int XA_SOFFSET_0 { get; set; }
        public short XB_FDXINT_0 { get; set; }
        public short XB_SHPINT_0 { get; set; }
        public short XB_UPSINT_0 { get; set; }
    }
}