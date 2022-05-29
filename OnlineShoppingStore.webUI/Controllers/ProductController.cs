using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingStore.domain.Abstract;

namespace OnlineShoppingStore.webUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly iProductRepository repository;
        public ProductController (iProductRepository repo)
        {
            repository=repo ;
        }
      public ViewResult List()
        {
            return View(repository .Products );
        }
	}
}