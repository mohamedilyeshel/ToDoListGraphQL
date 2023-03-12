using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Common;
using ToDoList.Web.Graphql.Schema.Types;

namespace ToDoList.DataAccess.Repositories
{
    public class UserRepository
    {
        private readonly ToDoListContext _context;

        public UserRepository(ToDoListContext context)
        {
            _context = context;
        }

        public IQueryable<UserType> GetUsers() 
        {
            return _context.Users.Include(u => u.ToDos).Select(user => UserCommon.UserToUserType(user));
        }

        public async Task<UserType?> GetUser(int id)
        {
            var user = await _context.Users.Include(u => u.ToDos).FirstOrDefaultAsync(u => u.Id == id);
            if(user == null) 
            {
                return null;
            }
            return UserCommon.UserToUserType(user);
        }
    }
}
