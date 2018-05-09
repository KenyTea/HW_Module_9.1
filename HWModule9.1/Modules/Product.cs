using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule9._1.Modules
{
    /*Создать абстрактный класс Товар с методами, позволяющими вывести на экран информацию о товаре,
а также определить, соответствует ли она искомому типу.*/

    public abstract class Product
    {
        public double Price { get; set; }
        public int Manufacturer { get; set; }
        public int Age { get; set; }

        Random rand = new Random();

        public abstract void PrintInfo();
        public abstract void Check();

    }
}
