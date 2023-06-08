namespace EATS2GOV2
{
    partial class frmInventory
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
            this.btnToMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataInventory = new System.Windows.Forms.DataGridView();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemReceivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemExp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtItemRecDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtItemSup = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToMain
            // 
            this.btnToMain.Location = new System.Drawing.Point(21, 12);
            this.btnToMain.Margin = new System.Windows.Forms.Padding(2);
            this.btnToMain.Name = "btnToMain";
            this.btnToMain.Size = new System.Drawing.Size(65, 32);
            this.btnToMain.TabIndex = 3;
            this.btnToMain.Text = "Back";
            this.btnToMain.UseVisualStyleBackColor = true;
            this.btnToMain.Click += new System.EventHandler(this.btnToMain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PowderBlue;
            this.label1.Location = new System.Drawing.Point(343, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 83);
            this.label1.TabIndex = 16;
            this.label1.Text = "EATS2GO INVENTORY";
            // 
            // dataInventory
            // 
            this.dataInventory.AllowUserToAddRows = false;
            this.dataInventory.AllowUserToDeleteRows = false;
            this.dataInventory.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.itemName,
            this.itemType,
            this.itemPrice,
            this.itemQuantity,
            this.itemExpiry,
            this.itemReceivedDate,
            this.itemSup});
            this.dataInventory.Location = new System.Drawing.Point(444, 120);
            this.dataInventory.Name = "dataInventory";
            this.dataInventory.ReadOnly = true;
            this.dataInventory.RowHeadersWidth = 51;
            this.dataInventory.RowTemplate.Height = 24;
            this.dataInventory.Size = new System.Drawing.Size(988, 613);
            this.dataInventory.TabIndex = 17;
            this.dataInventory.SelectionChanged += new System.EventHandler(this.dataInventory_SelectionChanged_1);
            // 
            // itemID
            // 
            this.itemID.HeaderText = "ID";
            this.itemID.MinimumWidth = 6;
            this.itemID.Name = "itemID";
            this.itemID.ReadOnly = true;
            this.itemID.Width = 60;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item Name";
            this.itemName.MinimumWidth = 6;
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Width = 125;
            // 
            // itemType
            // 
            this.itemType.HeaderText = "Item Type";
            this.itemType.MinimumWidth = 6;
            this.itemType.Name = "itemType";
            this.itemType.ReadOnly = true;
            this.itemType.Width = 125;
            // 
            // itemPrice
            // 
            this.itemPrice.HeaderText = "Price";
            this.itemPrice.MinimumWidth = 6;
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.ReadOnly = true;
            this.itemPrice.Width = 110;
            // 
            // itemQuantity
            // 
            this.itemQuantity.HeaderText = "Item Quantity";
            this.itemQuantity.MinimumWidth = 6;
            this.itemQuantity.Name = "itemQuantity";
            this.itemQuantity.ReadOnly = true;
            this.itemQuantity.Width = 125;
            // 
            // itemExpiry
            // 
            this.itemExpiry.HeaderText = "Expiry";
            this.itemExpiry.MinimumWidth = 6;
            this.itemExpiry.Name = "itemExpiry";
            this.itemExpiry.ReadOnly = true;
            this.itemExpiry.Width = 125;
            // 
            // itemReceivedDate
            // 
            this.itemReceivedDate.HeaderText = "Received Date";
            this.itemReceivedDate.MinimumWidth = 6;
            this.itemReceivedDate.Name = "itemReceivedDate";
            this.itemReceivedDate.ReadOnly = true;
            this.itemReceivedDate.Width = 125;
            // 
            // itemSup
            // 
            this.itemSup.HeaderText = "Supplier";
            this.itemSup.MinimumWidth = 6;
            this.itemSup.Name = "itemSup";
            this.itemSup.ReadOnly = true;
            this.itemSup.Width = 125;
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(39, 97);
            this.txtItemID.Multiline = true;
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(58, 38);
            this.txtItemID.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Item ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Item Name";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(39, 173);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(323, 38);
            this.txtItemName.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Item Type";
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(39, 248);
            this.txtItemType.Multiline = true;
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Size = new System.Drawing.Size(323, 38);
            this.txtItemType.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Price";
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(39, 332);
            this.txtItemPrice.Multiline = true;
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(323, 38);
            this.txtItemPrice.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Item Quantity";
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Location = new System.Drawing.Point(39, 414);
            this.txtItemQuantity.Multiline = true;
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.Size = new System.Drawing.Size(323, 38);
            this.txtItemQuantity.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Expiry";
            // 
            // txtItemExp
            // 
            this.txtItemExp.Location = new System.Drawing.Point(39, 496);
            this.txtItemExp.Multiline = true;
            this.txtItemExp.Name = "txtItemExp";
            this.txtItemExp.Size = new System.Drawing.Size(323, 38);
            this.txtItemExp.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 549);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Received Date";
            // 
            // txtItemRecDate
            // 
            this.txtItemRecDate.Location = new System.Drawing.Point(39, 572);
            this.txtItemRecDate.Multiline = true;
            this.txtItemRecDate.Name = "txtItemRecDate";
            this.txtItemRecDate.Size = new System.Drawing.Size(323, 38);
            this.txtItemRecDate.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 627);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Supplier";
            // 
            // txtItemSup
            // 
            this.txtItemSup.Location = new System.Drawing.Point(39, 650);
            this.txtItemSup.Multiline = true;
            this.txtItemSup.Name = "txtItemSup";
            this.txtItemSup.Size = new System.Drawing.Size(323, 38);
            this.txtItemSup.TabIndex = 34;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(38, 692);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 41);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(148, 692);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 41);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(258, 692);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 41);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1444, 769);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtItemSup);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtItemRecDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtItemExp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtItemQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtItemPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtItemType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.dataInventory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToMain);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInventory_FormClosed);
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnToMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemReceivedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSup;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtItemQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItemExp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtItemRecDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtItemSup;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}