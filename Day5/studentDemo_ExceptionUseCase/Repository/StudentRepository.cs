using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentDemo_ExceptionUseCase.Exceptions;
using studentDemo_ExceptionUseCase.Model;

namespace studentDemo_ExceptionUseCase.Repository
{
    class StudentRepository : IStudentRepository
    {
        List<Student> students;
        public StudentRepository()
        {
            students = new List<Student>
            {
                new Student(1,"Rahul"),
                new Student(2, "Sakshi"),
                new Student(3, "Vaishnavi")
            };
        }
        public bool AddStudent(Student student)
        {
            try
            {
                if(StudentIdSearch(student.Id) != null)
                {
                    throw new StudentAlreadyExistsException($"Student Id : {student.Id} Already Exists");
                }

                if (StudentNameSearch(student.Name)!= null)
                {
                    throw new StudentAlreadyExistsException($"Student Name : {student.Name} Already Exists");
                }
                students.Add(student);
                Console.WriteLine($"Student {student.Name} Added Successfuly");
                return true;
            }
            catch (StudentAlreadyExistsException e)
            {
                Console.WriteLine($"Error: {e.Message}");
  
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
               
            }
            return false;
        }
        public Student StudentNameSearch(string name )
        {
            return students.Find(s => s.Name.Equals(name));
        }
        public Student StudentIdSearch(int id)
        {
            return students.Find(s => s.Id == id);
        }
        public List<Student> GetStudents()
        {
            return students;
        }
    }
}
