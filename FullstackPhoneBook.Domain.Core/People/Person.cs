﻿using FullstackPhoneBook.Domain.Core.Phones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FullstackPhoneBook.Domain.Core.People
{
    public class Person: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public List<string> PTags { get; set; }

        public string PhoneNumber { get; set; }


        public List<Phone> Phones { get; set; }


        public List<PersonTag> Tags { get; set; }
    }
}
