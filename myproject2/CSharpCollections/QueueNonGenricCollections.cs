using System;
using System.Collections;
using System.Text;

namespace MyProject1.CSharpCollections
{
    class QueueNonGenricCollections
    {
        static void Main(String[] args)
        {
            //creating Queue
            //it is a FIFO ( first in first out ) structure
            Queue queue = new Queue();

            //Elemets
            queue.Enqueue("one");
            queue.Enqueue("two");
            queue.Enqueue("three");
            queue.Enqueue("four");
            queue.Enqueue("five");

            queue.Dequeue();

            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
