using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HomeWork
{
    internal class Sword : MainProp
    {
        public string Name { get; set; }    
        public int Id { get; set; }

        public Sword(string name)
        {
            Name = name;
            Id = GiveIdNumber();
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Id: {Id}";
        }


    }
}
