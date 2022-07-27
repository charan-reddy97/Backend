using Moq;
using NUnit.Framework;
using StudentManager;
using System;
using System.ComponentModel.DataAnnotations;

namespace StudentAdmissionTest
{
    public class StudentAdmissionServiceTest
    {
        Mock<IStudentRepository> repoMock;
        Mock<IStudentValidation> validMock;
        Mock<IEmailService> emailMock;

        [SetUp]
        public void Setup()
        {
            repoMock = new Mock<IStudentRepository>();
            validMock = new Mock<IStudentValidation>();
            emailMock = new Mock<IEmailService>();
        }

        [Test]
        public void ProcessAdmission_ValidData_ReturnsAdmissionId()
        {
            int fakeAdmisionId = new Random().Next(999, 9999);

            repoMock.Setup(d => d.Save(It.IsAny<Student>())).Returns(new Student { Id = fakeAdmisionId });
            validMock.Setup(d => d.IsValid(It.IsAny<Student>())).Returns(true);
            emailMock.Setup(d => d.SentEmail(It.IsAny<string>(), It.IsAny<string>()));

            StudentAdmissionService service = new StudentAdmissionService(repoMock.Object
                                                                        , emailMock.Object
                                                                        , validMock.Object);

            long admissionId = service.ProcessAdmission(new Student { Name = "Sree24", Email = "sree4gmail.com" });

            Assert.IsTrue(admissionId > 0);
            Assert.AreEqual(admissionId, fakeAdmisionId);

        }

        [Test]
        public void ProcessAdmission_InvalidData_ThrowsValidationException()
        {

            repoMock.Setup(d => d.Save(It.IsAny<Student>())).Returns(new Student { Id = 0 });
            validMock.Setup(d => d.IsValid(It.IsAny<Student>())).Returns(false);
            emailMock.Setup(d => d.SentEmail(It.IsAny<string>(), It.IsAny<string>()));

            StudentAdmissionService service = new StudentAdmissionService(repoMock.Object
                                                                        , emailMock.Object
                                                                        , validMock.Object);

            Assert.Throws<ValidationException>(() => service.ProcessAdmission(new Student { Name = "Sree24", Email = "sree4gmail.com" }));
        }

        [Test]
        public void ProcessAdmission_InvalidSave_ThrowsException()
        {
            repoMock.Setup(d => d.Save(It.IsAny<Student>())).Returns(new Student { Id = 0 });
            validMock.Setup(d => d.IsValid(It.IsAny<Student>())).Returns(true);
            emailMock.Setup(d => d.SentEmail(It.IsAny<string>(), It.IsAny<string>()));

            StudentAdmissionService service = new StudentAdmissionService(repoMock.Object
                                                                        , emailMock.Object
                                                                        , validMock.Object);

            Assert.Throws<Exception>(() => service.ProcessAdmission(new Student { Name = "Sree24", Email = "sree4gmail.com" }));

        }
    }
}
