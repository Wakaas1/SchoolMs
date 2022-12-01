using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMs.Domain.Models.Students
{
    public  class Student
    {
        public int Id { get; set; }
        public string RollNo { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        //public Date DateofBirth { get; set; }
        public string Address { get; set; }
        public string StudentImage { get; set; }
        public int ClassId { get; set; }
    }
}
