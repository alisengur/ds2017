using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY19092017
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operations<int> obj = new Operations<int>();
            //obj.field = 5;
            //obj.array[0] = 3;
            //obj.array[1] = 7;
            //obj.array[2] = 5;



            //Operations<string> obj1 = new Operations<string>();
            //obj1.array[0] = "veli";
            //obj1.array[1] ="ali";
            //obj1.array[2] = "ayse";
            //obj1.field = "bes";
            ////Console.WriteLine(obj.name);
            //obj.yazdir();

            //Console.WriteLine(obj.sentence());
            //Console.WriteLine(obj1.sentence());

            //obj.displayArray();

            //Console.WriteLine(obj1.max());

            Operations<Car> obj2 = new Operations<Car>();
            obj2.array[0] = new Car("20PAU20", 2005, "Murat", 0.5);
            obj2.array[1] = new Car("63UFA63", 2017, "Porsche", 3.5);
            obj2.array[2] = new Car("35IZM35", 2014, "Mercedes", 3.0);

            Console.WriteLine(obj2.max());
             

        }
    }
}
