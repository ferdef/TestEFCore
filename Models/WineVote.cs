using System;
using System.ComponentModel.DataAnnotations;

namespace TestDB.Models
{
    public class WineVote
    {
        public Wine wine {get; set;}
        public User voter {get; set;}
        [Required]
        public int value {get; set;}
    }
}