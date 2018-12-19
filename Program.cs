using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionnelle_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Votre Age?");
            int birth = int.Parse(Console.ReadLine());
            if (birth >= 18 && birth<=120)
            {
                Console.WriteLine($"Vous avez {birth} ans,vous êtes donc majeur.");
            }
            else if (birth<18 && birth>0)
            {
                Console.WriteLine($"Vous avez {birth} ans,vous êtes donc mineur.");
            }
            else
            {
                Console.WriteLine("Oops, une erreur est survenue");
            }


        }
    }
}
