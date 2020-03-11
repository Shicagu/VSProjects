namespace HousingCooperative
{
    partial class fRatesAdd
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
            this.nudRate = new System.Windows.Forms.NumericUpDown();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.dtMonthYear = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbRate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).BeginInit();
            this.SuspendLayout();
            // 
            // nudRate
            // 
            this.nudRate.DecimalPlaces = 2;
            this.nudRate.Location = new System.Drawing.Point(164, 34);
            this.nudRate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRate.Name = "nudRate";
            this.nudRate.Size = new System.Drawing.Size(120, 20);
            this.nudRate.TabIndex = 1;
            // 
            // tbUnit
            // 
            this.tbUnit.Location = new System.Drawing.Point(164, 60);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.Size = new System.Drawing.Size(120, 20);
            this.tbUnit.TabIndex = 2;
            // 
            // dtMonthYear
            // 
            this.dtMonthYear.CustomFormat = "MMMM yyyy";
            this.dtMonthYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMonthYear.Location = new System.Drawing.Point(164, 86);
            this.dtMonthYear.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.dtMonthYear.Name = "dtMonthYear";
            this.dtMonthYear.ShowUpDown = true;
            this.dtMonthYear.Size = new System.Drawing.Size(120, 20);
            this.dtMonthYear.TabIndex = 3;
            this.dtMonthYear.Value = new System.DateTime(2020, 8, 9, 16, 32, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Тариф";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ед. изм.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Месяц и год начала";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 128);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Сохранить";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(211, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Location = new System.Drawing.Point(161, 9);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(35, 13);
            this.lbRate.TabIndex = 8;
            this.lbRate.Text = "label5";
            // 
            // fRatesAdd
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(298, 163);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lbRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtMonthYear);
            this.Controls.Add(this.tbUnit);
            this.Controls.Add(this.nudRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fRatesAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление тарифами";
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        protected internal System.Windows.Forms.NumericUpDown nudRate;
        protected internal System.Windows.Forms.TextBox tbUnit;
        protected internal System.Windows.Forms.DateTimePicker dtMonthYear;
        protected internal System.Windows.Forms.Label lbRate;
    }
}