﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksEvents.Models
{
    public class UserModel : IdentityUser
    {
        public string  FirstName {get; set;}
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }

    }
}
