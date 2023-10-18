using StaticTask.Models;
namespace StaticTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sozu dxil edin : ");
            string Word = Console.ReadLine();
            Console.Write("Axtarilacaq herfi daxil edin ,  eger soz daxil etsez ilk herf qebul edilecek : ");
            char ContainsChar = Console.ReadLine()[0];
            Console.WriteLine(Word.CustomContains(ContainsChar));
            Console.Write("Yoxlanilacaq tam ededi daxil et : ");
            int Prime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Prime.IsPrime());
            Console.Write("Yoxlanilacaq tam ededi daxil et : ");
            int Pow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Pow.IsPowOfTwo());
        }
    }
}