using System;
using System.Collections.Generic;

namespace DSW_Semester_Project
{
    public class AuthenticationService
    {
        private UserRepository userRepository;

        public AuthenticationService()
        {
            userRepository = new UserRepository();
        }

        public User Login(string usernameOrEmail, string password)
        {
            List<User> users = userRepository.GetAllUsers();

            foreach (User user in users)
            {
                bool usernameCorrect = false;

                // Check the full name
                if (user.FullName.ToLower() == usernameOrEmail.ToLower())
                {
                    usernameCorrect = true;
                }

                // Check the email
                if (user.Email.ToLower() == usernameOrEmail.ToLower())
                {
                    usernameCorrect = true;
                }

                // Check username/email AND password
                if (usernameCorrect && user.Password == password)
                {
                    return user;
                }
            }

            // No matching user was found
            return null;
        }
    }
}