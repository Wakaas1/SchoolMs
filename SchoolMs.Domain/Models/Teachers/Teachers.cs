using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMs.Domain.Models.Teachers
{
    public class Teachers
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        public string TeacherEmail { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }
        public string TeacherImage { get; set; }
    }
}
