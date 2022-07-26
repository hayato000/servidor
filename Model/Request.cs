using System;

namespace Servidor.Model
{
    public class Request :  IRequest 
    {
        private Guid requestId;
        public Guid RequestId { get; }
        private Priority priority;
        Priority IRequest.Priority { get => priority; set => value = priority; }

        public Request()
        {
            this.requestId = Guid.NewGuid();
        }
        
        void IRequest.Process()
        {
            Console.WriteLine($"Request {RequestId} with priority {priority} have been processed");
        }
    }
}