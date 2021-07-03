using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanXe.Model;

namespace WebBanXe.DAO
{
    public class ContactDAO : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        public static List<CONTACT> getAllCar()
        {
            List<CONTACT> list = new List<CONTACT>();
            using (DBBanXeEntities2 db = new DBBanXeEntities2())
            {
                list = db.CONTACT.ToList();

            }
            return list;
        }

    }
}