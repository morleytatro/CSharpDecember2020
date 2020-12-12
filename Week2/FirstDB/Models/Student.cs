using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FirstDB.Models
{
    public class Student
    {
        [Key]
        public int StudentId {get;set;}

        [Required(ErrorMessage="Please enter the first name.")]
        [Display(Name="First Name")]
        public string FirstName {get;set;}

        [Display(Name="Last Name")]
        public string LastName {get;set;}

        public string Email {get;set;}

        [Display(Name="Favorite Number")]
        public int FavoriteNumber {get;set;}

        public List<Book> Books {get;set;}
        // will allow us to reference steven.Books

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}