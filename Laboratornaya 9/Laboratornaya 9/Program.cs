using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Person Ilia = new Person();
            Ilia.Name = "Илья";
            Ilia.Age = 18;


            Animal Fox = new Animal();
            Fox.Kind = "Лиса";
            Fox.checkSize = 50;


            Ilia.Ban();
            Fox.GetPet(Ilia);
            Ilia.Totem(Fox);
            Ilia.Character();
            Fox.СheckSize();
            Console.ReadKey();
        }
    }
}
