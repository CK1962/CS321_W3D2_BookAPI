using System;
using System.ComponentModel.DataAnnotations;

namespace CS321_W3D2_BookAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public Author Author { get; set; }
    }
}
