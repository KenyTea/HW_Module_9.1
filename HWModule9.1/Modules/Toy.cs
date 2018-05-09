using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule9._1.Modules
{
    /*Создать производные классы: 
      Игрушка (название, цена, производитель, материал, возраст, на который рассчитана)
      со своими методами вывода информации на экран, и определения соответствия искомому типу.*/

    public enum Materials { Plastic, Metal, Wood, Aluminum }
    public enum ForToys { Car, Doll, KubicRubic, Yula }

    public class Toy : Product
    {
        public Materials Material { get; set; }
        

        public override void Check(Type type)
        {
            Console.WriteLine(type.GetType());
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Name -" + Name);
            Console.WriteLine("Price -" + Price);
            Console.WriteLine("Manufacturer -" + Manufacturer);
            Console.WriteLine("Material -" + Material);
            Console.WriteLine("Age -" + Age);
        }
    }
}
