using Dapper;
using SchoolMs.DAL.Dapper;
using SchoolMs.Domain.Models.Students;
using SchoolMs.Domain.Models.Teachers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMs.BLL.Students
{
    public class StudentServices : IStudentServices
    {
        private readonly IDapperRepo _dapper;

        public StudentServices(IDapperRepo dapper)
        {
            _dapper = dapper;
        }
        public List<StudentList> GetAllStudents()
        {
            List<StudentList> StuList = new List<StudentList>();
            StuList = _dapper.ReturnList<StudentList>("GetStudentList").ToList();
            return (StuList);

        }
        public int AddStudent(StudentList model)
        {
            Dapper.DynamicParameters param = new DynamicParameters();
            param.Add("@Id", -1, dbType: DbType.Int32, direction: ParameterDirection.Output);
            param.Add("@RollNo", model.RollNo);
            param.Add("@StudentName", model.StudentName);
            param.Add("@Gender", model.Gender);
            param.Add("@ClassName", model.ClassName);
            var result = _dapper.CreateReturnInt("dbo.AddStudent", param);
            if (result > 0)
            {

            }

            return result;
        }
    }
}
