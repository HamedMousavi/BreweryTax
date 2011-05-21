
namespace Entities.Abstract.Repository
{
    public interface IUserSettings
    {
        bool Save(User user);
        bool LoadByUserId(User user);
        bool Insert(User user);
        bool Delete(User user);
    }
}
