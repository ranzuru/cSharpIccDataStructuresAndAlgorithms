using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.stack_and_queues
{
    class StackClass
    {
        public static void Main()
        {
            Person person1 = new Person(1, "William Bonney");
            Person person2 = new Person(2, "Jesse James");
            Person person3 = new Person(3, "Sundance Kid");

            // LIFO - Last In, First Out 
            Stack<Person> queue = new Stack<Person>();

            Console.WriteLine("Count: " + queue.Count + "\n");

            Console.WriteLine("Performed Push");
            queue.Push(person1); // stack: person1
            queue.Push(person2); // stack: person2, person1 (top to bottom)
            queue.Push(person3); // stack: person3, person2, person1
            queue.Push(person1); // stack: person1, person3, person2, person1

            foreach (var person in queue)
            {
                Console.WriteLine("[" + person.id + "] " + person.name);
            }
            Console.WriteLine("Count: " + queue.Count + "\n");

            Console.WriteLine("Performed Pop");
            queue.Pop(); // stack: person3, person2, person1
            foreach (var person in queue)
            {
                Console.WriteLine("[" + person.id + "] " + person.name);
            }


            Console.WriteLine("\nPeek: " + queue.Peek().name); // Peek - retrieve 1st value in the queue
        }
    }
}
