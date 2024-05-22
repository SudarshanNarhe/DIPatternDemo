using DIPatternDemo.Models;

namespace DIPatternDemo.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();

        int AddStudent(Student student);
        int UpdateStudent(Student student);
        int DeleteStudent(int studentId);

        Student GetStudentById(int studentId);
    }
}
