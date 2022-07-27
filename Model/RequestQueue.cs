using System;
using System.Collections;
using System.Collections.Generic;

namespace Servidor.Model
{
    public class RequestQueue : Queue<Request>, IQueue 
    {
        private Queue<Request> currentQueue;

        Queue<Request> CurrentQueue { get => currentQueue; set => currentQueue = value; }

        public RequestQueue()
        {
            this.currentQueue = new Queue<Request>();
        }

        public RequestQueue(Queue<Request> requestQ)
        {
            this.currentQueue = requestQ;
        }
        /*
        public IRequest Pop()
        {
            Console.WriteLine($"Popping request");
            return new Request();
        }
        */

        public void SortByPriority()
        {
            Console.WriteLine($"Queue ordered by priority");
        }

        public void Push(IRequest request)
        {
            Console.WriteLine($"Push request");
            currentQueue.Enqueue((Request) request);
        }

        public IRequest Pop()
        {
            Console.WriteLine($"Pop request");
            return currentQueue.Dequeue();
        }

        public void PrintStatus()
        {
            Console.WriteLine($"Current Request:");

            foreach(Request currentR in currentQueue)
            {
                Console.WriteLine(currentR.ToString());
            }

        }

    }
}