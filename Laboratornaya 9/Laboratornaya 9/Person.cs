using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_9
{
    class Person
    {
        // Автоматические свойства
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal Pet { get; set; }

        //Создали публичное свойство, которое ставит ограничение на возраст 
        public bool Limitation
        {
            get
            {
                if (Age >= 18)
                {
                    return true;
                }
                else return false;
               
            }
        }

        // Создаем функцию проверки на существование 
       public void Сheck()
        {

            if (Age < 0)
            {
                 Console.WriteLine ("Вы не существуете");
            }
            else Console.WriteLine ("Вы существуете");
        }


        // Создаем функцию "Тотемное животное"
        string totem;
        public void Totem(Animal totemchik)
        {
            totem = totemchik.Kind;
        }

        // Создаем функцию запрещающую человеку с именем "Живодер" иметь животное 
       public void Ban()
        {

            if (Name == "Живодер")
            {
                 Console.WriteLine("Вам нельзя иметь животное");
            }
            else Console.WriteLine("Вам можно иметь животное");
        }

        //Создаем функцию "Характер", ставим void, что бы не возращало значение 
        public void Character()
        {

            if (totem == "Крокодил")
            {
                Console.WriteLine(Name + " человек смелый ");
            }
            else if (totem == "Лиса")
            {
                Console.WriteLine(Name + " человек заботливый ");
            }
        }
    }
}
