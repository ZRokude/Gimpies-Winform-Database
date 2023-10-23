namespace Winform__with_database_
{
    partial class Account
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
            this.AccI = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.createD = new System.Windows.Forms.Label();
            this.lblPermS = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AccI
            // 
            this.AccI.AutoSize = true;
            this.AccI.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccI.Location = new System.Drawing.Point(469, 26);
            this.AccI.Name = "AccI";
            this.AccI.Size = new System.Drawing.Size(562, 69);
            this.AccI.TabIndex = 5;
            this.AccI.Text = "Account Information";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(57, 580);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 79);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // createD
            // 
            this.createD.AutoSize = true;
            this.createD.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createD.Location = new System.Drawing.Point(280, 325);
            this.createD.Name = "createD";
            this.createD.Size = new System.Drawing.Size(308, 46);
            this.createD.TabIndex = 9;
            this.createD.Text = "Create Account:";
            // 
            // lblPermS
            // 
            this.lblPermS.AutoSize = true;
            this.lblPermS.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermS.Location = new System.Drawing.Point(339, 274);
            this.lblPermS.Name = "lblPermS";
            this.lblPermS.Size = new System.Drawing.Size(249, 51);
            this.lblPermS.TabIndex = 8;
            this.lblPermS.Text = "Permission:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(518, 228);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(70, 46);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID:";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 722);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.createD);
            this.Controls.Add(this.lblPermS);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.AccI);
            this.Name = "Account";
            this.Text = "Acc";
            this.Load += new System.EventHandler(this.Account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccI;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label createD;
        private System.Windows.Forms.Label lblPermS;
        private System.Windows.Forms.Label lblID;
    }
}