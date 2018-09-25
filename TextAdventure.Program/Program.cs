using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.GetFullPath("Text.txt");
            var name = path.Split(char.Parse(@"\"));
            Console.WriteLine(name[2]);
            Console.ReadLine();
        }
    }
}
