using User_Registration;

namespace UserRegistration_UnitTest
{
    [TestClass]
    public class UserRegistration_TestCase
    {
        Validator validator = new Validator();

        [TestMethod]
        [DataRow("Amit", "Input Valid")]
        [DataRow("Ab", "Input Is Not Valid")]
        [DataRow("", "Input Should Not Be Empty")]
        [DataRow(null, "Input Should Not Be Null")]
        public void GivenFirstNamevalidator(string firstName, string expected)
        {
            try
            {
                //Act
                string actual = validator.CheckName(firstName);
                Assert.AreEqual(expected, actual);
            }
            catch (UserValidationCoutomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        [DataRow("Nayak", "Input Valid")]
        [DataRow("Ab", "Input Is Not Valid")]
        [DataRow("", "Input Should Not Be Empty")]
        [DataRow(null, "Input Should Not Be Null")]
        public void GivenLastNamevalidator(string lastName, string expected)
        {
            try
            {
                //Act
                string actual = validator.CheckName(lastName);
                Assert.AreEqual(expected, actual);
            }
            catch (UserValidationCoutomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [DataRow("abcabc40@gmail.com", "Input Valid")]
        [DataRow("", "Input Should Not Be Empty")]
        [DataRow(null, "Input Should Not Be Null")]
        public void GivenEmailvalidator(string email, string expected)
        {
            try
            {
                //Act
                string actual = validator.CheckEmail(email);
                Assert.AreEqual(expected, actual);
            }
            catch (UserValidationCoutomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        [DataRow("91 9090909090", "Input Valid")]
        [DataRow("919652545874", "Input Is Not Valid")]
        [DataRow("", "Input Should Not Be Empty")]
        [DataRow(null, "Input Should Not Be Null")]
        public void GivenMobileNumbervalidator(string mobileNumber, string expected)
        {
            try
            {
                //Act
                string actual = validator.CheckMobileNo(mobileNumber);
                Assert.AreEqual(expected, actual);
            }
            catch (UserValidationCoutomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [DataRow("dA@9fghnjvbn", "Input Valid")]
        [DataRow("ADFJVGB", "Input Is Not Valid")]
        [DataRow("", "Input Should Not Be Empty")]
        [DataRow(null, "Input Should Not Be Null")]
        public void GivenPasswordvalidator(string password, string expected)
        {
            try
            {
                //Act
                string actual = validator.CheckPassword(password);
                Assert.AreEqual(expected, actual);
            }
            catch (UserValidationCoutomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        [DataRow("abc@gmail.com", "Input Valid")]
        [DataRow("abc-100@yahoo.com", "Input Valid")]
        [DataRow("abc.100@yahoo.com", "Input Valid")]
        [DataRow("abc@1.com", "Input Valid")]
        [DataRow("abc111@yahoo.com.au", "Input Valid")]
        [DataRow("abc-100@yahoo.com.au", "Input Valid")]
        [DataRow("abc@gmail.com.com", "Input Valid")]
        [DataRow("abc+100@yahoo.com", "Input Valid")]
        //Checking for multiple email samples that are Invalid
        [DataRow("abc", "Input Is Not Valid")]
        [DataRow("abc@.com.my", "Input Is Not Valid")]
        [DataRow("abc123@gmail.a", "Input Is Not Valid")]
        [DataRow("abc123@.com", "Input Is Not Valid")]
        [DataRow("abc@.com.com", "Input Is Not Valid")]
        [DataRow(".abc@abc.com", "Input Is Not Valid")]
        [DataRow("abc()*@gmail.com", "Input Is Not Valid")]
        [DataRow("abc@%*.com", "Input Is Not Valid")]
        [DataRow("abc..2002@gmail.com", "Input Is Not Valid")]
        [DataRow("abc.@gmail.com", "Input Is Not Valid")]
        [DataRow("abc@abc@gmail.com", "Input Is Not Valid")]
        [DataRow("abc@gmail.com.1a", "Input Is Not Valid")]
        [DataRow("abc@gmail.com.aa.au", "Input Is Not Valid")]
        public void GivenSampleEmailsvalidator(string email, string expected)
        {
            try
            {
                //Act
                string actual = validator.CheckEmail(email);
                Assert.AreEqual(expected, actual);
            }
            catch (UserValidationCoutomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}