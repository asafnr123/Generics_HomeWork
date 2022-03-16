using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HomeWork
{
    internal abstract class MainProp
    {
        public string Name { get; set; }

        public int Id { get; set; }


        protected int GiveIdNumber()
        {
            string tempId = "";
            Random r = new Random();

            while (tempId.Length < 6)
            {
                tempId += r.Next(1, 10).ToString();
            }

            Id = int.Parse(tempId);
            return Id;
        }

        
        


    }
}
