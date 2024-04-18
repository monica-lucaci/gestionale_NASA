namespace NASA_gestionale_task.Services
{
    public interface IService<T>
    {
        IEnumerable<T> PrendiliTutti();
    }
}
