using System;

namespace InventoryManagment
{
    class program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\Achal\source\repos\InventoryManagment\InventoryManagment\jsconfig1.json";

            FetchData fetchData = new FetchData();
            Inventory data = fetchData.Read(path);
            Console.WriteLine(data.typesofRice.name);
            Console.WriteLine(data.typesofRice.weight);
            Console.WriteLine(data.typesofRice.price);
        }
    }
}
