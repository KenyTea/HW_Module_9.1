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

    public class Book : Product
    {
         public string Author { get; set; }
       
        public override void Check()
        {

        }

        public override void PrintInfo()
        {

        }
    }
}
