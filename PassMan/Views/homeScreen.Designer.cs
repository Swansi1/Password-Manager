namespace PassMan.Desktop.Views
{
    partial class homeScreen
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
            dataGridView1 = new DataGridView();
            NameField = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Website = new DataGridViewTextBoxColumn();
            sqliteId = new DataGridViewTextBoxColumn();
            newVaultAddBtn = new Button();
            deleteVaultBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameField, Password, Website, sqliteId });
            dataGridView1.Location = new Point(25, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(505, 296);
            dataGridView1.TabIndex = 0;
            // 
            // NameField
            // 
            NameField.HeaderText = "Név";
            NameField.Name = "NameField";
            NameField.ReadOnly = true;
            // 
            // Password
            // 
            Password.HeaderText = "Jelszó";
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // Website
            // 
            Website.HeaderText = "Weboldal";
            Website.Name = "Website";
            Website.ReadOnly = true;
            // 
            // sqliteId
            // 
            sqliteId.HeaderText = "sqliteId";
            sqliteId.Name = "sqliteId";
            sqliteId.Visible = false;
            // 
            // newVaultAddBtn
            // 
            newVaultAddBtn.BackColor = Color.LimeGreen;
            newVaultAddBtn.FlatStyle = FlatStyle.Flat;
            newVaultAddBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            newVaultAddBtn.Location = new Point(25, 370);
            newVaultAddBtn.Name = "newVaultAddBtn";
            newVaultAddBtn.Size = new Size(186, 40);
            newVaultAddBtn.TabIndex = 1;
            newVaultAddBtn.Text = "Vault hozzáadása";
            newVaultAddBtn.UseVisualStyleBackColor = false;
            newVaultAddBtn.Click += newVaultAddBtn_Click;
            // 
            // deleteVaultBtn
            // 
            deleteVaultBtn.BackColor = Color.IndianRed;
            deleteVaultBtn.FlatStyle = FlatStyle.Flat;
            deleteVaultBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteVaultBtn.Location = new Point(388, 370);
            deleteVaultBtn.Name = "deleteVaultBtn";
            deleteVaultBtn.Size = new Size(142, 40);
            deleteVaultBtn.TabIndex = 2;
            deleteVaultBtn.Text = "Törlés";
            deleteVaultBtn.UseVisualStyleBackColor = false;
            deleteVaultBtn.Click += deleteVaultBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 30);
            label1.TabIndex = 3;
            label1.Text = "Saját adataid:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(334, 413);
            label2.Name = "label2";
            label2.Size = new Size(245, 19);
            label2.TabIndex = 4;
            label2.Text = "Törléshez jelöld ki az adott cellát / sort!";
            // 
            // homeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deleteVaultBtn);
            Controls.Add(newVaultAddBtn);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "homeScreen";
            Text = "Kezdő oldal";
            Load += homeScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button newVaultAddBtn;
        private Button deleteVaultBtn;
        private DataGridViewTextBoxColumn NameField;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Website;
        private DataGridViewTextBoxColumn sqliteId;
        private Label label1;
        private Label label2;
    }
}