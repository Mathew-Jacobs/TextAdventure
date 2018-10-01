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
            var words = path.Split(char.Parse(@"\"));
            var name = words[2];
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
