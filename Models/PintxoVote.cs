using System;
using System.ComponentModel.DataAnnotations;

namespace TestDB.Models
{
    public class PintxoVote
    {
        // public Guid PintxoVoteId {get; set;}
        public Pintxo Pintxo {get; set;}
        public User Voter {get; set;}
        public Guid PintxoId {get; set;}
        public Guid VoterId {get; set;}
        [Required]
        public int Value {get; set;}
    }
}