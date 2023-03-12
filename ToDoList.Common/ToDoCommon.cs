using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.Models;
using ToDoList.Entities.Types;
using ToDoList.Web.Graphql.Schema.Types;

namespace ToDoList.Common
{
    public static class ToDoCommon
    {
        public static ToDoType ToDoToToDoType(ToDo todo)
        {
            return new ToDoType
            {
                Id = todo.Id,
                Content = todo.Content,
                IsDone = todo.IsDone,
                User = todo.User,
                UserId = todo.UserId,
            };
        }
    }
}
