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

namespace SchoolMs.BLL.Teacher
{
    public class TeacherServices : ITeacherServices
    {
        private readonly IDapperRepo _dapper;

        public TeacherServices(IDapperRepo dapper)
        {
            _dapper = dapper;
        }
        public List<Teachers> GetAllTeachers()
        {
            List<Teachers> TecList = new List<Teachers>();
            TecList = _dapper.ReturnList<Teachers>("GetALLTeacher").ToList();
            return (TecList);

        }
        public int AddTeacher(Teachers model)
        {
            Dapper.DynamicParameters param = new DynamicParameters();
            param.Add("@Id", -1, dbType: DbType.Int32, direction: ParameterDirection.Output);
            param.Add("@TeacherName", model.TeacherName);
            param.Add("@TeacherEmail", model.TeacherEmail);
            param.Add("@Gender", model.Gender);
            param.Add("@ContactNo", model.ContactNo);
            param.Add("@TeacherImage", model.TeacherImage);
            var result = _dapper.CreateReturnInt("dbo.AddTeacher", param);
            if (result > 0)
            {

            }

            return result;
        }
    }
}
