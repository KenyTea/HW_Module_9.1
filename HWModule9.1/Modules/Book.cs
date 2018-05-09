using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule9._1.Modules
{
    /*Создать производные классы: 
      Книга (название, автор, цена, издательство, возраст, на который рассчитана)
      со своими методами вывода информации на экран, и определения соответствия искомому типу.*/

    public enum Authors { Pushkin, Chehov, Dostaevskiy, Bulgakov}
    public enum Boooks { Skazka, Fentazy, Rasskath, Poema }

    public class Book : Product
    {
        private Random rand = new Random();
        public Authors Author { get; set; }


        public Book()
        {
            Author = (Authors)rand.Next(0, 3);
        }

        public override void Check()
        {

        }

        public override void PrintInfo()
        {
            Console.WriteLine("Name " + Name);
            Console.WriteLine("Author " + Author);
            Console.WriteLine("Price " + Price);
            Console.WriteLine("Manufacturer " + Manufacturer);
            Console.WriteLine("Age " + Age);
        }
    }
}
