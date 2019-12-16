using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main()
        {
            FamilyTree<Human> familytree = new FamilyTree<Human>();

            //добавляем родственников в коллекцию. 
            familytree.Add(new Human { Name = "Jackie Chan", Birtday = "07041954" });
            familytree.Add(new Human { Name = "Scott Adkins", Birtday = "17061976" });
            familytree.Add(new Human { Name = "Donnie Yen", Birtday = "27071963" });
            familytree.Add(new Human { Name = "Bruce Lee", Birtday = "27111940" });
            foreach (var item in familytree)
            {
                Console.WriteLine(item.Name, item.Birtday);
            }
            Console.WriteLine(new string('-', 20));

            //Donnie Yen погиб в бою, удаляем родственника из коллекции.
            familytree.Remove(new Human { Name = "Donnie Yen", Birtday = "27071963" });
            foreach (var item in familytree)
            {
                Console.WriteLine(item.Name, item.Birtday);
            }
            Console.WriteLine(new string('-', 20));

            //получаем количество родственников из коллекции.
            Console.WriteLine($"Количество родственников: {familytree.Count().ToString()}");

            Console.ReadKey();
        }
    }
}
