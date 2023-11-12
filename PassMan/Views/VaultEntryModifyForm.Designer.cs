namespace PassMan.Desktop.Views
{
    partial class VaultEntryModifyForm
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
            label4 = new Label();
            passwordTxb = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            usernameTxb = new TextBox();
            websiteTxb = new TextBox();
            cancelBtn = new Button();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(267, 9);
            label4.Name = "label4";
            label4.Size = new Size(296, 30);
            label4.TabIndex = 17;
            label4.Text = "Módosítsd a meglévő vault-ot!";
            // 
            // passwordTxb
            // 
            passwordTxb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTxb.Location = new Point(267, 147);
            passwordTxb.Name = "passwordTxb";
            passwordTxb.Size = new Size(345, 33);
            passwordTxb.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(189, 150);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 15;
            label3.Text = "Jelszó";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(110, 111);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 14;
            label2.Text = "Felhasználónév";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(159, 72);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 13;
            label1.Text = "Weboldal";
            // 
            // usernameTxb
            // 
            usernameTxb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTxb.Location = new Point(267, 108);
            usernameTxb.Name = "usernameTxb";
            usernameTxb.Size = new Size(345, 33);
            usernameTxb.TabIndex = 12;
            // 
            // websiteTxb
            // 
            websiteTxb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            websiteTxb.Location = new Point(267, 69);
            websiteTxb.Name = "websiteTxb";
            websiteTxb.Size = new Size(345, 33);
            websiteTxb.TabIndex = 11;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.IndianRed;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn.Location = new Point(459, 220);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(153, 37);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "Mégsem";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.LimeGreen;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            saveBtn.Location = new Point(136, 220);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(126, 37);
            saveBtn.TabIndex = 9;
            saveBtn.Text = "Mentés";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // VaultEntryModifyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 302);
            Controls.Add(label4);
            Controls.Add(passwordTxb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernameTxb);
            Controls.Add(websiteTxb);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Name = "VaultEntryModifyForm";
            Text = "VaultEntryModifyForm";
            Load += VaultEntryModifyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox passwordTxb;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox usernameTxb;
        private TextBox websiteTxb;
        private Button cancelBtn;
        private Button saveBtn;
    }
}