using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_9
{
    class Animal
    {
        // Автоматические свойства 
        public string Kind { get; set; }
        public int Behavior { get; set; }
        public string Habitat { get; set; }
        public string AnimalCover { get; set; }


        // Функция "Завести питомца"
        public void GetPet(Person human)
        {
            human.Pet = this;
            Console.WriteLine(human.Name + " завел(а) " + Kind);
        }

        // Функция "Проверка размера"
        public int checkSize;
        public void СheckSize()


        {

            if (checkSize > 100)
            {
                Console.WriteLine(Kind + " большое животное ");
            }
            else Console.WriteLine(Kind + " маленькое животное ");
        }
    }
}
