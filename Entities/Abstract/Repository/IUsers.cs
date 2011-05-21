
namespace Entities.Abstract.Repository
{
    public interface IUsers
    {

        string ConnectionString { get; set; }

        UserCollection GetAll();
        bool Insert(User user);
        bool Update(User user);
        bool Delete(User user);
    }
}
