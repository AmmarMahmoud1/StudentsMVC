using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsMangment.Models
{
    public interface IStudentRepository
    {
        IQueryable<Student> Students { get; }

    }
}
