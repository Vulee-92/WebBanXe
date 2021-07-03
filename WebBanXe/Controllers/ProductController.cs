using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanXe.DAO;
using WebBanXe.ViewModel;

namespace WebBanXe.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var viewModel = new List<ProductViewModel>();

            var Products = ProductDAO.getAllCar();
            if (Products?.Any() ?? false)
            {
                var Images = ProductDAO.getAllCar_img();

                viewModel = (from product in Products
                            select new ProductViewModel
                            {
                                IdProduct = product.IdProduct,
                                Images = (from image in Images
                                          where image.IdProduct == product.IdProduct
                                          select new ProductImageViewModel
                                          {
                                              LinkImg = image.LinkImg
                                          })?.ToList() ?? new List<ProductImageViewModel>()
                            })?.ToList() ?? new List<ProductViewModel>();
            }
            return View(viewModel);
        }
    }
}