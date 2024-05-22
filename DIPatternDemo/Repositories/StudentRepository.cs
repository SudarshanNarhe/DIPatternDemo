using DIPatternDemo.Data;
using DIPatternDemo.Models;

namespace DIPatternDemo.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext db;

        public StudentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddStudent(Student student)
        {
            int result = 0;
            student.Percentage = CalculatePercentage(student.SQL, student.Angular, student.Java, student.DotNet);
            db.Students.Add(student);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteStudent(int studentId)
        {
            int result = 0;
            var model = db.Students.FirstOrDefault(s => s.Id == studentId);
            if (model != null)
            {
                db.Students.Remove(model);
                result = db.SaveChanges();
            }
            return result;
        }

        public Student GetStudentById(int studentId)
        {
            var std = db.Students.FirstOrDefault(s => s.Id == studentId);
            return std;
        }

        public IEnumerable<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        public int UpdateStudent(Student student)
        {
            int result = 0;
            var model = db.Students.FirstOrDefault(s => s.Id == student.Id);
            if (model != null)
            {
                model.Name = student.Name;
                model.Java = student.Java;
                model.DotNet = student.DotNet;
                model.SQL = student.SQL;
                model.Angular = student.Angular;
                model.Percentage = CalculatePercentage(student.SQL, student.Angular, student.Java, student.DotNet);

                result = db.SaveChanges();
            }
            return result;
        }

        private static decimal CalculatePercentage(double sub1, double sub2, double sub3, double sub4)
        {
            return (decimal)((sub1 + sub2 + sub3 + sub4) / 4);
        }
    }
}
