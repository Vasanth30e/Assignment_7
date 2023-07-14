using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList fruitList = new ArrayList();



            fruitList.Add("Apple");
            fruitList.Add("Banana");
            fruitList.Add("Cherry");
            fruitList.Add("Date");
            fruitList.Add("Elderberry");

            int count = fruitList.Count;

            Console.WriteLine("Total Number of Elements: " + count);

            Console.WriteLine("\n***List of Fruits***");
            foreach (var item in fruitList)
            {
                Console.WriteLine(" " + item);
            }

            Console.WriteLine("Enter the Fruit you want to chech");

            string fruitPresent = Console.ReadLine();

            bool isPresent = fruitList.Contains(fruitPresent);

            if(isPresent == false)
            {
                Console.WriteLine("It not contains");
            }

            else
            {
                Console.WriteLine("It Contains");
            }

            





            Console.WriteLine("\nInsert a Fruit");
            string addFruit = Console.ReadLine();

            fruitList.Insert(1, addFruit);

            Console.WriteLine("\n***After inserting a new Fruit***");
            foreach (var item in fruitList)
            {
                Console.WriteLine(" " + item);
            }

            Console.WriteLine("\nEnter the fruit you want to remove");
            string removeFruit = Console.ReadLine();

            fruitList.Remove(removeFruit);

            Console.WriteLine("\nAfter Removing Banana");
            foreach (var item in fruitList)
            {
                Console.WriteLine(" " + item);
            }


            Console.ReadKey();
        }
    }
}
