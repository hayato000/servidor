namespace Servidor.Model
{
    interface IRequest
    {
        Priority priority { get; }
        void Process();
    }
}