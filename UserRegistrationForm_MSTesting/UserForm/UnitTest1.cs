namespace UserForm
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
            public void fName()
            {
                bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.userForm("Sanjeev");
                Assert.IsTrue(result);
            }
        
    }
}