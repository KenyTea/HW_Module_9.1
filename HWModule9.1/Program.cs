using HWModule9._1.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule9._1
{
    /*Задание 7
1.	Создать абстрактный класс Товар с методами, позволяющими вывести на экран информацию о товаре,
а также определить, соответствует ли она искомому типу.
2.	Создать производные классы: 
Игрушка (название, цена, производитель, материал, возраст, на который рассчитана), 
Книга (название, автор, цена, издательство, возраст, на который рассчитана), 
Спорт-инвентарь (название, цена, производитель, возраст, на который рассчитана),
со своими методами вывода информации на экран, и определения соответствия искомому типу.
3.	Создать базу (массив) из n товаров, вывести полную информацию из базы на экран,
а также организовать поиск товаров определенного типа.
*/
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();

            creator.GenerateToys();
            creator.GenerateBooks();
            creator.GenerateSportEquipments();

            creator.PrintAll();

            Toy toy = new Toy();


            

        }
    }
}
