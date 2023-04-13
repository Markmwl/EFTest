namespace EFTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MARK.T_CLEAR_CASHBUSINESS")]
    public partial class T_CLEAR_CASHBUSINESS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long L_BUSIN_NO { get; set; }

        public int? L_DATE { get; set; }

        public short? L_ADJUST_TYPE { get; set; }

        [StringLength(32)]
        public string VC_FUND_NAME { get; set; }

        [StringLength(16)]
        public string VC_FUND_CODE { get; set; }

        public int? L_FUND_ID_O32 { get; set; }

        [StringLength(64)]
        public string VC_ASSET_NAME { get; set; }

        [StringLength(20)]
        public string VC_ASSET_NO { get; set; }

        public int? L_ASSET_ID_O32 { get; set; }

        public DateTime? D_CREATE_TIME { get; set; }

        [StringLength(3)]
        public string VC_CURRENCY_NO { get; set; }

        public int? L_BEGIN_DATE { get; set; }

        [StringLength(1)]
        public string C_BEGIN_POINT { get; set; }

        public int? L_END_DATE { get; set; }

        [StringLength(1)]
        public string C_END_POINT { get; set; }

        [StringLength(1)]
        public string C_ENABLE_FLAG { get; set; }

        public decimal? EN_OCCUR_BALANCE { get; set; }

        [StringLength(1)]
        public string C_OPERATE_TYPE { get; set; }

        [StringLength(1)]
        public string C_STATUS { get; set; }

        public DateTime? D_CANCEL_TIME { get; set; }

        [StringLength(50)]
        public string L_OPERATOR_NO { get; set; }

        [StringLength(50)]
        public string L_CANCELLER_NO { get; set; }

        [StringLength(100)]
        public string VC_REMARKS { get; set; }

        [StringLength(40)]
        public string VC_IMPACT_AREA { get; set; }

        [StringLength(1)]
        public string C_SYNC_CHANGE_O32 { get; set; }

        [StringLength(1)]
        public string C_STATUS_O32 { get; set; }

        public long? L_BUSIN_NO_O32 { get; set; }

        [StringLength(1)]
        public string C_DEAL_FLAG_O32 { get; set; }

        [StringLength(20)]
        public string VC_UFX_STATUS { get; set; }
    }
}
