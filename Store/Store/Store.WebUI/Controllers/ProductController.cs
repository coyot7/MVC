using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.Domain.Abstract;
using Store.Domain.Entities;
using Store.WebUI.Models;

namespace Store.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;

        public ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }

        public ViewResult Index(string category = null, int page = 1)
        {
            ProductsListViewModel viewModel = new ProductsListViewModel
            {
                Products = repository.Products
                  .OrderBy(x => x.ProductID)
                  .Skip((page - 1) * PageSize)
                  .Take(PageSize),
                PagingInfo = new PageInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                    repository.Products.Count() :
                    repository.Products.Where(x => x.Category == category).Count()
                }
            };
            return View(viewModel);
        }




        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product prod)
        {
            repository.CreateProduct(prod);
            return View("Success");
        }


        public ViewResult List(string category = null, int page = 1)
        {
            ProductsListViewModel viewModel = new ProductsListViewModel
            {
                Products = repository.Products
                .Where(x => x.Category == null || x.Category == category)
                .OrderBy(x => x.ProductID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PageInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                    repository.Products.Count() :
                    repository.Products.Where(x => x.Category == category).Count()
                },
                CurrentCategory = category
            };
            return View(viewModel);
        }

        public ActionResult Delete (int id)
        {
            repository.Delete(id);
            return View("Success");
        }
    }
}