using System;
using System.ComponentModel.DataAnnotations;

namespace TestDB.Models
{
    public class WineVote
    {
        // public Guid WineVoteId {get; set;}
        public Wine Wine {get; set;}
        public User Voter {get; set;}
        public Guid WineId {get; set;}
        public Guid VoterId {get; set;}
        [Required]
        public int value {get; set;}
    }
}