using LibraryModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SongDL
{
    public class UserLists
    {
        List<Users> users = new List<Users>();

        public UserLists()
        {
            CreateUserLists();
        }
        private void CreateUserLists()
        {
            Users userOne = new Users { username = "Kea", password = "keaarciaga"};
            users.Add(userOne);

            Users userTwo = new Users { username = "thv", password = "vcut" };
            users.Add(userTwo);

            Users userThree = new Users { username = "JJK", password = "JJKGCF" };
            users.Add(userThree);
        }

        public Users GetUser(string username, string password)
        {
            Users found = new Users();
            foreach (var user in users)
            {
                if (username == user.username && password == user.password)
                {
                    found = user;
                }
            }
            return found;
        }
        
    }
}
