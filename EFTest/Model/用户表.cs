namespace EFTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MARK.用户表")]
    public partial class 用户表
    {
        [StringLength(20)]
        public string ID { get; set; }

        [StringLength(20)]
        public string NAME { get; set; }

        [StringLength(2)]
        public string SEX { get; set; }

        [StringLength(3)]
        public string AGE { get; set; }

        [StringLength(50)]
        public string ADDRESS { get; set; }

        [StringLength(15)]
        public string PHONENUMBER { get; set; }
    }
}
