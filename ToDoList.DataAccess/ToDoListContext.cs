using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.Models;

namespace ToDoList.DataAccess
{
    public class ToDoListContext : DbContext
    {
        public ToDoListContext(DbContextOptions<ToDoListContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<ToDo> ToDos { get; set; }
    }
}
