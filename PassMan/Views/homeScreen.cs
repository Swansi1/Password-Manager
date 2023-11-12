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
        private int selectedIndex = -1;
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
                    try
                    {
                        // ha a Decrypt() rossz akkor csak írja ki, akkor fordulhat elő ha nem titkosítva lett mentve
                        encType.Secret = vault.Password;
                        dataGridView1.Rows.Add(vault.Name, encType.Decrypt().Secret, vault.Website, vault.Id);
                    }
                    catch (Exception)
                    {
                        dataGridView1.Rows.Add(vault.Name, vault.Password, vault.Website, vault.Id);
                    }
                }
                dataGridView1.Columns["NameField"].SortMode = DataGridViewColumnSortMode.Automatic; // sort

            }
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
            updateCurrentDataGridViewSelectedCell();

            if (selectedIndex >= 0)
            {
                if (dataGridView1.Rows[selectedIndex].Cells[0].Value == null)
                {
                    return;
                }
                // Le kell kérni a kijelölt sor adatait
                string username = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString();
                string password = dataGridView1.Rows[selectedIndex].Cells[1].Value.ToString();
                string website = dataGridView1.Rows[selectedIndex].Cells[2].Value.ToString();
                string id = dataGridView1.Rows[selectedIndex].Cells[3].Value.ToString();

                // Most már rendelkezel a sor adataival, és használhatod vagy mentheted őket
                Debug.WriteLine(username);
                Debug.WriteLine(password); // jelszót kódolni kell!
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
                MessageBox.Show("Sikeres törlés", "Törlés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void homeScreen_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private int updateCurrentDataGridViewSelectedCell()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // ha az egész sor ki van jelölve
                selectedIndex = dataGridView1.SelectedRows[0].Index;
            }
            if (dataGridView1.SelectedCells.Count == 1)
            {
                selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            }

            return selectedIndex;
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("LEFUTOTT");
            updateCurrentDataGridViewSelectedCell();
            int currentEditRow = selectedIndex;
            if (selectedIndex >= 0)
            {
                if (dataGridView1.Rows[selectedIndex].Cells[0].Value == null)
                {
                    return;
                }
                // Le kell kérni a kijelölt sor adatait
                string username = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString();
                string password = dataGridView1.Rows[selectedIndex].Cells[1].Value.ToString();
                string website = dataGridView1.Rows[selectedIndex].Cells[2].Value.ToString();
                string id = dataGridView1.Rows[selectedIndex].Cells[3].Value.ToString();

                VaultEntryModifyForm addDataForm = new VaultEntryModifyForm();
                addDataForm.WebsiteValue = website;
                addDataForm.PasswordValue = password;
                addDataForm.UsernameValue = username;
                addDataForm.vaultId = id;



                if (addDataForm.ShowDialog() == DialogResult.OK)
                {
                    // Az űrlapról visszaadott adatok hozzáadása a DataGridView-hez
                    string webModify = addDataForm.WebsiteValue;
                    string usernameModify = addDataForm.UsernameValue;
                    string passwordModify = addDataForm.PasswordValue;

                    VaultEntry modifyVault = new VaultEntry();
                    modifyVault.Website = webModify;
                    modifyVault.Name = usernameModify;
                    EncryptedType enc = new EncryptedType(authManager.loggedUser.Email, passwordModify);
                    modifyVault.Password = enc.Encrypt().Secret; // jelszó kódolva mentés

                    modifyVault.Id = Convert.ToInt32(id);

                    authManager.dao.EditVaultEntry(modifyVault);
                    //Meg kell keresni a vault-ot id alapjáán majd edit & save
                    // dataGridView update, de van Row idnkt!!
                    dataGridView1.Rows[currentEditRow].Cells[0].Value = usernameModify;
                    dataGridView1.Rows[currentEditRow].Cells[1].Value = passwordModify;
                    dataGridView1.Rows[currentEditRow].Cells[2].Value = webModify;

                    //dataGridView1.Rows.Add(username, password, website, newId);
                }
            }
        }
    }
}
