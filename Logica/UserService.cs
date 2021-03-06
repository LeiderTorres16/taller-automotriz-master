using Datos;
using Entidad;
using System.Linq;

namespace Logica
{
    public class UserService
    {
        private readonly TallerContext _context;

        public UserService(TallerContext context)=> _context = context;

        public User Validate(string userName, string password) 
        {
            return _context.Users.FirstOrDefault(t => t.UserName == userName && t.Password == password && t.Estado == "ADMIN");
        }
    }
}