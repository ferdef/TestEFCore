using System;

namespace TestDB.Models
{
    public class Wine
    {
        public Guid id {get; set;}
        public Family family {get; set;}
        public Contest contest {get; set;}
        public string name {get; set;}
        public string year {get; set;}
        public string type {get; set;}
    }
}