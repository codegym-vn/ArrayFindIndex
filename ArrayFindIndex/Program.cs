using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFindIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayStudents = { "Anders","Maria","Thomas","Hardy","Pedro","Alonso","Sven","Aria",
                "Roland","Paolo","Lino","Mario","John","Jean","Simon","Rene","Lucia","Sergio","Yoshi","Hari"
            };
            Console.WriteLine("Students List: ");
            foreach (var item in arrayStudents)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.Write("Enter student's name: ");
            string searchString = Console.ReadLine();
            int index = Array.IndexOf(arrayStudents, searchString);
            if (index == -1)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine("Student Name: {0} - Position: {1}", searchString, index);
            }
            Console.ReadKey();
        }
    }
}
