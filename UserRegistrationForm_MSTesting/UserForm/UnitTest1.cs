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

    }
}