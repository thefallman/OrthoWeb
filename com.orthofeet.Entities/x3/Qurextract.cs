// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("QUREXTRACT", Schema = "TESTPROD")]
    [Index(nameof(Qurnum0), Name = "QUREXTRACT_QTX0")]
    public partial class Qurextract
    {
        [Required]
        [Column("QURNUM_0")]
        [StringLength(20)]
        public string Qurnum0 { get; set; }
        [Required]
        [Column("MGCCOLSRTK_0")]
        [StringLength(30)]
        public string Mgccolsrtk0 { get; set; }
        [Required]
        [Column("MGCCOLSRTA_0")]
        [StringLength(35)]
        public string Mgccolsrta0 { get; set; }
        [Column("MGCCOLSRTL_0", TypeName = "numeric(28, 2)")]
        public decimal Mgccolsrtl0 { get; set; }
        [Column("MGCCOLSRTD_0", TypeName = "datetime")]
        public DateTime Mgccolsrtd0 { get; set; }
        [Required]
        [Column("MGCCOL1_0")]
        [StringLength(35)]
        public string Mgccol10 { get; set; }
        [Required]
        [Column("MGCCOL2_0")]
        [StringLength(35)]
        public string Mgccol20 { get; set; }
        [Required]
        [Column("MGCCOL3_0")]
        [StringLength(35)]
        public string Mgccol30 { get; set; }
        [Required]
        [Column("MGCCOL4_0")]
        [StringLength(35)]
        public string Mgccol40 { get; set; }
        [Required]
        [Column("MGCCOL5_0")]
        [StringLength(35)]
        public string Mgccol50 { get; set; }
        [Required]
        [Column("MGCCOL6_0")]
        [StringLength(35)]
        public string Mgccol60 { get; set; }
        [Required]
        [Column("MGCCOL7_0")]
        [StringLength(35)]
        public string Mgccol70 { get; set; }
        [Required]
        [Column("MGCCOL8_0")]
        [StringLength(35)]
        public string Mgccol80 { get; set; }
        [Required]
        [Column("MGCCOL9_0")]
        [StringLength(35)]
        public string Mgccol90 { get; set; }
        [Required]
        [Column("MGCCOL10_0")]
        [StringLength(35)]
        public string Mgccol100 { get; set; }
        [Required]
        [Column("MGCCOL11_0")]
        [StringLength(35)]
        public string Mgccol110 { get; set; }
        [Required]
        [Column("MGCCOL12_0")]
        [StringLength(35)]
        public string Mgccol120 { get; set; }
        [Required]
        [Column("MGCCOL13_0")]
        [StringLength(35)]
        public string Mgccol130 { get; set; }
        [Required]
        [Column("MGCCOL14_0")]
        [StringLength(35)]
        public string Mgccol140 { get; set; }
        [Required]
        [Column("MGCCOL15_0")]
        [StringLength(35)]
        public string Mgccol150 { get; set; }
        [Required]
        [Column("MGCTIT1_0")]
        [StringLength(50)]
        public string Mgctit10 { get; set; }
        [Required]
        [Column("MGCTIT2_0")]
        [StringLength(50)]
        public string Mgctit20 { get; set; }
        [Required]
        [Column("MGCTIT3_0")]
        [StringLength(50)]
        public string Mgctit30 { get; set; }
        [Required]
        [Column("MGCTIT4_0")]
        [StringLength(50)]
        public string Mgctit40 { get; set; }
        [Required]
        [Column("MGCTIT5_0")]
        [StringLength(50)]
        public string Mgctit50 { get; set; }
        [Required]
        [Column("MGCTIT6_0")]
        [StringLength(50)]
        public string Mgctit60 { get; set; }
        [Required]
        [Column("MGCTIT7_0")]
        [StringLength(50)]
        public string Mgctit70 { get; set; }
        [Required]
        [Column("MGCTIT8_0")]
        [StringLength(50)]
        public string Mgctit80 { get; set; }
        [Required]
        [Column("MGCTIT9_0")]
        [StringLength(50)]
        public string Mgctit90 { get; set; }
        [Required]
        [Column("MGCTIT10_0")]
        [StringLength(50)]
        public string Mgctit100 { get; set; }
        [Required]
        [Column("MGCTIT11_0")]
        [StringLength(50)]
        public string Mgctit110 { get; set; }
        [Required]
        [Column("MGCTIT12_0")]
        [StringLength(50)]
        public string Mgctit120 { get; set; }
        [Required]
        [Column("MGCTIT13_0")]
        [StringLength(50)]
        public string Mgctit130 { get; set; }
        [Required]
        [Column("MGCTIT14_0")]
        [StringLength(50)]
        public string Mgctit140 { get; set; }
        [Required]
        [Column("MGCTIT15_0")]
        [StringLength(50)]
        public string Mgctit150 { get; set; }
        [Required]
        [Column("MGCCOL16_0")]
        [StringLength(35)]
        public string Mgccol160 { get; set; }
        [Required]
        [Column("MGCCOL17_0")]
        [StringLength(35)]
        public string Mgccol170 { get; set; }
        [Required]
        [Column("MGCCOL18_0")]
        [StringLength(35)]
        public string Mgccol180 { get; set; }
        [Required]
        [Column("MGCCOL19_0")]
        [StringLength(35)]
        public string Mgccol190 { get; set; }
        [Required]
        [Column("MGCCOL20_0")]
        [StringLength(35)]
        public string Mgccol200 { get; set; }
        [Required]
        [Column("MGCCOL21_0")]
        [StringLength(35)]
        public string Mgccol210 { get; set; }
        [Required]
        [Column("MGCCOL22_0")]
        [StringLength(35)]
        public string Mgccol220 { get; set; }
        [Required]
        [Column("MGCCOL23_0")]
        [StringLength(35)]
        public string Mgccol230 { get; set; }
        [Required]
        [Column("MGCCOL24_0")]
        [StringLength(35)]
        public string Mgccol240 { get; set; }
        [Required]
        [Column("MGCCOL25_0")]
        [StringLength(35)]
        public string Mgccol250 { get; set; }
        [Required]
        [Column("MGCCOL26_0")]
        [StringLength(35)]
        public string Mgccol260 { get; set; }
        [Required]
        [Column("MGCCOL27_0")]
        [StringLength(35)]
        public string Mgccol270 { get; set; }
        [Required]
        [Column("MGCCOL28_0")]
        [StringLength(35)]
        public string Mgccol280 { get; set; }
        [Required]
        [Column("MGCCOL29_0")]
        [StringLength(35)]
        public string Mgccol290 { get; set; }
        [Required]
        [Column("MGCCOL30_0")]
        [StringLength(35)]
        public string Mgccol300 { get; set; }
        [Required]
        [Column("MGCCOL31_0")]
        [StringLength(35)]
        public string Mgccol310 { get; set; }
        [Required]
        [Column("MGCCOL32_0")]
        [StringLength(35)]
        public string Mgccol320 { get; set; }
        [Required]
        [Column("MGCCOL33_0")]
        [StringLength(35)]
        public string Mgccol330 { get; set; }
        [Required]
        [Column("MGCCOL34_0")]
        [StringLength(35)]
        public string Mgccol340 { get; set; }
        [Required]
        [Column("MGCCOL35_0")]
        [StringLength(35)]
        public string Mgccol350 { get; set; }
        [Required]
        [Column("MGCCOL36_0")]
        [StringLength(35)]
        public string Mgccol360 { get; set; }
        [Required]
        [Column("MGCCOL37_0")]
        [StringLength(35)]
        public string Mgccol370 { get; set; }
        [Required]
        [Column("MGCCOL38_0")]
        [StringLength(35)]
        public string Mgccol380 { get; set; }
        [Required]
        [Column("MGCCOL39_0")]
        [StringLength(35)]
        public string Mgccol390 { get; set; }
        [Required]
        [Column("MGCCOL40_0")]
        [StringLength(35)]
        public string Mgccol400 { get; set; }
        [Required]
        [Column("MGCCOL41_0")]
        [StringLength(35)]
        public string Mgccol410 { get; set; }
        [Required]
        [Column("MGCCOL42_0")]
        [StringLength(35)]
        public string Mgccol420 { get; set; }
        [Required]
        [Column("MGCCOL43_0")]
        [StringLength(35)]
        public string Mgccol430 { get; set; }
        [Required]
        [Column("MGCCOL44_0")]
        [StringLength(35)]
        public string Mgccol440 { get; set; }
        [Required]
        [Column("MGCCOL45_0")]
        [StringLength(35)]
        public string Mgccol450 { get; set; }
        [Required]
        [Column("MGCCOL46_0")]
        [StringLength(35)]
        public string Mgccol460 { get; set; }
        [Required]
        [Column("MGCCOL47_0")]
        [StringLength(35)]
        public string Mgccol470 { get; set; }
        [Required]
        [Column("MGCCOL48_0")]
        [StringLength(35)]
        public string Mgccol480 { get; set; }
        [Required]
        [Column("MGCCOL49_0")]
        [StringLength(35)]
        public string Mgccol490 { get; set; }
        [Required]
        [Column("MGCCOL50_0")]
        [StringLength(35)]
        public string Mgccol500 { get; set; }
        [Required]
        [Column("MGCCOL51_0")]
        [StringLength(35)]
        public string Mgccol510 { get; set; }
        [Required]
        [Column("MGCCOL52_0")]
        [StringLength(35)]
        public string Mgccol520 { get; set; }
        [Required]
        [Column("MGCCOL53_0")]
        [StringLength(35)]
        public string Mgccol530 { get; set; }
        [Required]
        [Column("MGCCOL54_0")]
        [StringLength(35)]
        public string Mgccol540 { get; set; }
        [Required]
        [Column("MGCCOL55_0")]
        [StringLength(35)]
        public string Mgccol550 { get; set; }
        [Required]
        [Column("MGCCOL56_0")]
        [StringLength(35)]
        public string Mgccol560 { get; set; }
        [Required]
        [Column("MGCCOL57_0")]
        [StringLength(35)]
        public string Mgccol570 { get; set; }
        [Required]
        [Column("MGCCOL58_0")]
        [StringLength(35)]
        public string Mgccol580 { get; set; }
        [Required]
        [Column("MGCCOL59_0")]
        [StringLength(35)]
        public string Mgccol590 { get; set; }
        [Required]
        [Column("MGCCOL60_0")]
        [StringLength(35)]
        public string Mgccol600 { get; set; }
        [Required]
        [Column("MGCCOL61_0")]
        [StringLength(35)]
        public string Mgccol610 { get; set; }
        [Required]
        [Column("MGCCOL62_0")]
        [StringLength(35)]
        public string Mgccol620 { get; set; }
        [Required]
        [Column("MGCCOL63_0")]
        [StringLength(35)]
        public string Mgccol630 { get; set; }
        [Required]
        [Column("MGCCOL64_0")]
        [StringLength(35)]
        public string Mgccol640 { get; set; }
        [Required]
        [Column("MGCCOL65_0")]
        [StringLength(35)]
        public string Mgccol650 { get; set; }
        [Required]
        [Column("MGCCOL66_0")]
        [StringLength(35)]
        public string Mgccol660 { get; set; }
        [Required]
        [Column("MGCCOL67_0")]
        [StringLength(35)]
        public string Mgccol670 { get; set; }
        [Required]
        [Column("MGCCOL68_0")]
        [StringLength(35)]
        public string Mgccol680 { get; set; }
        [Required]
        [Column("MGCCOL69_0")]
        [StringLength(35)]
        public string Mgccol690 { get; set; }
        [Required]
        [Column("MGCCOL70_0")]
        [StringLength(35)]
        public string Mgccol700 { get; set; }
        [Required]
        [Column("MGCCOL71_0")]
        [StringLength(35)]
        public string Mgccol710 { get; set; }
        [Required]
        [Column("MGCCOL72_0")]
        [StringLength(35)]
        public string Mgccol720 { get; set; }
        [Required]
        [Column("MGCCOL73_0")]
        [StringLength(35)]
        public string Mgccol730 { get; set; }
        [Required]
        [Column("MGCCOL74_0")]
        [StringLength(35)]
        public string Mgccol740 { get; set; }
        [Required]
        [Column("MGCCOL75_0")]
        [StringLength(35)]
        public string Mgccol750 { get; set; }
        [Required]
        [Column("MGCCOL76_0")]
        [StringLength(35)]
        public string Mgccol760 { get; set; }
        [Required]
        [Column("MGCCOL77_0")]
        [StringLength(35)]
        public string Mgccol770 { get; set; }
        [Required]
        [Column("MGCCOL78_0")]
        [StringLength(35)]
        public string Mgccol780 { get; set; }
        [Required]
        [Column("MGCCOL79_0")]
        [StringLength(35)]
        public string Mgccol790 { get; set; }
        [Required]
        [Column("MGCCOL80_0")]
        [StringLength(35)]
        public string Mgccol800 { get; set; }
        [Required]
        [Column("MGCCOL81_0")]
        [StringLength(35)]
        public string Mgccol810 { get; set; }
        [Required]
        [Column("MGCCOL82_0")]
        [StringLength(35)]
        public string Mgccol820 { get; set; }
        [Required]
        [Column("MGCCOL83_0")]
        [StringLength(35)]
        public string Mgccol830 { get; set; }
        [Required]
        [Column("MGCCOL84_0")]
        [StringLength(35)]
        public string Mgccol840 { get; set; }
        [Required]
        [Column("MGCCOL85_0")]
        [StringLength(35)]
        public string Mgccol850 { get; set; }
        [Required]
        [Column("MGCCOL86_0")]
        [StringLength(35)]
        public string Mgccol860 { get; set; }
        [Required]
        [Column("MGCCOL87_0")]
        [StringLength(35)]
        public string Mgccol870 { get; set; }
        [Required]
        [Column("MGCCOL88_0")]
        [StringLength(35)]
        public string Mgccol880 { get; set; }
        [Required]
        [Column("MGCCOL89_0")]
        [StringLength(35)]
        public string Mgccol890 { get; set; }
        [Required]
        [Column("MGCCOL90_0")]
        [StringLength(35)]
        public string Mgccol900 { get; set; }
        [Required]
        [Column("MGCCOL91_0")]
        [StringLength(35)]
        public string Mgccol910 { get; set; }
        [Required]
        [Column("MGCCOL92_0")]
        [StringLength(35)]
        public string Mgccol920 { get; set; }
        [Required]
        [Column("MGCCOL93_0")]
        [StringLength(35)]
        public string Mgccol930 { get; set; }
        [Required]
        [Column("MGCCOL94_0")]
        [StringLength(35)]
        public string Mgccol940 { get; set; }
        [Required]
        [Column("MGCCOL95_0")]
        [StringLength(35)]
        public string Mgccol950 { get; set; }
        [Required]
        [Column("MGCCOL96_0")]
        [StringLength(35)]
        public string Mgccol960 { get; set; }
        [Required]
        [Column("MGCCOL97_0")]
        [StringLength(35)]
        public string Mgccol970 { get; set; }
        [Required]
        [Column("MGCCOL98_0")]
        [StringLength(35)]
        public string Mgccol980 { get; set; }
        [Required]
        [Column("MGCCOL99_0")]
        [StringLength(35)]
        public string Mgccol990 { get; set; }
        [Required]
        [Column("MGCTIT16_0")]
        [StringLength(50)]
        public string Mgctit160 { get; set; }
        [Required]
        [Column("MGCTIT17_0")]
        [StringLength(50)]
        public string Mgctit170 { get; set; }
        [Required]
        [Column("MGCTIT18_0")]
        [StringLength(50)]
        public string Mgctit180 { get; set; }
        [Required]
        [Column("MGCTIT19_0")]
        [StringLength(50)]
        public string Mgctit190 { get; set; }
        [Required]
        [Column("MGCTIT20_0")]
        [StringLength(50)]
        public string Mgctit200 { get; set; }
        [Required]
        [Column("MGCTIT21_0")]
        [StringLength(50)]
        public string Mgctit210 { get; set; }
        [Required]
        [Column("MGCTIT22_0")]
        [StringLength(50)]
        public string Mgctit220 { get; set; }
        [Required]
        [Column("MGCTIT23_0")]
        [StringLength(50)]
        public string Mgctit230 { get; set; }
        [Required]
        [Column("MGCTIT24_0")]
        [StringLength(50)]
        public string Mgctit240 { get; set; }
        [Required]
        [Column("MGCTIT25_0")]
        [StringLength(50)]
        public string Mgctit250 { get; set; }
        [Required]
        [Column("MGCTIT26_0")]
        [StringLength(50)]
        public string Mgctit260 { get; set; }
        [Required]
        [Column("MGCTIT27_0")]
        [StringLength(50)]
        public string Mgctit270 { get; set; }
        [Required]
        [Column("MGCTIT28_0")]
        [StringLength(50)]
        public string Mgctit280 { get; set; }
        [Required]
        [Column("MGCTIT29_0")]
        [StringLength(50)]
        public string Mgctit290 { get; set; }
        [Required]
        [Column("MGCTIT30_0")]
        [StringLength(50)]
        public string Mgctit300 { get; set; }
        [Required]
        [Column("MGCTIT31_0")]
        [StringLength(50)]
        public string Mgctit310 { get; set; }
        [Required]
        [Column("MGCTIT32_0")]
        [StringLength(50)]
        public string Mgctit320 { get; set; }
        [Required]
        [Column("MGCTIT33_0")]
        [StringLength(50)]
        public string Mgctit330 { get; set; }
        [Required]
        [Column("MGCTIT34_0")]
        [StringLength(50)]
        public string Mgctit340 { get; set; }
        [Required]
        [Column("MGCTIT35_0")]
        [StringLength(50)]
        public string Mgctit350 { get; set; }
        [Required]
        [Column("MGCTIT36_0")]
        [StringLength(50)]
        public string Mgctit360 { get; set; }
        [Required]
        [Column("MGCTIT37_0")]
        [StringLength(50)]
        public string Mgctit370 { get; set; }
        [Required]
        [Column("MGCTIT38_0")]
        [StringLength(50)]
        public string Mgctit380 { get; set; }
        [Required]
        [Column("MGCTIT39_0")]
        [StringLength(50)]
        public string Mgctit390 { get; set; }
        [Required]
        [Column("MGCTIT40_0")]
        [StringLength(50)]
        public string Mgctit400 { get; set; }
        [Required]
        [Column("MGCTIT41_0")]
        [StringLength(50)]
        public string Mgctit410 { get; set; }
        [Required]
        [Column("MGCTIT42_0")]
        [StringLength(50)]
        public string Mgctit420 { get; set; }
        [Required]
        [Column("MGCTIT43_0")]
        [StringLength(50)]
        public string Mgctit430 { get; set; }
        [Required]
        [Column("MGCTIT44_0")]
        [StringLength(50)]
        public string Mgctit440 { get; set; }
        [Required]
        [Column("MGCTIT45_0")]
        [StringLength(50)]
        public string Mgctit450 { get; set; }
        [Required]
        [Column("MGCTIT46_0")]
        [StringLength(50)]
        public string Mgctit460 { get; set; }
        [Required]
        [Column("MGCTIT47_0")]
        [StringLength(50)]
        public string Mgctit470 { get; set; }
        [Required]
        [Column("MGCTIT48_0")]
        [StringLength(50)]
        public string Mgctit480 { get; set; }
        [Required]
        [Column("MGCTIT49_0")]
        [StringLength(50)]
        public string Mgctit490 { get; set; }
        [Required]
        [Column("MGCTIT50_0")]
        [StringLength(50)]
        public string Mgctit500 { get; set; }
        [Required]
        [Column("MGCTIT51_0")]
        [StringLength(50)]
        public string Mgctit510 { get; set; }
        [Required]
        [Column("MGCTIT52_0")]
        [StringLength(50)]
        public string Mgctit520 { get; set; }
        [Required]
        [Column("MGCTIT53_0")]
        [StringLength(50)]
        public string Mgctit530 { get; set; }
        [Required]
        [Column("MGCTIT54_0")]
        [StringLength(50)]
        public string Mgctit540 { get; set; }
        [Required]
        [Column("MGCTIT55_0")]
        [StringLength(50)]
        public string Mgctit550 { get; set; }
        [Required]
        [Column("MGCTIT56_0")]
        [StringLength(50)]
        public string Mgctit560 { get; set; }
        [Required]
        [Column("MGCTIT57_0")]
        [StringLength(50)]
        public string Mgctit570 { get; set; }
        [Required]
        [Column("MGCTIT58_0")]
        [StringLength(50)]
        public string Mgctit580 { get; set; }
        [Required]
        [Column("MGCTIT59_0")]
        [StringLength(50)]
        public string Mgctit590 { get; set; }
        [Required]
        [Column("MGCTIT60_0")]
        [StringLength(50)]
        public string Mgctit600 { get; set; }
        [Required]
        [Column("MGCTIT61_0")]
        [StringLength(50)]
        public string Mgctit610 { get; set; }
        [Required]
        [Column("MGCTIT62_0")]
        [StringLength(50)]
        public string Mgctit620 { get; set; }
        [Required]
        [Column("MGCTIT63_0")]
        [StringLength(50)]
        public string Mgctit630 { get; set; }
        [Required]
        [Column("MGCTIT64_0")]
        [StringLength(50)]
        public string Mgctit640 { get; set; }
        [Required]
        [Column("MGCTIT65_0")]
        [StringLength(50)]
        public string Mgctit650 { get; set; }
        [Required]
        [Column("MGCTIT66_0")]
        [StringLength(50)]
        public string Mgctit660 { get; set; }
        [Required]
        [Column("MGCTIT67_0")]
        [StringLength(50)]
        public string Mgctit670 { get; set; }
        [Required]
        [Column("MGCTIT68_0")]
        [StringLength(50)]
        public string Mgctit680 { get; set; }
        [Required]
        [Column("MGCTIT69_0")]
        [StringLength(50)]
        public string Mgctit690 { get; set; }
        [Required]
        [Column("MGCTIT70_0")]
        [StringLength(50)]
        public string Mgctit700 { get; set; }
        [Required]
        [Column("MGCTIT71_0")]
        [StringLength(50)]
        public string Mgctit710 { get; set; }
        [Required]
        [Column("MGCTIT72_0")]
        [StringLength(50)]
        public string Mgctit720 { get; set; }
        [Required]
        [Column("MGCTIT73_0")]
        [StringLength(50)]
        public string Mgctit730 { get; set; }
        [Required]
        [Column("MGCTIT74_0")]
        [StringLength(50)]
        public string Mgctit740 { get; set; }
        [Required]
        [Column("MGCTIT75_0")]
        [StringLength(50)]
        public string Mgctit750 { get; set; }
        [Required]
        [Column("MGCTIT76_0")]
        [StringLength(50)]
        public string Mgctit760 { get; set; }
        [Required]
        [Column("MGCTIT77_0")]
        [StringLength(50)]
        public string Mgctit770 { get; set; }
        [Required]
        [Column("MGCTIT78_0")]
        [StringLength(50)]
        public string Mgctit780 { get; set; }
        [Required]
        [Column("MGCTIT79_0")]
        [StringLength(50)]
        public string Mgctit790 { get; set; }
        [Required]
        [Column("MGCTIT80_0")]
        [StringLength(50)]
        public string Mgctit800 { get; set; }
        [Required]
        [Column("MGCTIT81_0")]
        [StringLength(50)]
        public string Mgctit810 { get; set; }
        [Required]
        [Column("MGCTIT82_0")]
        [StringLength(50)]
        public string Mgctit820 { get; set; }
        [Required]
        [Column("MGCTIT83_0")]
        [StringLength(50)]
        public string Mgctit830 { get; set; }
        [Required]
        [Column("MGCTIT84_0")]
        [StringLength(50)]
        public string Mgctit840 { get; set; }
        [Required]
        [Column("MGCTIT85_0")]
        [StringLength(50)]
        public string Mgctit850 { get; set; }
        [Required]
        [Column("MGCTIT86_0")]
        [StringLength(50)]
        public string Mgctit860 { get; set; }
        [Required]
        [Column("MGCTIT87_0")]
        [StringLength(50)]
        public string Mgctit870 { get; set; }
        [Required]
        [Column("MGCTIT88_0")]
        [StringLength(50)]
        public string Mgctit880 { get; set; }
        [Required]
        [Column("MGCTIT89_0")]
        [StringLength(50)]
        public string Mgctit890 { get; set; }
        [Required]
        [Column("MGCTIT90_0")]
        [StringLength(50)]
        public string Mgctit900 { get; set; }
        [Required]
        [Column("MGCTIT91_0")]
        [StringLength(50)]
        public string Mgctit910 { get; set; }
        [Required]
        [Column("MGCTIT92_0")]
        [StringLength(50)]
        public string Mgctit920 { get; set; }
        [Required]
        [Column("MGCTIT93_0")]
        [StringLength(50)]
        public string Mgctit930 { get; set; }
        [Required]
        [Column("MGCTIT94_0")]
        [StringLength(50)]
        public string Mgctit940 { get; set; }
        [Required]
        [Column("MGCTIT95_0")]
        [StringLength(50)]
        public string Mgctit950 { get; set; }
        [Required]
        [Column("MGCTIT96_0")]
        [StringLength(50)]
        public string Mgctit960 { get; set; }
        [Required]
        [Column("MGCTIT97_0")]
        [StringLength(50)]
        public string Mgctit970 { get; set; }
        [Required]
        [Column("MGCTIT98_0")]
        [StringLength(50)]
        public string Mgctit980 { get; set; }
        [Required]
        [Column("MGCTIT99_0")]
        [StringLength(50)]
        public string Mgctit990 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}