using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentManager
{
    public class StudentValidationService : IStudentValidation
    {
        public bool IsValid(Student student)
        {
            if (student == null)
                return false;

            if (!Regex.IsMatch(student.Name, "^[a-zA-Z ]+$"))
                return false;

            return true;
        }
    }

}
