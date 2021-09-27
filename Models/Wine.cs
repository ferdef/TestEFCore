using System;
using System.ComponentModel.DataAnnotations;

namespace TestDB.Models
{
    public class Wine
    {
        public Guid WineId {get; set;}
        public Family Family {get; set;}
        public Contest Contest {get; set;}
        [Required]
        public string Name {get; set;}
        public string Year {get; set;}
        public string Type {get; set;}
    }
}