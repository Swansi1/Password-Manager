namespace PassMan
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            button1 = new Button();
            registerBtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 90);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(120, 130);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 1;
            label2.Text = "Jelszó";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(200, 87);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(294, 33);
            usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(200, 127);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(294, 33);
            passwordTextBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(41, 194);
            button1.Name = "button1";
            button1.Size = new Size(176, 37);
            button1.TabIndex = 4;
            button1.Text = "Bejelentkezés";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.IndianRed;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerBtn.Location = new Point(318, 194);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(176, 37);
            registerBtn.TabIndex = 5;
            registerBtn.Text = "Regisztráció";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(76, 18);
            label3.Name = "label3";
            label3.Size = new Size(346, 30);
            label3.TabIndex = 6;
            label3.Text = "Kérlek jelentkezz be vagy regisztrálj!";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 294);
            Controls.Add(label3);
            Controls.Add(registerBtn);
            Controls.Add(button1);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Login";
            Text = "Bejelentkezés";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button button1;
        private Button registerBtn;
        private Label label3;
    }
}