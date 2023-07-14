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

            //Total Count
            Console.WriteLine("Total Number of Elements: " + count);

            Console.WriteLine("\n***List of Fruits***");
            foreach (var item in fruitList)
            {
                Console.WriteLine(" " + item);
            }

            //Checking the list if the fruit list contains the entered fruit or not
            Console.WriteLine("\nEnter the Fruit you want to check that if the Fruit list Contains Or Not: \t");
            string fruitPresent = Console.ReadLine();
            bool isPresent = fruitList.Contains(fruitPresent);
            if(isPresent == false)
            {
                Console.WriteLine("\nIt not contains");
            }

            else
            {
                Console.Write($"\n\"It Contains the fruit\" \n The Fruit that is entered by the user is \'{fruitPresent}\'\n");
            }

            //Inserting the Fruit
            Console.WriteLine("\nInsert a Fruit");
            string addFruit = Console.ReadLine();

            fruitList.Insert(1, addFruit);

            Console.WriteLine("\n***After inserting a new Fruit***");
            foreach (var item in fruitList)
            {
                Console.WriteLine(" " + item);
            }

            Console.WriteLine($"\nInserted Fruit is {addFruit}");

            //Removing the fruit
            Console.WriteLine("\nEnter the fruit you want to remove");
            string removeFruit = Console.ReadLine();

            fruitList.Remove(removeFruit);

            Console.WriteLine("\nAfter Removing Banana");
            foreach (var item in fruitList)
            {
                Console.WriteLine(" " + item);
            }

            Console.WriteLine($"\nRemoved Fruit is {removeFruit}");

            Console.ReadKey();
        }
    }
}
