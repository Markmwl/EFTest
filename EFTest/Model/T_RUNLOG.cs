namespace EFTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MARK.T_RUNLOG")]
    public partial class T_RUNLOG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long L_ID { get; set; }

        public DateTime D_DATE { get; set; }

        [Required]
        [StringLength(200)]
        public string VC_LOGTYPE { get; set; }

        [StringLength(4000)]
        public string VC_CONTENT { get; set; }

        public string CL_CLOB { get; set; }

        [StringLength(20)]
        public string VC_LEVEL { get; set; }

        public long? L_MULTIJOBID { get; set; }

        public long? L_JOBID { get; set; }
    }
}
