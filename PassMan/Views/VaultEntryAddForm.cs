﻿using System;
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
    public partial class VaultEntryAddForm : Form
    {
        public string WebsiteValue { get; private set; }
        public string UsernameValue { get; private set; }
        public string PasswordValue { get; private set; }

        public VaultEntryAddForm()
        {
            InitializeComponent();
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
