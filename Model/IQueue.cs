namespace Servidor.Model
{
    interface IQueue
    {
        void Push(IRequest request);

        IRequest pop();

        void SortByPriority();
    }
}