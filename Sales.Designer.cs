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
            this.dateTimeSales = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSales
            // 
            this.dataSales.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dataSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSales.Location = new System.Drawing.Point(170, 192);
            this.dataSales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataSales.Name = "dataSales";
            this.dataSales.RowHeadersWidth = 51;
            this.dataSales.RowTemplate.Height = 24;
            this.dataSales.Size = new System.Drawing.Size(883, 473);
            this.dataSales.TabIndex = 1;
            // 
            // btnToMain
            // 
            this.btnToMain.Location = new System.Drawing.Point(10, 12);
            this.btnToMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnToMain.Name = "btnToMain";
            this.btnToMain.Size = new System.Drawing.Size(75, 35);
            this.btnToMain.TabIndex = 2;
            this.btnToMain.Text = "Back";
            this.btnToMain.UseVisualStyleBackColor = true;
            this.btnToMain.Click += new System.EventHandler(this.btnToMain_Click);
            // 
            // dateTimeSales
            // 
            this.dateTimeSales.Location = new System.Drawing.Point(491, 93);
            this.dateTimeSales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeSales.Name = "dateTimeSales";
            this.dateTimeSales.Size = new System.Drawing.Size(202, 21);
            this.dateTimeSales.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(491, 128);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(201, 42);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate Sales Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PowderBlue;
            this.label1.Location = new System.Drawing.Point(366, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 66);
            this.label1.TabIndex = 17;
            this.label1.Text = "EATS2GO SALES";
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1217, 697);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dateTimeSales);
            this.Controls.Add(this.btnToMain);
            this.Controls.Add(this.dataSales);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSales_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataSales;
        private System.Windows.Forms.Button btnToMain;
        private System.Windows.Forms.DateTimePicker dateTimeSales;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
    }
}