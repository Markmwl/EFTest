namespace EFTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MARK.T_NULLZERO_TEST")]
    public partial class T_NULLZERO_TEST
    {
        public decimal ID { get; set; }

        [StringLength(64)]
        public string NAME { get; set; }

        public byte? AGE { get; set; }

        [StringLength(5)]
        public string SEX { get; set; }

        [StringLength(100)]
        public string ADDRESS { get; set; }

        public short? COUNT { get; set; }
    }
}
