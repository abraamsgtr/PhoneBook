using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullstackPhoneBook.Domain.Core.People;
using Microsoft.AspNetCore.Mvc;
using FullstackPhoneBook.EndPoints.MVC.Models;
using FullstackPhoneBook.Domain.Contracts.Tags;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullstackPhoneBook.EndPoints.MVC.Controllers
{
    public class PeopleController : Controller
    {

        private readonly ITagRepository tagRepository;

        public PeopleController(ITagRepository tagRepository)
        {
            this.tagRepository = tagRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            //HttpContext.Request
            AddNewPersonDisplayViewModel model = new AddNewPersonDisplayViewModel();

            model.TagsForDisplay = tagRepository.GetAll().ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Add(AddNewPersonGetViewModel person)
        {
            Console.WriteLine($"Image = {person.Image.ToString()}");
            return View();
        }
    }
}
