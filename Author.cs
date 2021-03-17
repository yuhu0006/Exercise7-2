using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Exercise6_1
{
    public class Author
    {
        
        public int AuhthorId { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public Book ImageUrl { get; set; }
    }
}
