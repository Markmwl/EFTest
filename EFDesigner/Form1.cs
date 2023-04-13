using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace EFDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var markContext = new MarkConnection())
            {
                //开事务
                using (var tran = markContext.Database.BeginTransaction())
                {
                    try
                    {
                        var aaa = markContext.用户表.ToList();
                        foreach (var item in aaa)
                        {
                            showlog(item);
                        }
                        用户表 yhb = markContext.用户表.Find("111");
                        showlog(yhb);

                        //删
                        //删单条
                        var name = new OracleParameter(":name", "EF");

                        //var t_yhb = markContext.用户表.SqlQuery(@"select * from 用户表 where NAME = :name", name).FirstOrDefault();
                        //markContext.用户表.Remove(t_yhb);
                        //markContext.Entry(yhb).State = System.Data.Entity.EntityState.Deleted;
                        //var o = markContext.SaveChanges();
                        //删集合
                        var dBSqlQuery = markContext.用户表.SqlQuery(@"select * from 用户表 where NAME = :name", name).ToList();
                        markContext.用户表.RemoveRange(dBSqlQuery);
                        markContext.Entry(yhb).State = System.Data.Entity.EntityState.Deleted;
                        var b = markContext.SaveChanges();

                        //增
                        var add_t = new 用户表() { ID = "111", NAME = "EF", AGE = "22", SEX = "女", ADDRESS = "上海", PHONENUMBER = "1234567" };
                        markContext.用户表.Add(add_t);
                        markContext.Entry(add_t).State = System.Data.Entity.EntityState.Added;
                        var a = markContext.SaveChanges();

                        //改
                        var upd_t = markContext.用户表.Find("111");
                        upd_t.PHONENUMBER = "6666666";
                        markContext.Entry(upd_t).State = System.Data.Entity.EntityState.Modified;
                        var c = markContext.SaveChanges();

                        //查
                        //查全部
                        var ggg = markContext.用户表.ToList();
                        //查单条根据id
                        用户表 yhb1 = markContext.用户表.Find("2");
                        //查多条
                        var dBSqlQuery3 = markContext.Database.SqlQuery<用户表>("select * from 用户表 where ID = :id", new OracleParameter(":id", "5")).ToList();
                        //此种查询无意义 - 因为是针对自己T使用sql进行查询
                        var dBSqlQuery1 = markContext.用户表.SqlQuery("select * from 用户表 where ID = :id", new OracleParameter(":id", "5")).ToList();
                        //等同于
                        var dBSqlQuery4 = markContext.用户表.Where(o => o.ID == "5").ToList();

                        //通过database查询映射对象
                        OracleParameter[] oracleParameters = new OracleParameter[] {
                            new OracleParameter(":id", "8"),
                            new OracleParameter(":name", "鸡十"),
                        };
                        var dBSqlQuery2 = markContext.Database.SqlQuery<用户表>("select * from 用户表 where ID = :id and NAME = :name", oracleParameters).ToList();
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        Debug.WriteLine(ex.Message);
                    }
                }
            }
        }
        void showlog(用户表 user)
        {
            Debug.WriteLine(DateTime.Now + "：" + string.Format("{0},{1},{2},{3},{4},{5}",
                user.ID, user.NAME, user.AGE, user.SEX, user.ADDRESS, user.PHONENUMBER));
        }
    }
}
