using System;
using System.Linq;
using System.Threading;
using Servidor.Logic;
using Servidor.Model;

namespace Servidor
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Servidor!");
            RequestMaker maker = new RequestMaker();
            RequestQueue requestQ = maker.MakeRequests();

            int age = 0;

            while(true)
            {
                requestQ.PrintStatus();
                if(requestQ.Count > 0)
                {
                    IRequest lowReq = requestQ.FirstOrDefault(x => x.Priority == Priority.Low);
                    if(lowReq != null)
                    {
                        if(age > 3)
                        {
                            lowReq.Priority = Priority.High;
                            age = 0;
                        }
                        else
                        {
                            age++;
                        }
                    }
                    requestQ.SortByPriority(); //TBD
                    IRequest req = requestQ.Pop();
                    req.Process();
                }
                Thread.Sleep(2000);
            }

        }
    }
}
