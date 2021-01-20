using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
          string[] isimler=new string [] {"enin","murat","berk"};
            Console.WriteLine(isimler[2]);

            isimler = new string[5];
            isimler[4] = "ilker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<string> { "enin", "murat", "berk" };
            Console.WriteLine(isimler2[0]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);
            
        }
    }
}
