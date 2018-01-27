using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Breed: {Breed}";
        }

    }
}
