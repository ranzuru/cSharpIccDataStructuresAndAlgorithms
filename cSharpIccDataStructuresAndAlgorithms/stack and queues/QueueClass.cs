using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.stack_and_queues
{
    class QueueClass
    {
        public static void Main()
        {
            Person person1 = new Person(1, "William Bonney");
            Person person2 = new Person(2, "Jesse James");
            Person person3 = new Person(3, "Sundance Kid");

            // FIFO - First In, First Out
            Queue<Person> queue = new Queue<Person>(); 

            Console.WriteLine("Count: " + queue.Count + "\n");

            Console.WriteLine("Performed Enqueue");
            queue.Enqueue(person1); // queue: person1
            queue.Enqueue(person2); // queue: person1, person2 (top to bottom)
            queue.Enqueue(person3); // queue: person1, person2, person3
            queue.Enqueue(person1); // queue: person1, person2, person3, person1

            foreach (var person in queue)
            {
                Console.WriteLine("[" + person.id + "] " + person.name);
            }
            Console.WriteLine("Count: " + queue.Count + "\n");
            
            Console.WriteLine("Performed Dequeue");
            queue.Dequeue(); // queue: person2, person3, person1
            foreach (var person in queue)
            {
                Console.WriteLine("[" + person.id + "] " + person.name);
            }

            
            Console.WriteLine("\nPeek: " + queue.Peek().name); // Peek - retrieve 1st value in the queue
        }
    }
}
