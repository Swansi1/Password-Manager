using PassMan.Core.DAO;
using PassMan.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassMan.Core.Utils
{
    public class AuthManager
    {
        public UserDAO dao = new UserDAO();
        public User loggedUser = null;

        public bool createNewUser(User user)
        {
            return dao.AddUser(user);
        }

        public bool loginUser(User user)
        {
            EncryptedType EncryptedType = new EncryptedType(user.Email, user.Password);

            var Users = dao.GetAllUsers();
            foreach (var User in Users)
            {
                if(User.Username == user.Username)
                {
                    Debug.WriteLine(User.Password);
                    Debug.WriteLine(EncryptedType.MainPasswordHash());
                    if (User.Password == EncryptedType.MainPasswordHash())
                    {
                        loggedUser = User;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
