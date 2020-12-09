using System;
using System.ComponentModel.DataAnnotations;

namespace FirstDB.Models
{
    public class Student
    {
        [Key]
        public int StudentId {get;set;}

        public string FirstName {get;set;}

        public string LastName {get;set;}

        public string Email {get;set;}

        public int FavoriteNumber {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.UtcNow;

        public DateTime UpdatedAt {get;set;} = DateTime.UtcNow;
    }
}