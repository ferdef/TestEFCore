using System;

namespace TestDB.Models
{
    public class PintxoVote
    {
        public Pintxo pintxo {get; set;}
        public User voter {get; set;}
        public int value {get; set;}
    }
}