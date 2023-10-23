namespace Winform__with_database_
{
    partial class AdminF
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.ListItemAccount = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rdbtnAdmin = new System.Windows.Forms.RadioButton();
            this.rdbtnManager = new System.Windows.Forms.RadioButton();
            this.rdbtnUser = new System.Windows.Forms.RadioButton();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(443, 62);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(152, 32);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(449, 106);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(146, 32);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(610, 62);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 38);
            this.txtUser.TabIndex = 7;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(610, 106);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(200, 38);
            this.txtPass.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(601, 150);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 53);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRem
            // 
            this.btnRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRem.Location = new System.Drawing.Point(711, 150);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(111, 53);
            this.btnRem.TabIndex = 11;
            this.btnRem.Text = "Remove";
            this.btnRem.UseVisualStyleBackColor = true;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(57, 580);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 79);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ListItemAccount
            // 
            this.ListItemAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Role,
            this.Username,
            this.Password});
            this.ListItemAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListItemAccount.HideSelection = false;
            this.ListItemAccount.Location = new System.Drawing.Point(354, 209);
            this.ListItemAccount.Name = "ListItemAccount";
            this.ListItemAccount.ShowGroups = false;
            this.ListItemAccount.Size = new System.Drawing.Size(707, 380);
            this.ListItemAccount.TabIndex = 13;
            this.ListItemAccount.UseCompatibleStateImageBehavior = false;
            this.ListItemAccount.View = System.Windows.Forms.View.Details;
            this.ListItemAccount.SelectedIndexChanged += new System.EventHandler(this.ListItemAccount_SelectedIndexChanged_1);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 117;
            // 
            // Role
            // 
            this.Role.Text = "Role";
            this.Role.Width = 133;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 141;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 149;
            // 
            // rdbtnAdmin
            // 
            this.rdbtnAdmin.AutoSize = true;
            this.rdbtnAdmin.Location = new System.Drawing.Point(921, 24);
            this.rdbtnAdmin.Name = "rdbtnAdmin";
            this.rdbtnAdmin.Size = new System.Drawing.Size(66, 20);
            this.rdbtnAdmin.TabIndex = 14;
            this.rdbtnAdmin.TabStop = true;
            this.rdbtnAdmin.Text = "Admin";
            this.rdbtnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbtnAdmin.UseVisualStyleBackColor = true;
            this.rdbtnAdmin.CheckedChanged += new System.EventHandler(this.rdbtnAdmin_CheckedChanged);
            // 
            // rdbtnManager
            // 
            this.rdbtnManager.AutoSize = true;
            this.rdbtnManager.Location = new System.Drawing.Point(921, 50);
            this.rdbtnManager.Name = "rdbtnManager";
            this.rdbtnManager.Size = new System.Drawing.Size(82, 20);
            this.rdbtnManager.TabIndex = 15;
            this.rdbtnManager.TabStop = true;
            this.rdbtnManager.Text = "Manager";
            this.rdbtnManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbtnManager.UseVisualStyleBackColor = true;
            this.rdbtnManager.CheckedChanged += new System.EventHandler(this.rdbtnManager_CheckedChanged);
            // 
            // rdbtnUser
            // 
            this.rdbtnUser.AutoSize = true;
            this.rdbtnUser.Location = new System.Drawing.Point(921, 76);
            this.rdbtnUser.Name = "rdbtnUser";
            this.rdbtnUser.Size = new System.Drawing.Size(57, 20);
            this.rdbtnUser.TabIndex = 16;
            this.rdbtnUser.TabStop = true;
            this.rdbtnUser.Text = "User";
            this.rdbtnUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbtnUser.UseVisualStyleBackColor = true;
            this.rdbtnUser.CheckedChanged += new System.EventHandler(this.rdbtnUser_CheckedChanged);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(834, 21);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(81, 32);
            this.lblRole.TabIndex = 17;
            this.lblRole.Text = "Role:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(610, 18);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 38);
            this.txtID.TabIndex = 19;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(514, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 32);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "ID";
            // 
            // AdminF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 722);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.rdbtnUser);
            this.Controls.Add(this.rdbtnManager);
            this.Controls.Add(this.rdbtnAdmin);
            this.Controls.Add(this.ListItemAccount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdminF";
            this.Text = "AdminF";
            this.Load += new System.EventHandler(this.AdminF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView ListItemAccount;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Role;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.RadioButton rdbtnAdmin;
        private System.Windows.Forms.RadioButton rdbtnManager;
        private System.Windows.Forms.RadioButton rdbtnUser;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
    }
}