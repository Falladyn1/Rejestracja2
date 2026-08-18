using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejestracja2
{
    public static class UserDatabase
    {

        private static readonly string filePath = "users.txt";


        public static List<User> LoadUsers()
        {
            List<User> users = new List<User>();

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] data = line.Split(';');

                if (data.Length == 2)
                {
                    users.Add(new User(data[0], data[1]));
                }
            }

            return users;
        }


        public static void SaveUsers(List<User> users)
        {
            List<string> lines = new List<string>();

            foreach (User user in users)
            {
                lines.Add($"{user.Username};{user.Password}");
            }

            File.WriteAllLines(filePath, lines);
        }

    }
}
