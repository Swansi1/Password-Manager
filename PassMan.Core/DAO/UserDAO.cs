using Microsoft.EntityFrameworkCore;
using PassMan.Core.Utils;
using PassMan.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PassMan.Core.DAO
{
    public class UserDAO
    {

        public UserDAO() {
            using (var context = new MyDbContext())
            {
                context.Database.EnsureCreated();
            }
        }

        public List<User> GetAllUsers()
        {
            using (var context = new MyDbContext())
            {
                return context.Users.Include(u => u.VaultEntries).ToList();
            }
        }

        public void AddUser(User user)
        {
            using (var context = new MyDbContext())
            {
                EncryptedType EncryptedType = new EncryptedType(user.Email, user.Password); // legyen a jelszó is titkosítva mentésnél
                var encryptedPass = EncryptedType.MainPasswordHash();
                var newUser = user.ShallowCopy();
                newUser.Password = encryptedPass;

                context.Users.Add(newUser);
                context.SaveChanges();
            }
        }

        public int AddVaultEntry(VaultEntry vaultEntry)
        {
            using (var context = new MyDbContext())
            {
                context.VaultEntries.Add(vaultEntry);
                context.SaveChanges();
                return vaultEntry.Id;
            }
        }

        public void RemoveVaultEntry(User user, VaultEntry vault)
        {
            using (var context = new MyDbContext()) {
                var vaultEntryToDelete = context.VaultEntries.FirstOrDefault(ve =>
                ve.UserId == user.Username &&
                ve.Id == vault.Id);
                Debug.WriteLine("REMOVEVAULT:::");
                Debug.WriteLine(vaultEntryToDelete);

                if (vaultEntryToDelete != null)
                {
                    context.VaultEntries.Remove(vaultEntryToDelete);
                    context.SaveChanges();
                }
            }
        }
    }
}
