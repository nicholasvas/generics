using System.Collections;
using System.Collections.Generic;
using System.Threading.Channels;

namespace SuperheroAgency
{
    internal class Program
    {
        //List<string> myList = new List<string>() { "Hello", "world", 1 };
        
        static void Main(string[] args)
        {
            Superhero Spiderman = new Superhero("Spiderman", "Peter Parker", Alignment.GOOD, 20);
            Console.WriteLine(Spiderman.Alias + Spiderman.SecretIdentity + Spiderman.Age + Spiderman.Alignment );

            int bookCount = 0;
            Stack<object> myStack = new Stack<object>();

            Spiderman.Lift("Spiderman");
            Spiderman.ReadMind("Spiderman");
            Spiderman.Hack("Spiderman");
            Spiderman.Fly("Spiderman");


            myStack.Push("book 1");
            myStack.Push("book 2");
            myStack.Push("book 3");
            myStack.Push(1);
            myStack.Pop();

            foreach (var book in myStack)
            {
                bookCount++;
                Console.WriteLine(book);
                
            }

            Console.WriteLine("You have " + bookCount + " items in the stack.");

         


        



            int[] intArray = { 1, 5, 2, 8, 6 };
        Console.WriteLine(GetLast(intArray)); // 6

        double[] doubleArray = { 10.5, 60.5, 2.2, 8.76, 6.1111 };
        Console.WriteLine(GetLast(doubleArray)); // 6.1111

        string[] stringArray = { "hello", "world", "it's", "northcoders!" };
        Console.WriteLine(GetLast(stringArray)); // "northcoders"

     
        }
       

       
        public static T GetLast<T>(T[] array)
        {
            return array[array.Length - 1];
        }

        //public static T GetLast<T>(T[] array) => array[^1];  ~ this is another way to do it

       
    }

    
    
}
