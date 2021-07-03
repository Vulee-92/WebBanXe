using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanXe.Model;

namespace WebBanXe.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        DBBanXeEntities2 db = new DBBanXeEntities2();
         // GET: Contact
         [HttpPost]
        public ActionResult Index(FormCollection contactForm)
        {

            CONTACT contact = new CONTACT();;
            var title = contactForm["title"];
            var content = contactForm["content"];
            var email = contactForm["email"];
        
            contact.Title = title;
            contact.Content = content;
            contact.Email = email;

            db.CONTACT.Add(contact);
          
            db.SaveChanges();
            ViewBag.Notice = "<div class='alert alert-success text-center text-dark' role='alert'>Gửi liên hệ thành công</div>";

            return View();
        }

        
    }
}