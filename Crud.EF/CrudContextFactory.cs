using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Crud.EF
{
    public class StudentContextFactory : IDesignTimeDbContextFactory<StudentDBContext>
    {
        public StudentDBContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<StudentDBContext>();
            options.UseSqlServer("Server=.; Database=studentcrud; Trusted_Connection=True");
            return new StudentDBContext(options.Options);
        }
    }
}
