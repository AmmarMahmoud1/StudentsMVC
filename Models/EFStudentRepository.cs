using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsMangment.Models
{
    public class EFStudentRepository : IStudentRepository
    {
        private StudentDbContext _ctx;

        public EFStudentRepository(StudentDbContext ctx)
        {
            _ctx = ctx;

        }
        public IQueryable<Student> Students => _ctx.Students;
    }
}
