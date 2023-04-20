using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSpace
{
	public class User
	{
		public string Name { get; private set; }
		public string Email { get; private set; }
		private string Password { get; set; }
		public bool IsLoggedIn { get; set; }

		public User(string name, string email)
		{
			Name = name;
			Email = email;
			IsLoggedIn = false;
		}

		public bool IsSetupComplete()
		{
			if (Name != null && Email != null && Password != null)
			{
			   return true;
			}
			else
			{
				return false;
			}
		}

        // refactored method bellow so that it returns the string "Password Created" instead of saving it to a var that dose not get used and gose out of scpoe once the method is done
        public string CreatePassword(string email, string password)
		{
			if (email == Email)
			{
				Password = password;
			}

			if (Password != null)
			{	
				return "Password Created";
			}

            return "Password Not-Created";
        }

		public string LogIn(string password)
		{
			if (password == Password)
			{
				IsLoggedIn = true;
				return "Logged In";
			}
			return "Not Logged In";
		}

        // refactored so this method would return a string instead of being void to give more feedback to the user that the action took place. I also made it so it would check to make sure the user was loged in before setting the IsLoggedIn bool to false. 
        public string LogOut()
		{
			if (IsLoggedIn)
			{
                IsLoggedIn = false;
                return "Logged Out";
            }

			return "Please Login first before logging out";
		}
	}
}
