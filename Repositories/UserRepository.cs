using System.Collections.Generic;
using System.Linq;
using aspnetapiautenticacao.Models;

namespace aspnetapiautenticacao.Repositories
{

public static class UserRepository
{
    public static User Get(string username, string password)
    {
        var users = new List<User>();
        users.Add(new User { Id = 1, Username = "Lucas", Password = "Lucas", Role = "manager"});
        users.Add(new User { Id = 2, Username = "Jose", Password = "Jose", Role = "employee"});
        return users.Where( x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault();
    }
}
}
//simular usuário utilizando repositorio