/*
 * The class works, but it needs some additional effort to be great! One thing that is missing is tests; your job is to write the tests that will confirm the functionality of the class. Write one test for the constructor, and at least one test for each of the other 4 methods. As you write the tests, you might find some refactoring opportunities; update the user class with any refactors you deem necessary and add a comment describing why you made that refactor. The only rule is that all the existing methods must still exist when you are finished!
*/
using UserSpace;

namespace UserTests
{
	public class UserTest
	{
		[Fact]
		public void Test_User_UserConstructor_IsCreated()
		{
			User joe = new User("Joe", "centeno.joe@gmail.com"); // Make new user object

			Assert.Equal("Joe", joe.Name);                       // Comparing Name
			Assert.Equal("centeno.joe@gmail.com", joe.Email);    // Comparing Email
		}

		[Fact]
		public void Test_User_SetUp_UserIsSetUp()
		{
			User joe = new User("Joe", "centeno.joe@gmail.com"); // Make new user object
            joe.CreatePassword(joe.Email, "SJB123");             // Create password

            bool expectedValue = true;                           // Expected Value to test

            Assert.Equal(expectedValue, joe.IsSetupComplete());  // Testing if password was created
        }

		[Fact]
		public void Test_User_CreatePassword_PasswordIsCreated()
		{
			User joe = new User("Joe", "centeno.joe@gmail.com");				  // Make new user object

			string expectedValue = "Password Created";							  // Expected Value to test

            Assert.Equal(expectedValue, joe.CreatePassword(joe.Email, "SJB123")); // Testing if password was created
		}

		[Fact]
		public void Test_User_LogIn_UserIsAbleToLogIn()
		{
			User joe = new User("Joe", "centeno.joe@gmail.com"); // Make new user object
			joe.CreatePassword(joe.Email, "SJB123");             // Create password for user

            string expectedValue = "Logged In";                  // Expected Value to test

            Assert.Equal(expectedValue, joe.LogIn("SJB123"));    // Testing that user is able to log in
            Assert.True(joe.IsLoggedIn);						 // Testing LogOut() Bool propertie
        }

		[Fact]
		public void Test_User_LogOut_UserIsAbleToLogOut()
		{
			User joe = new User("Joe", "centeno.joe@gmail.com");			// Make new user object
			string expectedValue = "Please Login first before logging out"; // Expected Value to test

			joe.CreatePassword(joe.Email, "SJB123");						// Create password for user

			Assert.Equal(expectedValue, joe.LogOut());						// Testing Failed login attempt
           
            joe.LogIn("SJB123");											// Logging in using user password

            Assert.True(joe.IsLoggedIn);                                    // Testing LogOut() bool
            expectedValue = "Logged Out";                                   // Expected Value to test

            Assert.Equal(expectedValue, joe.LogOut());						// Testing LogOut() method working
            Assert.False(joe.IsLoggedIn);									// Testing LogOut() Bool propertie
        }
	}
}