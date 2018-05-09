using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule9._1.Modules
{
    /*Создать производные классы: 
     Спорт-инвентарь (название, цена, производитель, возраст, на который рассчитана)
     со своими методами вывода информации на экран, и определения соответствия искомому типу.
         */
         public enum SportsEq { Cycle, Scooter, Rollers, skateboard }

    public class SportsEquipment : Product
    {

        public override void Check()
        {
            
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Name " + Name);
            Console.WriteLine("Price " + Price);
            Console.WriteLine("Manufacturer " + Manufacturer);
            Console.WriteLine("Age " + Age);
        }
    }
}
