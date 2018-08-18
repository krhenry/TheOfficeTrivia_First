using System.Threading.Tasks;
using TheOfficeTrivia_First.API.Models;

namespace TheOfficeTrivia_First.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);

         Task<User> Login(string Username, string password);

         Task<bool> UserExists(string username);
    }
}