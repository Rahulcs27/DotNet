using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentDemo_ExceptionUseCase.Model;

namespace studentDemo_ExceptionUseCase.Repository
{
    internal interface IStudentRepository
    {
        bool AddStudent(Student student);
        List<Student> GetStudents();
    }
}
