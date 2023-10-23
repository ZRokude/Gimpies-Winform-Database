namespace Winform__with_database_
{
    partial class ManF
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
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblQua = new System.Windows.Forms.Label();
            this.txtQua = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.ListItemMaF = new System.Windows.Forms.ListView();
            this.CmboSorting = new System.Windows.Forms.ComboBox();
            this.BtnCustomF = new System.Windows.Forms.Button();
            this.BtnPurchHist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(1013, 62);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(204, 34);
            this.txtBrand.TabIndex = 11;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(912, 67);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(83, 29);
            this.lblBrand.TabIndex = 12;
            this.lblBrand.Text = "Brand:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(921, 107);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(74, 29);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Type:";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(1013, 102);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(204, 34);
            this.txtType.TabIndex = 14;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(929, 147);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(66, 29);
            this.lblSize.TabIndex = 15;
            this.lblSize.Text = "Size:";
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(1013, 142);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(204, 34);
            this.txtSize.TabIndex = 16;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(917, 188);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(78, 29);
            this.lblColor.TabIndex = 17;
            this.lblColor.Text = "Color:";
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(1013, 183);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(204, 34);
            this.txtColor.TabIndex = 18;
            // 
            // lblQua
            // 
            this.lblQua.AutoSize = true;
            this.lblQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQua.Location = new System.Drawing.Point(889, 228);
            this.lblQua.Name = "lblQua";
            this.lblQua.Size = new System.Drawing.Size(106, 29);
            this.lblQua.TabIndex = 19;
            this.lblQua.Text = "Quantity:";
            // 
            // txtQua
            // 
            this.txtQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQua.Location = new System.Drawing.Point(1013, 223);
            this.txtQua.Name = "txtQua";
            this.txtQua.Size = new System.Drawing.Size(204, 34);
            this.txtQua.TabIndex = 20;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(920, 268);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(75, 29);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(1013, 263);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(204, 34);
            this.txtPrice.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1013, 343);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 50);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(1093, 343);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 50);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(64, 588);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 79);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(1013, 303);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(204, 34);
            this.txtID.TabIndex = 26;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(953, 308);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(42, 29);
            this.lblID.TabIndex = 27;
            this.lblID.Text = "ID:";
            // 
            // ListItemMaF
            // 
            this.ListItemMaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListItemMaF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ListItemMaF.FullRowSelect = true;
            this.ListItemMaF.HideSelection = false;
            this.ListItemMaF.Location = new System.Drawing.Point(47, 45);
            this.ListItemMaF.Name = "ListItemMaF";
            this.ListItemMaF.Size = new System.Drawing.Size(839, 495);
            this.ListItemMaF.TabIndex = 30;
            this.ListItemMaF.UseCompatibleStateImageBehavior = false;
            this.ListItemMaF.View = System.Windows.Forms.View.Details;
            this.ListItemMaF.SelectedIndexChanged += new System.EventHandler(this.ListItemMaF_SelectedIndexChanged);
            // 
            // CmboSorting
            // 
            this.CmboSorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmboSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmboSorting.FormattingEnabled = true;
            this.CmboSorting.Items.AddRange(new object[] {
            "Highest Price Sorting",
            "Lowest Price Sorting",
            "Highest Quantity Sorting",
            "Lowest Quantity Sorting",
            "Average Price",
            "Total Revenue"});
            this.CmboSorting.Location = new System.Drawing.Point(1013, 399);
            this.CmboSorting.MaxDropDownItems = 3;
            this.CmboSorting.Name = "CmboSorting";
            this.CmboSorting.Size = new System.Drawing.Size(200, 33);
            this.CmboSorting.TabIndex = 35;
            this.CmboSorting.SelectedIndexChanged += new System.EventHandler(this.CmboSorting_SelectedIndexChanged);
            // 
            // BtnCustomF
            // 
            this.BtnCustomF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomF.Location = new System.Drawing.Point(1013, 438);
            this.BtnCustomF.Name = "BtnCustomF";
            this.BtnCustomF.Size = new System.Drawing.Size(123, 41);
            this.BtnCustomF.TabIndex = 36;
            this.BtnCustomF.Text = "Activate";
            this.BtnCustomF.UseVisualStyleBackColor = true;
            this.BtnCustomF.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // BtnPurchHist
            // 
            this.BtnPurchHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPurchHist.Location = new System.Drawing.Point(254, 588);
            this.BtnPurchHist.Name = "BtnPurchHist";
            this.BtnPurchHist.Size = new System.Drawing.Size(163, 79);
            this.BtnPurchHist.TabIndex = 37;
            this.BtnPurchHist.Text = "Purchase History";
            this.BtnPurchHist.UseVisualStyleBackColor = true;
            this.BtnPurchHist.Click += new System.EventHandler(this.BtnPurchHist_Click);
            // 
            // ManF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 722);
            this.Controls.Add(this.BtnPurchHist);
            this.Controls.Add(this.BtnCustomF);
            this.Controls.Add(this.CmboSorting);
            this.Controls.Add(this.ListItemMaF);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtQua);
            this.Controls.Add(this.lblQua);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtBrand);
            this.Name = "ManF";
            this.Text = "ManF";
            this.Load += new System.EventHandler(this.ManF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblQua;
        private System.Windows.Forms.TextBox txtQua;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ListView ListItemMaF;
        private System.Windows.Forms.ComboBox CmboSorting;
        private System.Windows.Forms.Button BtnCustomF;
        private System.Windows.Forms.Button BtnPurchHist;
    }
}