namespace Winform__with_database_
{
    partial class AdminF2
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.Button();
            this.ListItemAccount = new System.Windows.Forms.ListView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmboRole = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(546, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(49, 32);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "ID:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(443, 62);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(152, 32);
            this.lblUser.TabIndex = 22;
            this.lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(449, 106);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(146, 32);
            this.lblPass.TabIndex = 23;
            this.lblPass.Text = "Password:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(610, 24);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 38);
            this.txtID.TabIndex = 24;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(610, 62);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 38);
            this.txtUser.TabIndex = 25;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(610, 106);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(200, 38);
            this.txtPass.TabIndex = 26;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(600, 220);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 53);
            this.btnCreate.TabIndex = 27;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRem
            // 
            this.btnRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRem.Location = new System.Drawing.Point(710, 220);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(111, 53);
            this.btnRem.TabIndex = 28;
            this.btnRem.Text = "Remove";
            this.btnRem.UseVisualStyleBackColor = true;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // ListItemAccount
            // 
            this.ListItemAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListItemAccount.HideSelection = false;
            this.ListItemAccount.Location = new System.Drawing.Point(353, 279);
            this.ListItemAccount.Name = "ListItemAccount";
            this.ListItemAccount.ShowGroups = false;
            this.ListItemAccount.Size = new System.Drawing.Size(707, 380);
            this.ListItemAccount.TabIndex = 29;
            this.ListItemAccount.UseCompatibleStateImageBehavior = false;
            this.ListItemAccount.View = System.Windows.Forms.View.Details;
            this.ListItemAccount.SelectedIndexChanged += new System.EventHandler(this.ListItemAccount_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(57, 580);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 79);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(514, 157);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(81, 32);
            this.lblRole.TabIndex = 32;
            this.lblRole.Text = "Role:";
            // 
            // cmboRole
            // 
            this.cmboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboRole.FormattingEnabled = true;
            this.cmboRole.Items.AddRange(new object[] {
            "Administrator",
            "Manager",
            "User"});
            this.cmboRole.Location = new System.Drawing.Point(610, 157);
            this.cmboRole.MaxDropDownItems = 3;
            this.cmboRole.Name = "cmboRole";
            this.cmboRole.Size = new System.Drawing.Size(200, 39);
            this.cmboRole.TabIndex = 33;
            this.cmboRole.SelectedIndexChanged += new System.EventHandler(this.cmboRole_SelectedIndexChanged);
            // 
            // AdminF2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 722);
            this.Controls.Add(this.cmboRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ListItemAccount);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblID);
            this.Name = "AdminF2";
            this.Text = "AdminF2";
            this.Load += new System.EventHandler(this.AdminF2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.ListView ListItemAccount;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmboRole;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}