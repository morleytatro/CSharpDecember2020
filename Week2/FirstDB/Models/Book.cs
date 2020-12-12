using System;
using System.ComponentModel.DataAnnotations;

namespace FirstDB.Models
{
    public class Book
    {
        [Key]
        public int BookId {get;set;}

        [Required(ErrorMessage = "Please enter a title.")]
        public string Title {get;set;}

        [Required(ErrorMessage = "Please enter an author.")]
        public string Author {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [Required(ErrorMessage = "Please provide the owner ID.")]
        public int StudentId {get;set;}

        public Student Owner {get;set;}
    }
}