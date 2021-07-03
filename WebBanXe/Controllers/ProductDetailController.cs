using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanXe.DAO;

namespace WebBanXe.Controllers
{
    public class ProductDetailController : Controller
    {
        // GET: ProductDetail
        public ActionResult Index()
        {
            dynamic model = new ExpandoObject();
            model.ProductDetails = ProductDetailDAO.getAllCar();
            model.Img = ProductDAO.getAllCar_img();
            return View(model);
        }
    }
}