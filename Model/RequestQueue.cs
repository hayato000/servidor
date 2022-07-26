using System;
using System.Collections;
using System.Collections.Generic;

namespace Servidor.Model
{
    public class RequestQueue : IQueue
    {
        private Queue<IRequest> currentQueue;

        Queue<IRequest> CurrentQueue { get => currentQueue; set => currentQueue = value; }

        public IRequest Pop()
        {
            Console.WriteLine($"Popping request");
            return new Request();
        }

        public void SortByPriority()
        {
            Console.WriteLine($"Queue ordered by priority");
        }

        public void Push(IRequest request)
        {
            Console.WriteLine($"Push request");
        }

        IRequest IQueue.Pop()
        {
            throw new NotImplementedException();
        }
    }
}