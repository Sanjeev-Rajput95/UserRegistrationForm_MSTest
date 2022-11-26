namespace UserForm
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
            public void FirstName()
            {
                bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.UserForm("Sanjeev");
                Assert.IsTrue(result);
            }
        [TestMethod]
        public void LastName()
        {
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.UserFormLastName("Singh");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValideEmail()
        {
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.UserValideEmail("abc.xyz@bl.co.in");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MobileNumber()
        {
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.MobileNumber("8266953797");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PassWordRule_1()
        {
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.PassWordRule1("sameersingh");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UpperCasePassWordRule_2()
        {
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.UpperCasePassWordRule_2("Sameersingh");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Atleast1NumberPassWordRule_3()
        {
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.Atleast1NumberPassWordRule_3("Sameersingh1");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Atleast1SpecialCharPassWordRule_4()
        {
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.Atleast1SpecialCharPassWordRule_4("Sameersingh@1");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EmailSample()
        {
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.EmailSample("abc@yahoo.com");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailSample2()
        {
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.EmailSample("abc-100@yahoo.com");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailSample3()
        {
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.EmailSample("abc.100@yahoo.com");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailSample4()
        {
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.EmailSample("abc111@abc.com");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailSample5()
        {
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.EmailSample("abc-100@abc.net");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailSample6()
        {
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.EmailSample("abc.100@abc.com.au");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailSample7()
        {
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.EmailSample("abc@1.com");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailSample8()
        {
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.EmailSample("abc@gmail.com.com");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailSample9()
        {
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.EmailSample("abc+100@gmail.com");
            Assert.IsTrue(result);
        }

    }
}