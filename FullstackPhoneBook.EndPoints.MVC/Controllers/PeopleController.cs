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
        private readonly IPersonTagRepository personTagRepository;

        public PeopleController(ITagRepository tagRepository, IPersonRepository personRepository, IPersonTagRepository personTagRepository)
        {
            this.tagRepository = tagRepository;
            this.personRepository = personRepository;
            this.personTagRepository = personTagRepository;
        }
        

        public IActionResult Add()
        {
            //HttpContext.Request
            AddNewPersonDisplayViewModel model = new AddNewPersonDisplayViewModel();

            model.TagsForDisplay = tagRepository.GetAll().ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Add(AddNewPersonGetViewModel model)
        {
            if (ModelState.IsValid)
            {
                Person person1 = new Person
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Address = model.Address,
                    Tags = new List<PersonTag>(model.SelectedTag.Select(c => new PersonTag
                    {
                        TagId = c
                    }).ToList())
                };

                //Console.WriteLine($"Tags = {person1.Tags[0].TagId}");

                if (model?.Image?.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        model.Image.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        person1.Image = Convert.ToBase64String(fileBytes);
                    }
                }

                personRepository.Add(person1);
                return RedirectToAction("Index");
            }

            AddNewPersonDisplayViewModel modelForDisplay = new AddNewPersonDisplayViewModel
            {
                Address = model.Address,
                Email = model.Email,
                LastName = model.LastName,
                FirstName = model.FirstName
            };

            modelForDisplay.TagsForDisplay = tagRepository.GetAll().ToList();
            return View(modelForDisplay);
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var people = personRepository.GetAll().ToList();
            return View(people);
        }

        [Route("People/{id:int}")]

        public async Task<IActionResult> Detail(int id)
        {
            var person = personRepository.Get(id);

            var tags = personTagRepository.GetAll().Where(c=>c.PersonId == id).ToList();

            List<string> tagsTitle = new List<string>();

            tagsTitle.Clear();

            //var tags = tagRepository.Get(id).Title.ToList();

            //person.PTags = tags.ToList();

            foreach (var item in tags)
            {
                tagsTitle.Add(tagRepository.Get(item.TagId).Title.ToString());
                Console.WriteLine($"t = {item.TagId}");
            }

            if (tagsTitle != null && tagsTitle.Count > 0)
            {
                foreach (var title in tagsTitle)
                {
                    Console.WriteLine($"TagsTitle = {title}");
                }

                person.PTags = tagsTitle;
            }
            
            //Console.WriteLine($"Personn = {person.Tags}");

            return View(person);
        }

        

        public async Task<IActionResult> Delete(int id)
        {
            personRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
