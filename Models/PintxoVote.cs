using System;
using System.ComponentModel.DataAnnotations;

namespace TestDB.Models
{
    public class PintxoVote
    {
        public Pintxo pintxo {get; set;}
        public User voter {get; set;}
        [Required]
        public int value {get; set;}
    }
}