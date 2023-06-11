namespace EATS2GOV2
{
    partial class frmSales
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
            this.dataSales = new System.Windows.Forms.DataGridView();
            this.btnToMain = new System.Windows.Forms.Button();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSales)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSales
            // 
            this.dataSales.AllowUserToAddRows = false;
            this.dataSales.AllowUserToDeleteRows = false;
            this.dataSales.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dataSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.item_Name,
            this.price,
            this.quantity,
            this.transaction_date});
            this.dataSales.Location = new System.Drawing.Point(143, 77);
            this.dataSales.Margin = new System.Windows.Forms.Padding(2);
            this.dataSales.Name = "dataSales";
            this.dataSales.ReadOnly = true;
            this.dataSales.RowHeadersWidth = 51;
            this.dataSales.RowTemplate.Height = 24;
            this.dataSales.Size = new System.Drawing.Size(670, 404);
            this.dataSales.TabIndex = 1;
            // 
            // btnToMain
            // 
            this.btnToMain.Location = new System.Drawing.Point(0, 0);
            this.btnToMain.Margin = new System.Windows.Forms.Padding(2);
            this.btnToMain.Name = "btnToMain";
            this.btnToMain.Size = new System.Drawing.Size(80, 48);
            this.btnToMain.TabIndex = 2;
            this.btnToMain.Text = "Back";
            this.btnToMain.UseVisualStyleBackColor = true;
            this.btnToMain.Click += new System.EventHandler(this.btnToMain_Click);
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFrom.Location = new System.Drawing.Point(896, 132);
            this.dateTimeFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(141, 28);
            this.dateTimeFrom.TabIndex = 3;
            this.dateTimeFrom.Value = new System.DateTime(2023, 5, 30, 0, 0, 0, 0);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(860, 206);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(201, 42);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumPurple;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PowderBlue;
            this.label1.Location = new System.Drawing.Point(84, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sold Items";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.btnToMain);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 48);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(841, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "From:";
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTo.Location = new System.Drawing.Point(896, 164);
            this.dateTimeTo.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(141, 28);
            this.dateTimeTo.TabIndex = 20;
            this.dateTimeTo.Value = new System.DateTime(2023, 5, 30, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(856, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "To:";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // item_Name
            // 
            this.item_Name.HeaderText = "Item Name";
            this.item_Name.MinimumWidth = 6;
            this.item_Name.Name = "item_Name";
            this.item_Name.ReadOnly = true;
            this.item_Name.Width = 140;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 125;
            // 
            // transaction_date
            // 
            this.transaction_date.HeaderText = "Transaction Date";
            this.transaction_date.MinimumWidth = 6;
            this.transaction_date.Name = "transaction_date";
            this.transaction_date.ReadOnly = true;
            this.transaction_date.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(841, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Filter By Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(831, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "TOTAL SALES:";
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Location = new System.Drawing.Point(941, 277);
            this.txtTotalSales.Multiline = true;
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.Size = new System.Drawing.Size(120, 36);
            this.txtTotalSales.TabIndex = 24;
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1129, 602);
            this.Controls.Add(this.txtTotalSales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.dataSales);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLEAR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSales_FormClosed);
            this.Load += new System.EventHandler(this.frmSales_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataSales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataSales;
        private System.Windows.Forms.Button btnToMain;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalSales;
    }
}