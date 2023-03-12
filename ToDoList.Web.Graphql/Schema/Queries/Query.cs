using ToDoList.DataAccess.Repositories;
using ToDoList.Entities.Types;
using ToDoList.Web.Graphql.Schema.Types;

namespace ToDoList.DataAccess.Schema.Queries
{
    public class Query
    {
        public IQueryable<UserType> GetUsers([Service] UserRepository userRepository)
        {
           return userRepository.GetUsers();
        }

        public async Task<UserType?> GetUser(int id, [Service] UserRepository userRepository)
        {
            var user = await userRepository.GetUser(id);
            return user;
        }

        public IQueryable<ToDoType> GetToDos([Service] ToDoRepository toDoRepository)
        {
            return toDoRepository.GetToDos();
        }

        public async Task<ToDoType?> GetToDo(int id, [Service] ToDoRepository toDoRepository)
        {
            var todo = await toDoRepository.GetToDo(id);
            return todo;
        }
    }
}
