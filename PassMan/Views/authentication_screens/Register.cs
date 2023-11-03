using PassMan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassMan.Desktop.Views.authentication_screens
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        public User user = new User();
        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxb.Text.Trim() == null || passwordTxb.Text.Trim() == null ||
               lastnameTxb.Text.Trim() == null || firstnameTxb.Text.Trim() == null ||
               emailTxb.Text.Trim() == null)
            {
                MessageBox.Show("Nem lehet egy mező se üres!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            user.Username = usernameTxb.Text;
            user.Password = passwordTxb.Text;
            user.Email = emailTxb.Text;
            user.FirstName = firstnameTxb.Text;
            user.LastName = lastnameTxb.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
