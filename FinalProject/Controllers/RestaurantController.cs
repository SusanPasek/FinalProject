using FinalProject.Data;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: /<controller>/
        private ApplicationDbContext context;
        private object addRestaurantViewModel;
        private Restaurant newRestaurant;

        public RestaurantController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }


        public IActionResult Index()
        {

            List<Restaurant> restaurant = context.Restaurants.ToList();
            return View(restaurant);
        }
        //[Authorize(Roles = "admin")] 
        //(roles="admin"
        [HttpGet]
        public IActionResult Add()
        {
            AddRestaurantViewModel addRestaurantViewModel = new AddRestaurantViewModel();
            return View(addRestaurantViewModel);
        }
        [Authorize]
        [HttpPost]
        public IActionResult ProcessAddRestaurantForm(AddRestaurantViewModel addRestaurantViewModel)
        {
            if (ModelState.IsValid)
            {
                Restaurant newRestaurant = new Restaurant
                {
                    Name = addRestaurantViewModel.Name,
                    Location = addRestaurantViewModel.Location,
                    CuisineType = addRestaurantViewModel.CuisineType,
                    FullyMeatless = false
                    
                };
                context.Restaurants.Add(newRestaurant);
                context.SaveChanges();
                return Redirect("/Restaurant");
            }
            return View("Add", addRestaurantViewModel);
        }

        public IActionResult About(int id)
        {
            //this method takes an id of a restaurant
            //displays the details of that restaurant
            Restaurant restaurant = context.Restaurants.Find(id);
            return View(restaurant);
        }
    }
}
