﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIPatternDemo.Models
{
    [Table("book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? BookName { get; set; }

        [Required]
        public string? Author { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
