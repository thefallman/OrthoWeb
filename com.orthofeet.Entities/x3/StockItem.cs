using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.orthofeet.Entities
{
    [Table("STOCK", Schema = "PROD")]
    public class StockItem
    {
        [Key]
        public int ROWID        { get; set; }
        public string	STOFCY_0    { get; set; }
        public decimal	STOCOU_0        { get; set; }
        public string	OWNER_0     { get; set; }
        public string	ITMREF_0    { get; set; }
        public string	LOT_0       { get; set; }
        public string	SLO_0       { get; set; }
        public string	BPSLOT_0    { get; set; }
        public string	PALNUM_0    { get; set; }
        public string	CTRNUM_0    { get; set; }
        public string	STA_0       { get; set; }
        public string	LOC_0       { get; set; }
        public string	LOCTYP_0    { get; set; }
        public byte	LOCCAT_0        { get; set; }
        public string	WRH_0       { get; set; }
        public string	SERNUM_0    { get; set; }

        public string	PCU_0       { get; set; }
        public decimal	PCUSTUCOE_0     { get; set; }
        public decimal	QTYPCU_0        { get; set; }
        public decimal	QTYSTU_0        { get; set; }
        public decimal	QTYSTUACT_0     { get; set; }
        public string	PCUORI_0    { get; set; }
        public decimal	QTYPCUORI_0     { get; set; }
        public decimal	QTYSTUORI_0     { get; set; }
        public string	QLYCTLDEM_0 { get; set; }
        public decimal	CUMALLQTY_0     { get; set; }
        public decimal	CUMALLQTA_0     { get; set; }
        public decimal	CUMWIPQTY_0     { get; set; }
        public decimal	CUMWIPQTA_0     { get; set; }
        public byte	CUNLOKFLG_0     { get; set; }
        public string	CUNLISNUM_0 { get; set; }
        public int	EXPNUM_0            { get; set; }

        public string	CREUSR_0    { get; set; }
        public string	UPDUSR_0    { get; set; }
        
        public DateTime	RCPDAT_0    { get; set; }        
        public DateTime	UPDDAT_0    { get; set; }
        public DateTime	CREDAT_0    { get; set; }        
        public short	EDTFLG_0    { get; set; }
        public DateTime	LASRCPDAT_0 { get; set; }
        public DateTime	LASISSDAT_0 { get; set; }
        public DateTime	LASCUNDAT_0 { get; set; }
               
    }
}