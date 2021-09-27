using System;
using System.ComponentModel.DataAnnotations;

namespace TestDB.Models
{
    public class User
    {
        public Guid UserId {get; set;}
        [Required]
        public string Email {get; set;}
        public string Password {get; set;}
        [Required]
        public string Name {get; set;}
        public Family Family {get; set;}
    }
}