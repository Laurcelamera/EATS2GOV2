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
            this.dataIngredients = new System.Windows.Forms.DataGridView();
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
            this.tabInventory = new System.Windows.Forms.TabControl();
            this.tabIngredients = new System.Windows.Forms.TabPage();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.dataMenu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtItemID2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemName2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtItemType2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtItemPrice2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtItemQuantity2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataIngredients)).BeginInit();
            this.tabInventory.SuspendLayout();
            this.tabIngredients.SuspendLayout();
            this.tabMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToMain
            // 
            this.btnToMain.Location = new System.Drawing.Point(25, 12);
            this.btnToMain.Margin = new System.Windows.Forms.Padding(2);
            this.btnToMain.Name = "btnToMain";
            this.btnToMain.Size = new System.Drawing.Size(72, 40);
            this.btnToMain.TabIndex = 3;
            this.btnToMain.Text = "Back";
            this.btnToMain.UseVisualStyleBackColor = true;
            this.btnToMain.Click += new System.EventHandler(this.btnToMain_Click);
            // 
            // dataIngredients
            // 
            this.dataIngredients.AllowUserToAddRows = false;
            this.dataIngredients.AllowUserToDeleteRows = false;
            this.dataIngredients.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.itemName,
            this.itemType,
            this.itemPrice,
            this.itemQuantity,
            this.itemExpiry,
            this.itemReceivedDate,
            this.itemSup});
            this.dataIngredients.Location = new System.Drawing.Point(388, 73);
            this.dataIngredients.Name = "dataIngredients";
            this.dataIngredients.ReadOnly = true;
            this.dataIngredients.RowHeadersWidth = 51;
            this.dataIngredients.RowTemplate.Height = 24;
            this.dataIngredients.Size = new System.Drawing.Size(970, 516);
            this.dataIngredients.TabIndex = 17;
            this.dataIngredients.SelectionChanged += new System.EventHandler(this.dataInventory_SelectionChanged_1);
            // 
            // itemID
            // 
            this.itemID.HeaderText = "ID";
            this.itemID.MinimumWidth = 6;
            this.itemID.Name = "itemID";
            this.itemID.ReadOnly = true;
            this.itemID.Width = 40;
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
            this.txtItemID.Location = new System.Drawing.Point(33, 43);
            this.txtItemID.Multiline = true;
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(48, 38);
            this.txtItemID.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Item ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Item Name";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(33, 111);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(322, 33);
            this.txtItemName.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Item Type";
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(33, 178);
            this.txtItemType.Multiline = true;
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Size = new System.Drawing.Size(322, 33);
            this.txtItemType.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Price";
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(33, 246);
            this.txtItemPrice.Multiline = true;
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(322, 33);
            this.txtItemPrice.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Item Quantity";
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Location = new System.Drawing.Point(31, 314);
            this.txtItemQuantity.Multiline = true;
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.Size = new System.Drawing.Size(322, 33);
            this.txtItemQuantity.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "Expiry";
            // 
            // txtItemExp
            // 
            this.txtItemExp.Location = new System.Drawing.Point(33, 381);
            this.txtItemExp.Multiline = true;
            this.txtItemExp.Name = "txtItemExp";
            this.txtItemExp.Size = new System.Drawing.Size(322, 33);
            this.txtItemExp.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Received Date";
            // 
            // txtItemRecDate
            // 
            this.txtItemRecDate.Location = new System.Drawing.Point(30, 444);
            this.txtItemRecDate.Multiline = true;
            this.txtItemRecDate.Name = "txtItemRecDate";
            this.txtItemRecDate.Size = new System.Drawing.Size(322, 33);
            this.txtItemRecDate.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 484);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 35;
            this.label10.Text = "Supplier";
            // 
            // txtItemSup
            // 
            this.txtItemSup.Location = new System.Drawing.Point(31, 507);
            this.txtItemSup.Multiline = true;
            this.txtItemSup.Name = "txtItemSup";
            this.txtItemSup.Size = new System.Drawing.Size(322, 33);
            this.txtItemSup.TabIndex = 34;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 548);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 41);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(139, 548);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 41);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(249, 548);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 41);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.tabIngredients);
            this.tabInventory.Controls.Add(this.tabMenu);
            this.tabInventory.Location = new System.Drawing.Point(21, 81);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.SelectedIndex = 0;
            this.tabInventory.Size = new System.Drawing.Size(1384, 656);
            this.tabInventory.TabIndex = 39;
            this.tabInventory.Tag = "";
            // 
            // tabIngredients
            // 
            this.tabIngredients.BackColor = System.Drawing.Color.GhostWhite;
            this.tabIngredients.Controls.Add(this.dataIngredients);
            this.tabIngredients.Controls.Add(this.btnDelete);
            this.tabIngredients.Controls.Add(this.txtItemExp);
            this.tabIngredients.Controls.Add(this.btnSave);
            this.tabIngredients.Controls.Add(this.txtItemID);
            this.tabIngredients.Controls.Add(this.btnAdd);
            this.tabIngredients.Controls.Add(this.label2);
            this.tabIngredients.Controls.Add(this.label10);
            this.tabIngredients.Controls.Add(this.txtItemName);
            this.tabIngredients.Controls.Add(this.txtItemSup);
            this.tabIngredients.Controls.Add(this.label4);
            this.tabIngredients.Controls.Add(this.label9);
            this.tabIngredients.Controls.Add(this.txtItemType);
            this.tabIngredients.Controls.Add(this.txtItemRecDate);
            this.tabIngredients.Controls.Add(this.label5);
            this.tabIngredients.Controls.Add(this.label8);
            this.tabIngredients.Controls.Add(this.txtItemPrice);
            this.tabIngredients.Controls.Add(this.label6);
            this.tabIngredients.Controls.Add(this.label7);
            this.tabIngredients.Controls.Add(this.txtItemQuantity);
            this.tabIngredients.Location = new System.Drawing.Point(4, 24);
            this.tabIngredients.Name = "tabIngredients";
            this.tabIngredients.Padding = new System.Windows.Forms.Padding(3);
            this.tabIngredients.Size = new System.Drawing.Size(1376, 628);
            this.tabIngredients.TabIndex = 0;
            this.tabIngredients.Text = "INGREDIENTS";
            // 
            // tabMenu
            // 
            this.tabMenu.BackColor = System.Drawing.Color.GhostWhite;
            this.tabMenu.Controls.Add(this.label11);
            this.tabMenu.Controls.Add(this.btnDelete2);
            this.tabMenu.Controls.Add(this.btnSave2);
            this.tabMenu.Controls.Add(this.btnAdd2);
            this.tabMenu.Controls.Add(this.dataMenu);
            this.tabMenu.Controls.Add(this.txtItemID2);
            this.tabMenu.Controls.Add(this.label3);
            this.tabMenu.Controls.Add(this.txtItemName2);
            this.tabMenu.Controls.Add(this.label12);
            this.tabMenu.Controls.Add(this.txtItemType2);
            this.tabMenu.Controls.Add(this.label14);
            this.tabMenu.Controls.Add(this.txtItemPrice2);
            this.tabMenu.Controls.Add(this.label16);
            this.tabMenu.Controls.Add(this.label17);
            this.tabMenu.Controls.Add(this.txtItemQuantity2);
            this.tabMenu.Location = new System.Drawing.Point(4, 24);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(1376, 628);
            this.tabMenu.TabIndex = 1;
            this.tabMenu.Text = "MENU";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Montserrat Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.BlueViolet;
            this.label11.Location = new System.Drawing.Point(86, 35);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 66);
            this.label11.TabIndex = 56;
            this.label11.Text = "MENU";
            // 
            // btnDelete2
            // 
            this.btnDelete2.Location = new System.Drawing.Point(315, 504);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(104, 41);
            this.btnDelete2.TabIndex = 55;
            this.btnDelete2.Text = "DELETE";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(205, 504);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(104, 41);
            this.btnSave2.TabIndex = 54;
            this.btnSave2.Text = "SAVE";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(95, 504);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(104, 41);
            this.btnAdd2.TabIndex = 53;
            this.btnAdd2.Text = "ADD";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // dataMenu
            // 
            this.dataMenu.AllowUserToAddRows = false;
            this.dataMenu.AllowUserToDeleteRows = false;
            this.dataMenu.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataMenu.Location = new System.Drawing.Point(745, 82);
            this.dataMenu.Name = "dataMenu";
            this.dataMenu.ReadOnly = true;
            this.dataMenu.RowHeadersWidth = 51;
            this.dataMenu.RowTemplate.Height = 24;
            this.dataMenu.Size = new System.Drawing.Size(598, 463);
            this.dataMenu.TabIndex = 36;
            this.dataMenu.SelectionChanged += new System.EventHandler(this.dataMenu_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Type";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Item Quantity";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // txtItemID2
            // 
            this.txtItemID2.Location = new System.Drawing.Point(97, 159);
            this.txtItemID2.Multiline = true;
            this.txtItemID2.Name = "txtItemID2";
            this.txtItemID2.ReadOnly = true;
            this.txtItemID2.Size = new System.Drawing.Size(48, 38);
            this.txtItemID2.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Item ID";
            // 
            // txtItemName2
            // 
            this.txtItemName2.Location = new System.Drawing.Point(97, 227);
            this.txtItemName2.Multiline = true;
            this.txtItemName2.Name = "txtItemName2";
            this.txtItemName2.Size = new System.Drawing.Size(322, 33);
            this.txtItemName2.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(93, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 15);
            this.label12.TabIndex = 40;
            this.label12.Text = "Item Name";
            // 
            // txtItemType2
            // 
            this.txtItemType2.Location = new System.Drawing.Point(97, 294);
            this.txtItemType2.Multiline = true;
            this.txtItemType2.Name = "txtItemType2";
            this.txtItemType2.Size = new System.Drawing.Size(322, 33);
            this.txtItemType2.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(93, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 15);
            this.label14.TabIndex = 42;
            this.label14.Text = "Item Type";
            // 
            // txtItemPrice2
            // 
            this.txtItemPrice2.Location = new System.Drawing.Point(97, 362);
            this.txtItemPrice2.Multiline = true;
            this.txtItemPrice2.Name = "txtItemPrice2";
            this.txtItemPrice2.Size = new System.Drawing.Size(322, 33);
            this.txtItemPrice2.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(93, 339);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 15);
            this.label16.TabIndex = 44;
            this.label16.Text = "Price";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(91, 407);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 15);
            this.label17.TabIndex = 46;
            this.label17.Text = "Item Quantity";
            // 
            // txtItemQuantity2
            // 
            this.txtItemQuantity2.Location = new System.Drawing.Point(95, 430);
            this.txtItemQuantity2.Multiline = true;
            this.txtItemQuantity2.Name = "txtItemQuantity2";
            this.txtItemQuantity2.Size = new System.Drawing.Size(322, 33);
            this.txtItemQuantity2.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(334, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 66);
            this.label1.TabIndex = 16;
            this.label1.Text = "EATS2GO INVENTORY";
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1450, 755);
            this.Controls.Add(this.tabInventory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToMain);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInventory_FormClosed);
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataIngredients)).EndInit();
            this.tabInventory.ResumeLayout(false);
            this.tabIngredients.ResumeLayout(false);
            this.tabIngredients.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.tabMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnToMain;
        private System.Windows.Forms.DataGridView dataIngredients;
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
        private System.Windows.Forms.TabControl tabInventory;
        private System.Windows.Forms.TabPage tabIngredients;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemReceivedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSup;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.DataGridView dataMenu;
        private System.Windows.Forms.TextBox txtItemID2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemName2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtItemType2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtItemPrice2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtItemQuantity2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
    }
}