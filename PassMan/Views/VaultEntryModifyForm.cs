using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassMan.Desktop.Views
{
    public partial class VaultEntryModifyForm : Form
    {
        public string WebsiteValue { get; set; }
        public string UsernameValue { get; set; }
        public string PasswordValue { get; set; }
        public string vaultId { get; set; }

        public VaultEntryModifyForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (websiteTxb.Text.Trim().Length == 0 || usernameTxb.Text.Trim().Length == 0 || passwordTxb.Text.Trim().Length == 0)
            {
                MessageBox.Show("Nem lehet üres mezőket megadni!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WebsiteValue = websiteTxb.Text;
            UsernameValue = usernameTxb.Text;
            PasswordValue = passwordTxb.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void VaultEntryModifyForm_Load(object sender, EventArgs e)
        {
            websiteTxb.Text = WebsiteValue;
            usernameTxb.Text = UsernameValue;
            passwordTxb.Text = PasswordValue;
        }
    }
}
