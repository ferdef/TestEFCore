using System;
using System.ComponentModel.DataAnnotations;

namespace TestDB.Models
{
    public class User
    {
        public Guid id {get; set;}
        [Required]
        public string email {get; set;}
        public string password {get; set;}
        [Required]
        public string name {get; set;}
        public Family family {get; set;}
    }
}