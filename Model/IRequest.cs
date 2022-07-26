namespace Servidor.Model
{
    public interface IRequest
    {
        Priority Priority { get; set; }
        void Process();
    }
}