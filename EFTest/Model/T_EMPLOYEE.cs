namespace EFTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MARK.T_EMPLOYEE")]
    public partial class T_EMPLOYEE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(30)]
        public string VC_EMPCODE { get; set; }

        [StringLength(30)]
        public string VC_USERID { get; set; }

        [StringLength(50)]
        public string VC_USERNAME { get; set; }

        [StringLength(50)]
        public string VC_REALNAME { get; set; }

        [StringLength(5)]
        public string VC_SEX { get; set; }

        public byte? N_AGE { get; set; }

        [StringLength(20)]
        public string VC_PHONENUMBER { get; set; }

        [StringLength(100)]
        public string VC_ADDRESS { get; set; }
    }
}
