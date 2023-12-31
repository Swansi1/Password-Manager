﻿using Microsoft.EntityFrameworkCore;
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

        public bool AddUser(User user)
        {
            using (var context = new MyDbContext())
            {
                EncryptedType EncryptedType = new EncryptedType(user.Email, user.Password); // legyen a jelszó is titkosítva mentésnél
                var encryptedPass = EncryptedType.MainPasswordHash();
                var newUser = user.ShallowCopy();
                newUser.Password = encryptedPass;

                var isUser = GetAllUsers().Find(u => u.Username == user.Username);
                if (isUser != null)
                {
                    return false;
                }

                context.Users.Add(newUser);
                context.SaveChanges();
                return true;
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
        public void EditVaultEntry(VaultEntry vaultEntry)
        {
            using (var context = new MyDbContext())
            {
                var existingVaultEntry = context.VaultEntries.FirstOrDefault(ve => ve.Id == vaultEntry.Id);

                if (existingVaultEntry != null)
                {
                    // Módosítjuk az adatokat
                    existingVaultEntry.Name = vaultEntry.Name;
                    existingVaultEntry.Password = vaultEntry.Password;
                    existingVaultEntry.Website = vaultEntry.Website;

                    context.SaveChanges();
                }
            }
        }
    }
}
