namespace Winform__with_database_
{
    partial class PurchaseHistory
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
            this.ListItemPHistory = new System.Windows.Forms.ListView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.LblPurchID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.BtnDD = new System.Windows.Forms.Button();
            this.CmboSorting = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ListItemPHistory
            // 
            this.ListItemPHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListItemPHistory.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ListItemPHistory.FullRowSelect = true;
            this.ListItemPHistory.HideSelection = false;
            this.ListItemPHistory.Location = new System.Drawing.Point(43, 38);
            this.ListItemPHistory.Name = "ListItemPHistory";
            this.ListItemPHistory.Size = new System.Drawing.Size(839, 495);
            this.ListItemPHistory.TabIndex = 30;
            this.ListItemPHistory.UseCompatibleStateImageBehavior = false;
            this.ListItemPHistory.View = System.Windows.Forms.View.Details;
            this.ListItemPHistory.SelectedIndexChanged += new System.EventHandler(this.ListItemPHistory_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(1089, 80);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 50);
            this.btnRemove.TabIndex = 31;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // LblPurchID
            // 
            this.LblPurchID.AutoSize = true;
            this.LblPurchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPurchID.Location = new System.Drawing.Point(888, 43);
            this.LblPurchID.Name = "LblPurchID";
            this.LblPurchID.Size = new System.Drawing.Size(149, 29);
            this.LblPurchID.TabIndex = 32;
            this.LblPurchID.Text = "Purchase ID:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(1043, 40);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(204, 34);
            this.txtID.TabIndex = 33;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.Location = new System.Drawing.Point(936, 464);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(123, 50);
            this.BtnRefresh.TabIndex = 34;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(43, 601);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 79);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BtnDD
            // 
            this.BtnDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDD.Location = new System.Drawing.Point(936, 362);
            this.BtnDD.Name = "BtnDD";
            this.BtnDD.Size = new System.Drawing.Size(123, 50);
            this.BtnDD.TabIndex = 36;
            this.BtnDD.Text = "Activate";
            this.BtnDD.UseVisualStyleBackColor = true;
            this.BtnDD.Click += new System.EventHandler(this.BtnDD_Click);
            // 
            // CmboSorting
            // 
            this.CmboSorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmboSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmboSorting.FormattingEnabled = true;
            this.CmboSorting.Items.AddRange(new object[] {
            "Highest Sell",
            "Lowest Sell",
            "Total Revenue"});
            this.CmboSorting.Location = new System.Drawing.Point(893, 323);
            this.CmboSorting.MaxDropDownItems = 3;
            this.CmboSorting.Name = "CmboSorting";
            this.CmboSorting.Size = new System.Drawing.Size(200, 33);
            this.CmboSorting.TabIndex = 37;
            this.CmboSorting.SelectedIndexChanged += new System.EventHandler(this.CmboSorting_SelectedIndexChanged);
            // 
            // PurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 722);
            this.Controls.Add(this.CmboSorting);
            this.Controls.Add(this.BtnDD);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.LblPurchID);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.ListItemPHistory);
            this.Name = "PurchaseHistory";
            this.Text = "PurchaseHistory";
            this.Load += new System.EventHandler(this.PurchaseHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label LblPurchID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView ListItemPHistory;
        private System.Windows.Forms.Button BtnDD;
        private System.Windows.Forms.ComboBox CmboSorting;
    }
}