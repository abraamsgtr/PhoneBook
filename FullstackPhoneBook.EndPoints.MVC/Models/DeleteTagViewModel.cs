using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using FullstackPhoneBook.Domain.Core.Tags;
using System.ComponentModel.DataAnnotations;


namespace FullstackPhoneBook.EndPoints.MVC.Models
{
    public abstract class DeleteTagViewModel
    {
        
    }

    public class DeleteTheTagViewModel : DeleteTagViewModel
    {
        public int TagId { get; set; }
    }
}

