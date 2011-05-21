
namespace Entities.Abstract
{
    public interface ICrypt
    {
        string Encrypt(string plainText);
        string Decrypt(string cipherText);
    }
}
