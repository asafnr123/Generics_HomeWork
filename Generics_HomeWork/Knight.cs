using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HomeWork
{
    internal class Knight : MainProp
    {
        public string Name { get; set; }
        public int Id { get; set; }
        
        
        public string HairColor { get; set; }

        public bool IsOnHorse { get; set; }

        public Knight(string name)
        {
            Name = name;
            Id = GiveIdNumber();

        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Id: {Id}\n" +
                $"Hair Color: {HairColor}\n" +
                $"On Horse: {IsOnHorse}";
        }
    }
}
