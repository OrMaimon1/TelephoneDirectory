using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Models
{
    internal interface IUserRepository
    {
        void Create(UsersModel usersModel);
        void Update(UsersModel usersModel);
        void Delete(int id);
        IEnumerable<UsersModel> GetAll();
        IEnumerable<UsersModel> GetUsersByValue(int id);
    }
}
