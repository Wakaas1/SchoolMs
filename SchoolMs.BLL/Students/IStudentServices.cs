using SchoolMs.Domain.Models.Students;

namespace SchoolMs.BLL.Students
{
    public interface IStudentServices
    {
        List<StudentList> GetAllStudents();
        int AddStudent(StudentList model);
    }
}