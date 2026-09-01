using System;
using System.Collections.Generic;
using System.IO;

namespace DSW_Semester_Project
{
    public class UserRepository
    {
        private string filePath = "UserAccount.txt";

        // Read all users from the text file
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    if (line != "")
                    {
                        string[] parts = line.Split('|');

                                           
                        if (parts.Length >= 4)
                        {
                            string role = parts[3];
                    
                            if (role == "0")
                            {
                                role = "Customer";
                            }

                            if (role == "1")
                            {
                                role = "Administrator";
                            }

                            User user = new User(
                                parts[0],
                                parts[1],
                                parts[2],
                                role
                            );

                            users.Add(user);
                        }
                    }
                }
            }

            return users;
        }

        // Add a new user to the file
        public void AddUser(User user)
        {
            string line =
                user.FullName + "|" +
                user.Email + "|" +
                user.Password + "|" +
                user.Role;

            File.AppendAllText(
                filePath,
                line + Environment.NewLine
            );
        }

        // Check if an email is already being used
        public bool EmailExists(string email)
        {
            List<User> users = GetAllUsers();

            foreach (User user in users)
            {
                if (user.Email.ToLower() == email.ToLower())
                {
                    return true;
                }
            }

            return false;
        }
    }
}