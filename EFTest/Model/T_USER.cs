namespace EFTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MARK.T_USER")]
    public partial class T_USER
    {
        [Key]
        [StringLength(256)]
        public string VC_ID { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_USERNAME { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_USERPASS { get; set; }

        [StringLength(256)]
        public string VC_DEPNAME { get; set; }

        [Required]
        [StringLength(1)]
        public string VC_ISADMIN { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_CID { get; set; }

        public DateTime D_CDATE { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_MID { get; set; }

        public DateTime D_MDATE { get; set; }

        [Required]
        [StringLength(1)]
        public string VC_ISDEL { get; set; }
    }
}
