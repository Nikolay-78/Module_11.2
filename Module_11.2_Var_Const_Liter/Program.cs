using System;

namespace Module_11._2_Var_Const_Liter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Myname = "Василиса";
            const string Myname2 = "Мартин";         
            Console.WriteLine("\t Меня зовут {0}. \n \t А мою собаку {1}.", Myname, Myname2);
            Console.WriteLine("\t Я играю со своей собакой. \n \t Мартин громко лает и резвится.");
            Console.ReadKey();
        }
    }
}
