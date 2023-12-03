using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Data
{
    public class TodoApiContext : DbContext
    {
        public TodoApiContext (DbContextOptions<TodoApiContext> options)
            : base(options)
        {
        }

        public DbSet<TodoApi.Models.Tarea> Tarea { get; set; } = default!;
        public DbSet<TodoApi.Models.Estudiante> Estudiante { get; set; } = default!;
    }
}
