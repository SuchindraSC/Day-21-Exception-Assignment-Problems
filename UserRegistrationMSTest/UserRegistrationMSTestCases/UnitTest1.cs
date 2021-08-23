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
        [DataRow("Chitnis")]
        public void CheckLastNameIsValidOrNot(string lastname)
        {
            UseCases validate = new UseCases();
            bool check = validate.LastName(lastname);
            Assert.IsTrue(check);
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
        [DataRow("91 9045678934")]
        public void CheckMobileNumberIsValidOrNot(string Phonenumber)
        {
            UseCases validate = new UseCases();
            bool check = validate.PhoneNumber(Phonenumber);
            Assert.IsTrue(check);
        }
        [TestMethod]
        [DataRow("suchindrA@32")]
        public void CheckPasswordIsValidOrNot(string Password)
        {
            UseCases validate = new UseCases();
            bool check = validate.Password1(Password);
            Assert.IsTrue(check);
        }
    }
}
