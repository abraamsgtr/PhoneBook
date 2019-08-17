using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using FullstackPhoneBook.Domain.Core.Tags;
using System.ComponentModel.DataAnnotations;


namespace FullstackPhoneBook.EndPoints.MVC.Models
{
    public abstract class PersonDetailViewModel
    {
        
    }

    public class GetPersonDetailViewModel : PersonDetailViewModel
    {
        public int Id { get; set; }
    }
}
