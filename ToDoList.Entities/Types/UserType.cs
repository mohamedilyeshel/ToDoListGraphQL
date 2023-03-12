using ToDoList.Entities.Models;

namespace ToDoList.Web.Graphql.Schema.Types
{
    public class UserType
    {
        public UserType()
        {
            ToDos = new List<ToDo>();
        }
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public DateTime BirthdayDate { get; set; }
        public List<ToDo> ToDos { get; set; }
    }
}
