namespace PassMan.Desktop.Views
{
    partial class VaultEntryAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            saveBtn = new Button();
            cancelBtn = new Button();
            websiteTxb = new TextBox();
            usernameTxb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            passwordTxb = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.LimeGreen;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            saveBtn.Location = new Point(118, 243);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(126, 37);
            saveBtn.TabIndex = 0;
            saveBtn.Text = "Mentés";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.IndianRed;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn.Location = new Point(441, 243);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(153, 37);
            cancelBtn.TabIndex = 1;
            cancelBtn.Text = "Mégsem";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // websiteTxb
            // 
            websiteTxb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            websiteTxb.Location = new Point(249, 92);
            websiteTxb.Name = "websiteTxb";
            websiteTxb.Size = new Size(345, 33);
            websiteTxb.TabIndex = 2;
            // 
            // usernameTxb
            // 
            usernameTxb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTxb.Location = new Point(249, 131);
            usernameTxb.Name = "usernameTxb";
            usernameTxb.Size = new Size(345, 33);
            usernameTxb.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(141, 95);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 4;
            label1.Text = "Weboldal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(92, 134);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 5;
            label2.Text = "Felhasználónév";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(171, 173);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 6;
            label3.Text = "Jelszó";
            // 
            // passwordTxb
            // 
            passwordTxb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTxb.Location = new Point(249, 170);
            passwordTxb.Name = "passwordTxb";
            passwordTxb.Size = new Size(345, 33);
            passwordTxb.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(122, 32);
            label4.Name = "label4";
            label4.Size = new Size(486, 30);
            label4.TabIndex = 8;
            label4.Text = "Új Vault hozzáadásához töltsd ki az alábbi mezőket";
            // 
            // VaultEntryAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 342);
            Controls.Add(label4);
            Controls.Add(passwordTxb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernameTxb);
            Controls.Add(websiteTxb);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "VaultEntryAddForm";
            Text = "Új Vault hozzáadása";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveBtn;
        private Button cancelBtn;
        private TextBox websiteTxb;
        private TextBox usernameTxb;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox passwordTxb;
        private Label label4;
    }
}