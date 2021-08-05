using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            var cete = new BondDeal();
            var repo = new RepoDeal();

            SaveInventory(cete);
            SaveInventory(repo);
        }

        private static void SaveInventory(IInventory inventory) =>
            Console.WriteLine("Saving to database");
    }
}
