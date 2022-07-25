using System;

namespace Servidor.Model
{
    public class Request :  IRequest 
    {
        private Priority priority;
        public Priority Priority { get; }

        private Guid requestId;
        public Guid RequestId { get; }

        Priority IRequest.priority => throw new NotImplementedException();

        public Request(Priority priority)
        {
            this.requestId = Guid.NewGuid();
            this.priority = priority;
        }
        
        void Process()  
        {
            Console.WriteLine($"Request {RequestId} with priority {Priority} have been processed");
        }

        void IRequest.Process()
        {
            throw new System.NotImplementedException();
        }
    }
}