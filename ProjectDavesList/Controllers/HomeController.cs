using ProjectDavesList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectDavesList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Robert & Dave's List";
            // Bring in the view model
            ItemViewModel viewModel = new ItemViewModel();
            DateTime dt = new DateTime(2008, 3, 9, 16, 5, 7, 123);
         

            // Variable to grab data
            var itemData = ItemHolder.GetItem();

            // Use LINQ to get Data from ItemHolder
            var itemGetter01 = itemData.Where(i => i.Type == itemTypes.Housing).ToList();
            var itemGetter02 = itemData.Where(i => i.Type == itemTypes.Furniture).ToList();
            var itemGetter03 = itemData.Where(i => i.Type == itemTypes.Electronics).ToList();
            var itemGetter04 = itemData.Where(i => i.Type == itemTypes.Toys).ToList();
            var itemGetter05 = itemData.Where(i => i.Type == itemTypes.Automobiles).ToList();
            var itemGetter06 = itemData.Where(i => i.Type == itemTypes.Services).ToList();

            viewModel.MyList = itemGetter01;
            viewModel.MyList2 = itemGetter02;
            viewModel.MyList3 = itemGetter03;
            viewModel.MyList4 = itemGetter04;
            viewModel.MyList5 = itemGetter05;
            viewModel.MyList6 = itemGetter06;

            return View(viewModel);
        }

        public ActionResult Housing()
        {
            ViewBag.Message = "Welcome to Robert & Dave's List";
            // Bring in the view model
            ItemViewModel viewModel = new ItemViewModel();       
            // Variable to grab data
            var itemData = ItemHolder.GetItem();
            // Use LINQ to get Data from ItemHolder
            var itemGetter01 = itemData.Where(i => i.Type == itemTypes.Housing).ToList();
            viewModel.MyList = itemGetter01;

            return View(viewModel);
        }

        public ActionResult Furniture()
        {
            ViewBag.Message = "Welcome to Robert & Dave's List";
            // Bring in the view model
            ItemViewModel viewModel = new ItemViewModel();
            // Variable to grab data
            var itemData = ItemHolder.GetItem();
            // Use LINQ to get Data from ItemHolder
            var itemGetter02 = itemData.Where(i => i.Type == itemTypes.Furniture).ToList();
            viewModel.MyList2 = itemGetter02;

            return View(viewModel);
        }

        public ActionResult Electronics()
        {
            ViewBag.Message = "Welcome to Robert & Dave's List";
            // Bring in the view model
            ItemViewModel viewModel = new ItemViewModel();
            // Variable to grab data
            var itemData = ItemHolder.GetItem();
            // Use LINQ to get Data from ItemHolder
            var itemGetter03 = itemData.Where(i => i.Type == itemTypes.Electronics).ToList();
            viewModel.MyList3 = itemGetter03;

            return View(viewModel);
        }

        public ActionResult Toys()
        {
            ViewBag.Message = "Welcome to Robert & Dave's List";
            // Bring in the view model
            ItemViewModel viewModel = new ItemViewModel();
            // Variable to grab data
            var itemData = ItemHolder.GetItem();
            // Use LINQ to get Data from ItemHolder
            var itemGetter04 = itemData.Where(i => i.Type == itemTypes.Toys).ToList();
            viewModel.MyList4 = itemGetter04;

            return View(viewModel);
        }


        public ActionResult Automobiles()
        {
            ViewBag.Message = "Welcome to Robert & Dave's List";
            // Bring in the view model
            ItemViewModel viewModel = new ItemViewModel();
            // Variable to grab data
            var itemData = ItemHolder.GetItem();
            // Use LINQ to get Data from ItemHolder
            var itemGetter05 = itemData.Where(i => i.Type == itemTypes.Automobiles).ToList();
            viewModel.MyList5 = itemGetter05;

            return View(viewModel);
        }
        public ActionResult Services()
        {
            ViewBag.Message = "Welcome to Robert & Dave's List";
            // Bring in the view model
            ItemViewModel viewModel = new ItemViewModel();
            // Variable to grab data
            var itemData = ItemHolder.GetItem();
            // Use LINQ to get Data from ItemHolder
            var itemGetter06 = itemData.Where(i => i.Type == itemTypes.Services).ToList();
            viewModel.MyList6 = itemGetter06;

            return View(viewModel);
        }
    }
}