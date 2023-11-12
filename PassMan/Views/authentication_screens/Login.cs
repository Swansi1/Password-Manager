

using Microsoft.EntityFrameworkCore;
using PassMan.Core.DAO;
using PassMan.Core.Utils;
using PassMan.Desktop.Views;
using PassMan.Desktop.Views.authentication_screens;
using PassMan.Models;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace PassMan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public AuthManager manager;
        private void Form1_Load(object sender, EventArgs e)
        {
            manager = new AuthManager();

            // test for sqlite
            //Debug.WriteLine("MOST AJTK LÉASJGFKLAJGFKLÉSAJGLÉSKAGFJKLSJKLGÉLKA");
            //using (var context = new MyDbContext())
            //{
            //    // Adatbázis létrehozása
            //    context.Database.EnsureCreated();

            //    // Új felhasználó létrehozása
            //    var user = new User
            //    {
            //        Username = "patrik1",
            //        Password = "password123",
            //        Email = "john@example.com",
            //        FirstName = "John",
            //        LastName = "Doe",
            //        VaultEntries = new List<VaultEntry>()
            //    };

            //    // Új VaultEntry létrehozása
            //    var vaultEntry = new VaultEntry
            //    {
            //        UserId = user.Username,
            //        Name = "rtzfdhg",
            //        Password = "ADSSADSAD",
            //        Website = "example.com"
            //    };
            //    var vaultEntry1 = new VaultEntry
            //    {
            //        UserId = user.Username,
            //        Name = "Example1",
            //        Password = "examplepassword1",
            //        Website = "example.com123"
            //    };

            //    user.VaultEntries.Add(vaultEntry);
            //    user.VaultEntries.Add(vaultEntry1);

            //    //context.Users.Add(user);
            //    //context.SaveChanges();


            //    // Felhasználók lekérdezése
            //    manager = new AuthManager();

            //    var userDao = new UserDAO();

            //    var users = userDao.GetAllUsers();

            //    foreach (var u in users)
            //    {
            //        Debug.WriteLine($"Username: {u.Username}");
            //        foreach (var ve in u.VaultEntries)
            //        {
            //            Debug.WriteLine($"  VaultEntry Name: {ve.Name}");
            //        }
            //    }
            //}


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = usernameTextBox.Text;
            String password = passwordTextBox.Text;

            var user = new User
            {
                Username = username,
                Password = password,
                Email = "",
                FirstName = "",
                LastName = "",
                VaultEntries = new List<VaultEntry>()
            };
            if (manager.loginUser(user))
            {
                homeScreen homeScreenForm = new homeScreen(manager);

                homeScreenForm.Show();

                this.Hide();
                return;
            }
            // ha nem sikerült a login
            MessageBox.Show("Sikertelen bejelentkezés!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void registerBtn_click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            if (registerForm.ShowDialog() == DialogResult.OK)
            {
                var newUser = registerForm.user;
                bool isSuccess = manager.createNewUser(newUser);
                if(isSuccess)
                {
                    MessageBox.Show("Sikeres regisztráció!", "Regisztráció", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Sikertelen regisztráció!", "Regisztráció", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}