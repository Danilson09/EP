using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class ItemsController : Controller
    {

        // to add view right click on method name(create) and add view
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]//when you submit a form he is triggering a post
        public IActionResult Create(CreateItemViewModel data) //same class used by the template to create the view
        {
            try
            {
                ViewBag.Message = "Item added successfully";

            }

            catch (Exception ex)
            { 
                ViewBag.Message = "Item was not added successfully. Please check inputs"
            }

            //call the itemservice additem method
            return View();
        }
    }
}
