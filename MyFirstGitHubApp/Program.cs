using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubApp
{
     // This is master branch
    class Program
    {
        static void Main(string[] args)
        {
            //Made by Svetoslav Kadiev
            Console.WriteLine("Hello GitHub World!");
            Console.WriteLine("Christmas branch!");
            Console.WriteLine("Reunion!");
             
            int i = 0;
            i++;

            Person pers = new Person() { Name = "Svetoslav Kadiev", Age = 36, ID="8106082200" };
       
            Console.WriteLine(pers.Name);

            // Read line
            Console.ReadLine();
             
             /// opa
        }
    }
}
