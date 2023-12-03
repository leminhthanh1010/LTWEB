using LTWProject.Library;
using MyClass.DAO;
using MyClass.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace LTWProject.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection field)
        {
            UsersDAO usersDAO = new UsersDAO();

            String username = field["username"];
            String password = XString.ToMD5(field["password"]);
            //so sanh thong tin nguoi dung
            Users row_user = usersDAO.getRow(username, "customer");
            String strErr = "";
            if (row_user == null)
            {
                strErr = "Tên đăng nhập không tồn tại";
                ViewBag.Error = "<span class='text-danger'>" + strErr + "</div";
                return View("Login");
            }
            else
            {
                return RedirectToAction("Index", "Site");
            }

        }       
    }
}