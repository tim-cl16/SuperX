using System.Runtime.CompilerServices;

namespace superXDev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SuperX sup = new SuperX();
            Console.Write($@"
quelle fonction lancé : 
    D -> SeDéconnecté() : ");
            switch (Console.ReadKey().KeyChar)
            {
                case 'd':
                    sup.SeDeconnecter();
                    break;
            }
        }
    }
}