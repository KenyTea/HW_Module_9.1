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

    public class Toy : Product
    {
        private Random rand = new Random();
        public Materials Material { get; set; }

        public Toy()
        {
            Material = (Materials)rand.Next(0, 3);
        }

        public override void Check()
        {

        }

        public override void PrintInfo()
        {
            Console.WriteLine("Name " + Name);
            Console.WriteLine("Price " + Price);
            Console.WriteLine("Manufacturer " + Manufacturer);
            Console.WriteLine("Material " + Material);
            Console.WriteLine("Age " + Age);
        }
    }
}
