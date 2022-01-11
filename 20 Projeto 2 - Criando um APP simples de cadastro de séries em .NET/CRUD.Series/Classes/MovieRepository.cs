namespace CRUD.TerrorMovies.Interfaces
{
    public class MovieRepository : IRepository<TerrorMovie>
    {

        private List<TerrorMovie> listMovie = new List<TerrorMovie>();
        public void Delete(int id)
        {
            listMovie[id].Delete();
        }

        public void Insert(TerrorMovie any)
        {
            listMovie.Add(any);
        }

        public List<TerrorMovie> List()
        {
            return listMovie;
        }

        public int NextId()
        {
            return listMovie.Count;
        }

        public TerrorMovie ReturnId(int id)
        {
            return listMovie[id];
        }

        public void Update(int id, TerrorMovie any)
        {
            listMovie[id] = any;
        }
    }
}