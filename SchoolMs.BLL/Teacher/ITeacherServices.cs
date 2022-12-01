using SchoolMs.Domain.Models.Teachers;

namespace SchoolMs.BLL.Teacher
{
    public interface ITeacherServices
    {
        List<Teachers> GetAllTeachers();
        int AddTeacher(Teachers model);
    }
}