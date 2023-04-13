# Entity Framework

## 1.配置

### 1.1 vs版本

 VS 2017-15.9.24

### 1.2 .NET版本

.NET Framework 4.5

### 1.3 ODTforVS2017版本

ODTforVS2017_122011 

#### 1.3.1 ODTforVS2017配置

①. PL  执行安装路径下E:\Install_application_file\ODTforVS2017_122011\asp.net\SQL\InstallAllOracleASPNETProviders.sql文件，选择 新建 -> 命令窗口 后按@回车选择该sql文件即可。

②. 替换安装路径下E:\Install_application_file\ODTforVS2017_122011\network\admin\tnsnames.ora文件为Oracle的tnsnames.ora文件（创建项目新建连接点搜索时会提示是否替换）。

③. NuGet包：

1.EntityFramework 6.4.4

2.Oracle.ManagedDataAccess 12.2.20230118

3.Oracle.ManagedDataAccess.EntityFramework 12.2.20230118

④. packages.config：

~~~~xml
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="EntityFramework" version="6.4.4" targetFramework="net45" />
  <package id="Oracle.ManagedDataAccess" version="12.2.20230118" targetFramework="net45" />
  <package id="Oracle.ManagedDataAccess.EntityFramework" version="12.2.20230118" targetFramework="net45" />
</packages>
~~~~

## 2. CodeFirst - 代码优先

①. 添加ADO.NET实体数据模型

②. 选择 来自数据库的 Code first

③. 选择表和视图即可生成对应模型

④. 若需要更新模型则需要在新建ADO.NET实体数据模型后将对应生成主控制文件中操作模型转移到主模型中去或者删除模型在重新创建

⑤. 使用

~~~~c#
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace EFTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var markContext = new MarkContext())
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
                        var dBSqlQuery1 = markContext.用户表.SqlQuery("select * from 用户表 where ID = :id",new OracleParameter(":id","5")).ToList();
                        //等同于
                        var dBSqlQuery4 = markContext.用户表.Where(o=>o.ID == "5").ToList();

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
~~~~



## 3. Designer - 设计器优先

①. 添加ADO.NET实体数据模型

②. 选择 来自数据库的 EF设计器

③. 选择表和视图即可生成一个 *.edmx文件，该文件中就是对应实体操作模型

④. 更新模型：双击edmx文件即可打开模型浏览器窗口

⑤. 右键模型浏览器窗口中edmx选择从数据库更新模型即可增删改刷新对应实体模型，保存即可生效。

⑥. 使用

~~~~c#
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
~~~~

