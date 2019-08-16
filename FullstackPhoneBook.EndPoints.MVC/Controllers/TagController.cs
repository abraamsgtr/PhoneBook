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
using FullstackPhoneBook.Domain.Core.Tags;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullstackPhoneBook.EndPoints.MVC.Controllers
{
    public class TagController : Controller
    {
        private readonly ITagRepository tagRepository;

        public TagController(ITagRepository tagRepository)
        {
            this.tagRepository = tagRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            var tags = tagRepository.GetAll().ToList();
            return View(tags);
        }

        public IActionResult Add()
        {
            AddNewTagDisplayViewModel model = new AddNewTagDisplayViewModel();

            model.TagsForDisplay = tagRepository.GetAll().ToList();

            return View(model);
        }

        [HttpPost]

        public IActionResult Add(AddNewTagGetViewModel model)
        {
            if (ModelState.IsValid)
            {
                Tag tag = new Tag
                {
                    Title = model.Title,
                };

                tagRepository.Add(tag);
                return RedirectToAction("Index");
            }

            AddNewTagDisplayViewModel modelForDisplay = new AddNewTagDisplayViewModel
            {
                Title = model.Title
            };

            modelForDisplay.TagsForDisplay = tagRepository.GetAll().ToList();
            return View(modelForDisplay);
        }

        [Route("Tag/{id:int}")]

        public async Task<IActionResult> Delete(int id)
        {
            tagRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
