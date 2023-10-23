namespace Winform__with_database_
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.ListItemMen = new System.Windows.Forms.ListView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnLogO = new System.Windows.Forms.Button();
            this.btnManagerF = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnEx = new System.Windows.Forms.Button();
            this.txtRole = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblQua = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListItemMen
            // 
            this.ListItemMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListItemMen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ListItemMen.FullRowSelect = true;
            this.ListItemMen.HideSelection = false;
            this.ListItemMen.Location = new System.Drawing.Point(297, 71);
            this.ListItemMen.Name = "ListItemMen";
            this.ListItemMen.Size = new System.Drawing.Size(667, 495);
            this.ListItemMen.TabIndex = 29;
            this.ListItemMen.UseCompatibleStateImageBehavior = false;
            this.ListItemMen.View = System.Windows.Forms.View.Details;
            this.ListItemMen.SelectedIndexChanged += new System.EventHandler(this.ListItemMen_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShow.Location = new System.Drawing.Point(25, 27);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(114, 38);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "......";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.Location = new System.Drawing.Point(25, 71);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(206, 44);
            this.btnAcc.TabIndex = 10;
            this.btnAcc.Text = "Account Info";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Visible = false;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnLogO
            // 
            this.btnLogO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogO.Location = new System.Drawing.Point(25, 121);
            this.btnLogO.Name = "btnLogO";
            this.btnLogO.Size = new System.Drawing.Size(206, 48);
            this.btnLogO.TabIndex = 11;
            this.btnLogO.Text = "Log Out";
            this.btnLogO.UseVisualStyleBackColor = true;
            this.btnLogO.Visible = false;
            this.btnLogO.Click += new System.EventHandler(this.btnLogO_Click);
            // 
            // btnManagerF
            // 
            this.btnManagerF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerF.Location = new System.Drawing.Point(25, 431);
            this.btnManagerF.Name = "btnManagerF";
            this.btnManagerF.Size = new System.Drawing.Size(266, 53);
            this.btnManagerF.TabIndex = 12;
            this.btnManagerF.Text = "Manager Feature";
            this.btnManagerF.UseVisualStyleBackColor = true;
            this.btnManagerF.Visible = false;
            this.btnManagerF.Click += new System.EventHandler(this.btnManagerF_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(25, 490);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(266, 53);
            this.btnAdmin.TabIndex = 13;
            this.btnAdmin.Text = "Admin Feature";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnEx
            // 
            this.btnEx.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx.Location = new System.Drawing.Point(45, 640);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(233, 40);
            this.btnEx.TabIndex = 14;
            this.btnEx.Text = "Exit";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click_1);
            // 
            // txtRole
            // 
            this.txtRole.AutoSize = true;
            this.txtRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(240, 9);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(88, 32);
            this.txtRole.TabIndex = 15;
            this.txtRole.Text = "Role: ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(1090, 233);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(204, 38);
            this.txtQuantity.TabIndex = 20;
            // 
            // btnSell
            // 
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.Location = new System.Drawing.Point(1139, 295);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(101, 40);
            this.btnSell.TabIndex = 24;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(1090, 193);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(204, 34);
            this.txtColor.TabIndex = 37;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(994, 198);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(78, 29);
            this.lblColor.TabIndex = 36;
            this.lblColor.Text = "Color:";
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(1090, 152);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(204, 34);
            this.txtSize.TabIndex = 35;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(1006, 157);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(66, 29);
            this.lblSize.TabIndex = 34;
            this.lblSize.Text = "Size:";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(1090, 112);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(204, 34);
            this.txtType.TabIndex = 33;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(998, 117);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(74, 29);
            this.lblType.TabIndex = 32;
            this.lblType.Text = "Type:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(989, 77);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(83, 29);
            this.lblBrand.TabIndex = 31;
            this.lblBrand.Text = "Brand:";
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(1090, 72);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(204, 34);
            this.txtBrand.TabIndex = 30;
            // 
            // lblQua
            // 
            this.lblQua.AutoSize = true;
            this.lblQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQua.Location = new System.Drawing.Point(978, 242);
            this.lblQua.Name = "lblQua";
            this.lblQua.Size = new System.Drawing.Size(106, 29);
            this.lblQua.TabIndex = 38;
            this.lblQua.Text = "Quantity:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 722);
            this.Controls.Add(this.lblQua);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.ListItemMen);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.btnEx);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnManagerF);
            this.Controls.Add(this.btnLogO);
            this.Controls.Add(this.btnAcc);
            this.Controls.Add(this.btnShow);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Button btnLogO;
        private System.Windows.Forms.Button btnManagerF;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnEx;
        private System.Windows.Forms.Label txtRole;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.ListView ListItemMen;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblQua;
    }
}