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

    public class Toy : Product
    {
        public string Material { get; set; }
        
        public override void Check()
        {
            
        }

        public override void PrintInfo()
        {
            
        }
    }
}
