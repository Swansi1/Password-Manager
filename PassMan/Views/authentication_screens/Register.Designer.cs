namespace PassMan.Desktop.Views.authentication_screens
{
    partial class Register
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            usernameTxb = new TextBox();
            passwordTxb = new TextBox();
            lastnameTxb = new TextBox();
            firstnameTxb = new TextBox();
            emailTxb = new TextBox();
            registerBtn = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 88);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(131, 127);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 1;
            label2.Text = "Jelszó";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(90, 166);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 2;
            label3.Text = "Keresztnév";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(95, 205);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 3;
            label4.Text = "Családnév";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(135, 244);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // usernameTxb
            // 
            usernameTxb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTxb.Location = new Point(201, 85);
            usernameTxb.Name = "usernameTxb";
            usernameTxb.Size = new Size(353, 33);
            usernameTxb.TabIndex = 5;
            // 
            // passwordTxb
            // 
            passwordTxb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTxb.Location = new Point(201, 124);
            passwordTxb.Name = "passwordTxb";
            passwordTxb.PasswordChar = '*';
            passwordTxb.Size = new Size(353, 33);
            passwordTxb.TabIndex = 6;
            // 
            // lastnameTxb
            // 
            lastnameTxb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lastnameTxb.Location = new Point(201, 163);
            lastnameTxb.Name = "lastnameTxb";
            lastnameTxb.Size = new Size(353, 33);
            lastnameTxb.TabIndex = 7;
            // 
            // firstnameTxb
            // 
            firstnameTxb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            firstnameTxb.Location = new Point(201, 202);
            firstnameTxb.Name = "firstnameTxb";
            firstnameTxb.Size = new Size(353, 33);
            firstnameTxb.TabIndex = 8;
            // 
            // emailTxb
            // 
            emailTxb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailTxb.Location = new Point(201, 241);
            emailTxb.Name = "emailTxb";
            emailTxb.Size = new Size(353, 33);
            emailTxb.TabIndex = 9;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.LimeGreen;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerBtn.Location = new Point(52, 314);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(502, 46);
            registerBtn.TabIndex = 10;
            registerBtn.Text = "Regisztráció";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(128, 19);
            label6.Name = "label6";
            label6.Size = new Size(371, 30);
            label6.TabIndex = 11;
            label6.Text = "Töltsd ki az adatokat a regisztrációhoz!";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 426);
            Controls.Add(label6);
            Controls.Add(registerBtn);
            Controls.Add(emailTxb);
            Controls.Add(firstnameTxb);
            Controls.Add(lastnameTxb);
            Controls.Add(passwordTxb);
            Controls.Add(usernameTxb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Register";
            Text = "Regisztráció";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox usernameTxb;
        private TextBox passwordTxb;
        private TextBox lastnameTxb;
        private TextBox firstnameTxb;
        private TextBox emailTxb;
        private Button registerBtn;
        private Label label6;
    }
}