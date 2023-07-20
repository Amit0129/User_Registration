using User_Registration;

namespace UserRegistration_UnitTest
{
    [TestClass]
    public class UserRegistration_TestCase
    {
        Validator validator = new Validator();

        [TestMethod]
        [DataRow("Amit",true)]
        [DataRow("it",false)]
        [DataRow("123",false)]
        public void GivenFirstName_Validation(string fName,bool expected)
        {
            bool atual = validator.FirstNameCheck(fName);
            Assert.AreEqual(expected, atual);
        }

        [TestMethod]
        [DataRow("Nayak", true)]
        [DataRow("nayaK", false)]
        [DataRow("123", false)]
        public void GivenLastName_Validation(string lName, bool expected)
        {
            bool atual = validator.FirstNameCheck(lName);
            Assert.AreEqual(expected, atual);
        }

        [TestMethod]
        [DataRow("abc123@.com", false)]
        [DataRow("abc@abc@gmail.com", false)]
        [DataRow("abc+100@gmail.com", true)]
        [DataRow("abc@1.com", true)]
        public void GivenEmail_Validation(string email, bool expected)
        {
            //Act
            bool actual = validator.EmailCheck(email);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("91 9652545874", true)]
        [DataRow("919652545874", false)]
        [DataRow("9144 9652545874", false)]
        [DataRow("91 1652545874", false)]
        public void GivenMobileNumber_Validation(string mobileNumber, bool expected)
        {
            //Act
            bool actual = validator.MobileNumberCheck(mobileNumber);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("dA@9fghnjvbn", true)]
        [DataRow("ADF@@JVGB", false)]
        [DataRow("FVGdf", false)]
        public void GivenPasswordValidation(string password, bool expected)
        {
            //Act
            bool actual = validator.PasswordCheck(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}