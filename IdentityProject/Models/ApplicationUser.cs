﻿using System;
using Microsoft.AspNetCore.Identity;

namespace IdentityProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

