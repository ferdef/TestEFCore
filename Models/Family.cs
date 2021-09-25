using System;
using System.ComponentModel.DataAnnotations;

namespace TestDB.Models
{
    public class Family
    {
        public Guid id {get; set;}
        [Required]
        public string name {get; set;}
    }
}