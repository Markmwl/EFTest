namespace EFTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MARK.T_CDC_DEMO")]
    public partial class T_CDC_DEMO
    {
        [Key]
        public decimal L_ID { get; set; }

        public DateTime D_DATE { get; set; }

        [StringLength(50)]
        public string VC_DESC { get; set; }

        [StringLength(50)]
        public string VC_CONTENT { get; set; }
    }
}
