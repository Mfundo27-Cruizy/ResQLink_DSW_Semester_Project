
using System;

namespace DSW_Semester_Project
{


    public static class CurrentUser
    {
        public static User User;

        public static void Login(User user)
        {
            User = user;
        }

        public static void Logout()
        {
            User = null;
        }

    }
}