using Servidor.Model;

namespace Servidor.Logic
{
    public class RequestMaker
    {

        public RequestQueue MakeRequests()
        {
            RequestQueue requestQ = new RequestQueue();
            requestQ.Push(new Request());
            requestQ.Push(new Request());
            requestQ.Push(new Request());
            requestQ.Push(new Request());
            requestQ.Push(new Request());

            return requestQ;
        }
    }
}