using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    public interface IStudentValidation
    {
        bool IsValid(Student student);
    }

    public interface IStudentRepository
    {
        Student Save(Student student);
    }

    public interface IEmailService
    {
        void SentEmail(string email, string message);
    }

}
