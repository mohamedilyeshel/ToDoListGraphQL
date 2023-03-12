using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.Models;
using ToDoList.Web.Graphql.Schema.Types;

namespace ToDoList.Common
{
    public static class UserCommon
    {
        public static UserType UserToUserType (User user)
        {
            return new UserType
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                BirthdayDate = user.BirthdayDate,
                Email = user.Email,
                ToDos = user.ToDos
            };
        }
    }
}
