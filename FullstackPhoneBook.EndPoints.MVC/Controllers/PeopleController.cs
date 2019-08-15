using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullstackPhoneBook.Domain.Core.People;
using Microsoft.AspNetCore.Mvc;
using FullstackPhoneBook.EndPoints.MVC.Models;
using FullstackPhoneBook.Domain.Contracts.Tags;
using System.IO;
using FullstackPhoneBook.Domain.Contracts.People;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullstackPhoneBook.EndPoints.MVC.Controllers
{
    public class PeopleController : Controller
    {

        private readonly ITagRepository tagRepository;
        private readonly IPersonRepository personRepository;

        public PeopleController(ITagRepository tagRepository, IPersonRepository personRepository)
        {
            this.tagRepository = tagRepository;
            this.personRepository = personRepository;
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
            if (ModelState.IsValid)
            {
                Person person1 = new Person
                {
                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    Email = person.Email,
                    Address = person.Address,
                    Tags = new List<PersonTag>(person.SelectedTag.Select(c=> new PersonTag
                    {
                        TagId = c
                    }).ToList())
                };

                if (person?.Image?.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        person.Image.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        person1.Image = Convert.ToBase64String(fileBytes);
                    }
                }

                personRepository.Add(person1);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
