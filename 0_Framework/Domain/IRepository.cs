namespace _0_Framework.Domain;

public interface IRepository<TKey,T> where T : class
{
 T? Get(TKey key);
 List<T> Get();
 void Create(T  entity);
 void SaveChanges();

}

