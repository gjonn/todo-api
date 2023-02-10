using System;
using Microsoft.EntityFrameworkCore;
using todoapi;

namespace todoapi
{
    class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
            : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}