namespace KPS_DojoM_API.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> All();   
        T? GetValue(int id);
        T Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
