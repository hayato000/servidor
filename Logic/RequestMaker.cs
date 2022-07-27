using System;
using System.Collections.Generic;
using Servidor.Model;

namespace Servidor.Logic
{
    public class RequestMaker
    {

        public RequestQueue MakeRequests()
        {
            RequestQueue requestQ = new RequestQueue(new Queue<Request>());
            requestQ.Push(new Request(Priority.Low));
            requestQ.Push(new Request(Priority.High));
            requestQ.Push(new Request(Priority.High));
            requestQ.Push(new Request(Priority.Low));
            requestQ.Push(new Request(Priority.High));

            requestQ.PrintStatus();

            return requestQ;
        }
    }
}   