namespace Servidor.Model
{
    public interface IQueue
    {
        void Push(IRequest request);

        IRequest Pop();

        void SortByPriority();
    }
}