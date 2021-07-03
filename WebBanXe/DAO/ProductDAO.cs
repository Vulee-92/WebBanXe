using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBanXe.Model;

namespace WebBanXe.DAO
{
    public class ProductDAO
    {
        
        public static List<PRODUCT> getAllCar()
        {
            List<PRODUCT> list = new List<PRODUCT>();
            using (DBBanXeEntities2 db = new DBBanXeEntities2())
            {
                list = db.PRODUCT.ToList();
               
            }
            return list;
        }
        public static List<IMG_PRODUCT> getAllCar_img()
        {
            List<IMG_PRODUCT> list = new List<IMG_PRODUCT>();
            using (DBBanXeEntities2 db = new DBBanXeEntities2())
            {
                list = db.IMG_PRODUCT.ToList();

            }
            return list;
        }

    }

}