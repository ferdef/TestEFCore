using System;
using System.ComponentModel.DataAnnotations;

namespace TestDB.Models
{
    public class Family
    {
        public Guid FamilyId {get; set;}
        [Required]
        public string Name {get; set;}
    }
}