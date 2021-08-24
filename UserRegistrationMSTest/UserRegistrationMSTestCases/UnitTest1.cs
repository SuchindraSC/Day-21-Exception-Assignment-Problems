using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationMSTest;

namespace UserRegistrationMSTestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Suchindra")]
        public void CheckFirstNameIsValidOrNot(string firstname)
        {
            UseCases validate = new UseCases();
            bool check = validate.FirstName(firstname);
            Assert.IsTrue(check);
        }
        [TestMethod]
        [DataRow("suchindra")]
        public void CheckIfFirstNameIsValidorNot(string firstname)
        {
            ExceptionUseCases validate = new ExceptionUseCases();
            Assert.ThrowsException<handlingcustomException>(() => validate.FirstName(firstname));
        }
        [TestMethod]
        [DataRow("Chitnis")]
        public void CheckLastNameIsValidOrNot(string lastname)
        {
            UseCases validate = new UseCases();
            bool check = validate.LastName(lastname);
            Assert.IsTrue(check);
        }
        [TestMethod]
        [DataRow("chitnis")]
        public void CheckIfLastNameIsValidOrNot(string lastname)
        {
            ExceptionUseCases validate = new ExceptionUseCases();
            Assert.ThrowsException<handlingcustomException>(() => validate.LastName(lastname));
        }
        [TestMethod]
        [DataRow("abc.xyz@bl.co.in")]
        public void CheckEmailIdIsValidOrNot(string Emailid)
        {
            UseCases validate = new UseCases();
            bool check = validate.EmailId(Emailid);
            Assert.IsTrue(check);
        }
        [TestMethod]
        [DataRow("abcxyz@bl.co.in")]
        public void CheckIfEmailIdIsValidOrNot(string Emailid)
        {
            ExceptionUseCases validate = new ExceptionUseCases();
            Assert.ThrowsException<handlingcustomException>(() => validate.EmailId(Emailid));
        }
        [TestMethod]
        [DataRow("91 9045678934")]
        public void CheckMobileNumberIsValidOrNot(string Phonenumber)
        {
            UseCases validate = new UseCases();
            bool check = validate.PhoneNumber(Phonenumber);
            Assert.IsTrue(check);
        }
        [TestMethod]
        [DataRow("9045678934")]
        public void CheckIfMobileNumberIsValidOrNot(string Phonenumber)
        {
            ExceptionUseCases validate = new ExceptionUseCases();
            Assert.ThrowsException<handlingcustomException>(() => validate.PhoneNumber(Phonenumber));
        }
        [TestMethod]
        [DataRow("suchindrA@456")]
        public void CheckPasswordIsValidOrNot(string Password)
        {
            UseCases validate = new UseCases();
            bool check = validate.Password1(Password);
            Assert.IsTrue(check);
        }
        [TestMethod]
        [DataRow("suchindra456")]
        public void CheckIfPasswordIsValidOrNot(string Password)
        {
            ExceptionUseCases validate = new ExceptionUseCases();
            Assert.ThrowsException<handlingcustomException>(() => validate.Password1(Password));
        }
    }
}
