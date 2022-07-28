using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birleştirme
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Console.WriteLine("Adınızı Giriniz");
            string FırstName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Soyadınızı Giriniz");
            string LastName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("İsminiz :" + FırstName + LastName);



            Console.ReadKey();
        }
    }
}
    

