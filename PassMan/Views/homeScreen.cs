using PassMan.Core.Utils;
using PassMan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassMan.Desktop.Views
{
    public partial class homeScreen : Form
    {
        private AuthManager authManager;
        public homeScreen(AuthManager manager)
        {
            InitializeComponent();

            this.authManager = manager;


            //initialDataGridView(dataGridView1);

            if (authManager.loggedUser != null)
            {

                EncryptedType encType = new EncryptedType(authManager.loggedUser.Email, "a");
                foreach (var vault in authManager.loggedUser.VaultEntries)
                {
                    encType.Secret = vault.Password;
                    dataGridView1.Rows.Add(vault.Name, encType.Decrypt().Secret, vault.Website, vault.Id);
                }
            }
            //dataGridView1.Columns["Name"].HeaderText = "Név";
        }


        private void newVaultAddBtn_Click(object sender, EventArgs e)
        {
            // Új űrlap létrehozása az adatok bevitele céljából
            VaultEntryAddForm addDataForm = new VaultEntryAddForm();
            if (addDataForm.ShowDialog() == DialogResult.OK)
            {
                // Az űrlapról visszaadott adatok hozzáadása a DataGridView-hez
                string website = addDataForm.WebsiteValue;
                string username = addDataForm.UsernameValue;
                string password = addDataForm.PasswordValue;
                VaultEntry newVault = new VaultEntry();
                newVault.UserId = authManager.loggedUser.Username;
                newVault.Website = website;
                newVault.Name = username;
                EncryptedType passwordHelp = new EncryptedType(authManager.loggedUser.Email, password);

                newVault.Password = passwordHelp.Encrypt().Secret;
                int newId = authManager.dao.AddVaultEntry(newVault);
                Debug.WriteLine("Hozzáadott ID:");
                Debug.WriteLine(newId);
                // TODO SAVE TO VAULTENTRY!!
                // meg kell hívni a Dao-t és elmenteni a rákba
                dataGridView1.Rows.Add(username, password, website, newId);
            }
        }

        private void deleteVaultBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = -1;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // ha az egész sor ki van jelölve
                selectedIndex = dataGridView1.SelectedRows[0].Index;
            }
            if (dataGridView1.SelectedCells.Count == 1)
            {
                selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            }

            if (selectedIndex >= 0)
            {
                // Le kell kérni a kijelölt sor adatait
                string username = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString();
                string password = dataGridView1.Rows[selectedIndex].Cells[1].Value.ToString();
                string website = dataGridView1.Rows[selectedIndex].Cells[2].Value.ToString();
                string id = dataGridView1.Rows[selectedIndex].Cells[3].Value.ToString();

                // Most már rendelkezel a sor adataival, és használhatod vagy mentheted őket
                Debug.WriteLine(username);
                Debug.WriteLine(password); // TODO jelszót kódolni kell!
                Debug.WriteLine(website);
                Debug.WriteLine("==================");
                VaultEntry vaultToDelete = new VaultEntry();
                vaultToDelete.UserId = authManager.loggedUser.Username;
                vaultToDelete.Website = website;
                vaultToDelete.Name = username;
                vaultToDelete.Id = Convert.ToInt32(id);
                EncryptedType enc = new EncryptedType(authManager.loggedUser.Email, password);
                vaultToDelete.Password = enc.Encrypt().Secret;

                authManager.dao.RemoveVaultEntry(authManager.loggedUser, vaultToDelete);
                // Töröld a kijelölt sort a DataGridView-ből
                dataGridView1.Rows.RemoveAt(selectedIndex);
            }
        }

        private void homeScreen_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
