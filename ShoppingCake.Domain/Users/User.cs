﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCake.Domain.Users
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
    }
}
