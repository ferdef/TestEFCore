using System;

namespace TestDB.Models
{
    public class Pintxo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Contest context { get; set; }
        public User creator { get; set; }

    }
}