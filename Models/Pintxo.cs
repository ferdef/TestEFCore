using System;
using System.ComponentModel.DataAnnotations;

namespace TestDB.Models
{
    public class Pintxo
    {
        public Guid PintxoId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public Contest Context { get; set; }
        public User Creator { get; set; }

    }
}