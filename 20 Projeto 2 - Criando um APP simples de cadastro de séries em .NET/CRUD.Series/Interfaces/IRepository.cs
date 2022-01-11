namespace CRUD.TerrorMovies.Interfaces
{
    public interface IRepository<T>
    {
         List<T> List();
         T ReturnId(int id);
         void Insert(T entity);
         void Delete(int id);
         void Update(int id, T entity);
        int NextId();
    }
}