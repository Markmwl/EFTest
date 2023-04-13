namespace EFTest
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MarkContext : DbContext
    {
        public MarkContext()
            : base("name=MarkContext")
        {
        }

        public virtual DbSet<T_ACCOUNT> T_ACCOUNT { get; set; }
        public virtual DbSet<T_CDC_DEMO> T_CDC_DEMO { get; set; }
        public virtual DbSet<T_CLEAR_CASHBUSINESS> T_CLEAR_CASHBUSINESS { get; set; }
        public virtual DbSet<T_CLEAR_CASHBUSINESS_HIS> T_CLEAR_CASHBUSINESS_HIS { get; set; }
        public virtual DbSet<T_EMPLOYEE> T_EMPLOYEE { get; set; }
        public virtual DbSet<T_NULLZERO_TEST> T_NULLZERO_TEST { get; set; }
        public virtual DbSet<T_RUNLOG> T_RUNLOG { get; set; }
        public virtual DbSet<T_SYSUSER> T_SYSUSER { get; set; }
        public virtual DbSet<T_USER> T_USER { get; set; }
        public virtual DbSet<XXLUSER> XXLUSER { get; set; }
        public virtual DbSet<用户表> 用户表 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T_ACCOUNT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<T_ACCOUNT>()
                .Property(e => e.MONEY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<T_CDC_DEMO>()
                .Property(e => e.L_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<T_CDC_DEMO>()
                .Property(e => e.VC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<T_CDC_DEMO>()
                .Property(e => e.VC_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.VC_FUND_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.VC_FUND_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.VC_ASSET_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.VC_ASSET_NO)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.VC_CURRENCY_NO)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.C_BEGIN_POINT)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.C_END_POINT)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.C_ENABLE_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.EN_OCCUR_BALANCE)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.C_OPERATE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.C_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.L_OPERATOR_NO)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.L_CANCELLER_NO)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.VC_REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.VC_IMPACT_AREA)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.C_SYNC_CHANGE_O32)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.C_STATUS_O32)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.C_DEAL_FLAG_O32)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS>()
                .Property(e => e.VC_UFX_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.VC_FUND_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.VC_FUND_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.VC_ASSET_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.VC_ASSET_NO)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.VC_CURRENCY_NO)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.C_BEGIN_POINT)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.C_END_POINT)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.C_ENABLE_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.EN_OCCUR_BALANCE)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.C_OPERATE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.C_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.L_OPERATOR_NO)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.L_CANCELLER_NO)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.VC_REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.VC_IMPACT_AREA)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.C_SYNC_CHANGE_O32)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.C_STATUS_O32)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.C_DEAL_FLAG_O32)
                .IsUnicode(false);

            modelBuilder.Entity<T_CLEAR_CASHBUSINESS_HIS>()
                .Property(e => e.VC_UFX_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<T_EMPLOYEE>()
                .Property(e => e.VC_EMPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<T_EMPLOYEE>()
                .Property(e => e.VC_USERID)
                .IsUnicode(false);

            modelBuilder.Entity<T_EMPLOYEE>()
                .Property(e => e.VC_USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_EMPLOYEE>()
                .Property(e => e.VC_REALNAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_EMPLOYEE>()
                .Property(e => e.VC_SEX)
                .IsUnicode(false);

            modelBuilder.Entity<T_EMPLOYEE>()
                .Property(e => e.VC_PHONENUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<T_EMPLOYEE>()
                .Property(e => e.VC_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<T_NULLZERO_TEST>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<T_NULLZERO_TEST>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_NULLZERO_TEST>()
                .Property(e => e.SEX)
                .IsUnicode(false);

            modelBuilder.Entity<T_NULLZERO_TEST>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<T_RUNLOG>()
                .Property(e => e.VC_LOGTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<T_RUNLOG>()
                .Property(e => e.VC_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<T_RUNLOG>()
                .Property(e => e.CL_CLOB)
                .IsUnicode(false);

            modelBuilder.Entity<T_RUNLOG>()
                .Property(e => e.VC_LEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<T_USER>()
                .Property(e => e.VC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<T_USER>()
                .Property(e => e.VC_USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_USER>()
                .Property(e => e.VC_USERPASS)
                .IsUnicode(false);

            modelBuilder.Entity<T_USER>()
                .Property(e => e.VC_DEPNAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_USER>()
                .Property(e => e.VC_ISADMIN)
                .IsUnicode(false);

            modelBuilder.Entity<T_USER>()
                .Property(e => e.VC_CID)
                .IsUnicode(false);

            modelBuilder.Entity<T_USER>()
                .Property(e => e.VC_MID)
                .IsUnicode(false);

            modelBuilder.Entity<T_USER>()
                .Property(e => e.VC_ISDEL)
                .IsUnicode(false);
        }
    }
}
