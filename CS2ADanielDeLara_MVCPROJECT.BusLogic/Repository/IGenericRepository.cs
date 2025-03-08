namespace CS2ADanielDeLara_MVCPROJECT.BusLogic.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
    }
}
