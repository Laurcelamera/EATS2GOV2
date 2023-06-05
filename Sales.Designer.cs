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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnToMain = new System.Windows.Forms.Button();
            this.dateTimeSales = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(545, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALES REPORT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(195, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1009, 477);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnToMain
            // 
            this.btnToMain.Location = new System.Drawing.Point(12, 12);
            this.btnToMain.Name = "btnToMain";
            this.btnToMain.Size = new System.Drawing.Size(85, 37);
            this.btnToMain.TabIndex = 2;
            this.btnToMain.Text = "Back";
            this.btnToMain.UseVisualStyleBackColor = true;
            this.btnToMain.Click += new System.EventHandler(this.btnToMain_Click);
            // 
            // dateTimeSales
            // 
            this.dateTimeSales.Location = new System.Drawing.Point(561, 100);
            this.dateTimeSales.Name = "dateTimeSales";
            this.dateTimeSales.Size = new System.Drawing.Size(230, 22);
            this.dateTimeSales.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(561, 137);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(230, 44);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 744);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dateTimeSales);
            this.Controls.Add(this.btnToMain);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSales_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnToMain;
        private System.Windows.Forms.DateTimePicker dateTimeSales;
        private System.Windows.Forms.Button btnGenerate;
    }
}