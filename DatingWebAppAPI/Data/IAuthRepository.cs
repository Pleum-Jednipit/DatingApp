using System.Threading.Tasks;
using DatingWebAppAPI.Models;

namespace DatingWebAppAPI.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user,string passoword);

         Task<User> Login(string username, string password);

         Task<bool> UserExists(string username);
    }
}