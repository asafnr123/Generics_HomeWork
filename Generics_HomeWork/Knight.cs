using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HomeWork
{
    internal class Knight
    {
        private int Id { get; set; }

        private static ArrayList IdArray { get; set; }
        
        public string KnightName { get; set; }
        
        public string HairColor { get; set; }

        public bool IsOnHorse { get; set; }


        public Knight(string name)
        {
            IdArray = new ArrayList();
            KnightName = name;
            GiveIdNumber();
            


        }
        public override string ToString()
        {
            return $"ID: {Id}\n" +

             $"Knight: {KnightName}\n" +

                $"Hair Color: {HairColor}\n" +

                $"On The Horse: {IsOnHorse}";
        }


        private void GiveIdNumber()
        {
            string tempId = "";
            Random r = new Random();

            while (IdArray.Contains(Id) || tempId.Length < 6)
            {
                tempId += r.Next(1,10).ToString();
            }

            Id = int.Parse(tempId);
        }
    }
}
