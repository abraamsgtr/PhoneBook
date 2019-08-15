using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullstackPhoneBook.Domain.Contracts.People;
using FullstackPhoneBook.Domain.Core.People;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullstackPhoneBook.EndPoints.MVC.Controllers
{
    public class HomeController : Controller    {
        private readonly IPersonRepository personRepository;

        public HomeController(IPersonRepository personRepository){
            this.personRepository = personRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()        {            personRepository.Add(new Person
            {
                FirstName = "Mohammad",
                LastName = "Aflaki",
                Email = "am823617@gmail.com",
                Address = "Orumia",
                Image = "my Image"
            });            return View();        }        public IActionResult About()        {            return View();        }    }
}
