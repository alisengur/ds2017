using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY24102017
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = "Lorem ipsum dolor sith amet, consectetur adipiscing elit. Nunc fringilla elit non ante fringilla, eu aliquet urna vulputate. Duis aliquam tristique tristique. Quisque lacinia malesuada ante, nec fringilla sapien mattis at. Nunc cursus placerat auctor. Nullam vitae erat a nisl tempor efficitur ut sit amet elit. Maecenas lectus turpis, posuere malesuada porttitor sit amet, lacinia sollicitudin nulla. Praesent ut egestas nulla, a bibendum eros. Suspendisse sed elit eget diam vulputate varius nec non sem. Ut eget velit tempor, finibus justo non, maximus tellus. Vestibulum urna metus, vestibulum imperdiet metus non, porttitor dignissim ipsum.";
            
            Huffman obj = new Huffman(val);

            Console.WriteLine("Sıkıştırılmamış boyutu :"+(8*val.Length));

            bool[] code = obj.encode("Lesson is finished");

            Console.WriteLine("Sıkıştırılmış boyutu"+code.Length);

            //for (int i = 0; i < code.Length; i++)
            //{
            //    Console.Write(code[i]?1:0);
            //}
            Console.WriteLine();


            Console.WriteLine(obj.decode(code));
        }
    }
}
