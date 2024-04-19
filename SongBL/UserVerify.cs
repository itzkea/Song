using System;
using LibraryModel;
using songDL;
using SongDL;

namespace SongBL
{
    public class UserVerify
    {
        public bool userverify(string username, string password)
        {
            UserLists user = new UserLists();
            var result = user.GetUser(username, password);

            return result.username != null ? true : false && result.password != null ? true : false;


        }
       
        }

    }