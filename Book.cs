using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Exercise6_1
{
    public class Book
    {
        public int BookId { get; set; }
        public string Image { get; set; }
        public PriceOffer Price { get; set; }


        [Key]
        public string isbn { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime PublishedOn { get; set; }
    }
}
