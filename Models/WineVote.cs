using System;

namespace TestDB.Models
{
    public class WineVote
    {
        public Wine wine {get; set;}
        public User voter {get; set;}
        public int value {get; set;}
    }
}