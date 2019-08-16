using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using FullstackPhoneBook.Domain.Core.Tags;
using System.ComponentModel.DataAnnotations;


namespace FullstackPhoneBook.EndPoints.MVC.Models
{
    public abstract class AddNewTagViewModel
    {
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 2)]
        public string Title { get; set; }
    }

    public class AddNewTagDisplayViewModel : AddNewTagViewModel
    {
        public List<Tag> TagsForDisplay { get; set; }
    }

    public class AddNewTagGetViewModel : AddNewTagViewModel
    {
        public String EnteredTag { get; set; }
    }
}
