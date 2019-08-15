using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using FullstackPhoneBook.Domain.Core.Tags;

namespace FullstackPhoneBook.EndPoints.MVC.Models
{
    public abstract class AddNewPersonViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public IFormFile Image { get; set; }
    }

    public class AddNewPersonDisplayViewModel : AddNewPersonViewModel
    {
        

        public List<Tag> TagsForDisplay { get; set; }
    }

    public class AddNewPersonGetViewModel : AddNewPersonViewModel
    {
        

        public List<int> SelectedTag { get; set; }
    }
}
