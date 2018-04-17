
using ProposalManageSystem.Models.Bean;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProposalManageSystem.Controllers {
    public class Demo01Controller : Controller {
        // GET: Demo01
        public ActionResult Index () {
            return View();
        }

        //接收Ajax测试
        public string getString () {
            return "hello world!";
        }

        //连接数据库测试
        public string getDatabase () {
            //string conn_str = "server=(local);user id=sa;password=13361;database=proposal";
            //SqlConnection connection = new SqlConnection(conn_str);
            string sql = "insert into about(name) values('封装后再一次插入')";
            SqlConnection connection = DatabaseUtil.getConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            //SqlCommand command = new SqlCommand("insert into about(name) values('我的第一个连接数据库的.Net程序')",connection);
            string ret = "";
            if (command.ExecuteNonQuery() > 0) {
                ret = "数据库插入成功";
            }
            else {
                ret = "数据库没有插入，出问题了";
            }
            DatabaseUtil.closeConnection(connection);
            return ret;
        }

        public ActionResult showDemoView () {
            string req1 = Request["a"];
            ViewData["req"] = "这是ViewData传递过来的文字";
            return View("demoView");
        }

    }
}