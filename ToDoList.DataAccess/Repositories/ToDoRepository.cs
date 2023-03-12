using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Common;
using ToDoList.Entities.Types;
using ToDoList.Web.Graphql.Schema.Types;

namespace ToDoList.DataAccess.Repositories
{
    public class ToDoRepository
    {
        private readonly ToDoListContext _context;

        public ToDoRepository(ToDoListContext context)
        {
            _context = context;
        }

        public IQueryable<ToDoType> GetToDos()
        {
            return _context.ToDos.Include(todo => todo.Users).Select(todo => ToDoCommon.ToDoToToDoType(todo));
        }

        public async Task<ToDoType?> GetToDo(int id)
        {
            var todo = await _context.ToDos.Include(todo => todo.Users).FirstOrDefaultAsync(todo => todo.Id == id);
            if (todo == null)
            {
                return null;
            }
            return ToDoCommon.ToDoToToDoType(todo);
        }
    }
}
