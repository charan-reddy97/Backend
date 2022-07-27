using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    public class StudentAdmissionService
    {
        IStudentRepository _studentRepository;
        IEmailService _emailService;
        IStudentValidation validation;

        public StudentAdmissionService(IStudentRepository studentRepository
                                   , IEmailService emailService
                                   , IStudentValidation validation)
        {
            _studentRepository = studentRepository;
            _emailService = emailService;
            this.validation = validation;
        }

        public long ProcessAdmission(Student student)
        {
            long admissionId = 0;
            if (validation.IsValid(student))
            {
                student = _studentRepository.Save(student);
                if (student != null && student.Id > 0)
                {
                    _emailService.SentEmail(student.Email, $"Your admission has been successfully completed");
                    admissionId = student.Id;
                }
                else
                    throw new Exception("Could not create admission at this time");
            }
            else
                throw new ValidationException($"Invalid student details");

            return admissionId;

        }
    }

}
