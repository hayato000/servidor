using System;

namespace Servidor.Model
{
    public class Request :  IRequest 
    {
        private Guid requestId;
        public Guid RequestId { get; }
        private Priority priority;
        public Priority Priority { get => priority; set => value = priority; }

        public Request()
        {
            this.requestId = Guid.NewGuid();
        }

        public Request(Priority priority)
        {
            this.requestId = Guid.NewGuid();
            this.priority = priority;
        }
        
        void IRequest.Process()
        {
            Console.WriteLine($"Request {RequestId} with priority {priority.ToString()} have been processed");
        }

        public override string ToString()
        {
            return $"Request {requestId} - Priority {priority.ToString()}";
        }
    }
}