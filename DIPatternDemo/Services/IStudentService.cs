using DIPatternDemo.Models;

namespace DIPatternDemo.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();

        int AddStudent(Student student);
        int UpdateStudent(Student student);
        int DeleteStudent(int studentId);

        Student GetStudentById(int studentId);
    }
}
