using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using FullstackPhoneBook.Domain.Core.Tags;
using System.ComponentModel.DataAnnotations;

namespace FullstackPhoneBook.EndPoints.MVC.Models
{
    public abstract class AddNewPersonViewModel
    {
        [Required]
        [StringLength(maximumLength:50, MinimumLength = 2)]

        public string FirstName { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 2)]

        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "You must enter valid email address")]

        public string Email { get; set; }

        [StringLength(maximumLength: 500)]

        public string Address { get; set; }

        [Required]
        [StringLength(maximumLength: 21, MinimumLength = 10)]

        public string PhoneNumber { get; set; }

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
