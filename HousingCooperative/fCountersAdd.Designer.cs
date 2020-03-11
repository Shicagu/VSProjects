namespace HousingCooperative
{
    partial class fCountersAdd
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
            this.cbTypeCounter = new System.Windows.Forms.ComboBox();
            this.cbNumberHouse = new System.Windows.Forms.ComboBox();
            this.nudInformation = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTypeCounter
            // 
            this.cbTypeCounter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeCounter.FormattingEnabled = true;
            this.cbTypeCounter.Location = new System.Drawing.Point(137, 12);
            this.cbTypeCounter.Name = "cbTypeCounter";
            this.cbTypeCounter.Size = new System.Drawing.Size(154, 21);
            this.cbTypeCounter.TabIndex = 0;
            // 
            // cbNumberHouse
            // 
            this.cbNumberHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumberHouse.FormattingEnabled = true;
            this.cbNumberHouse.Location = new System.Drawing.Point(137, 39);
            this.cbNumberHouse.Name = "cbNumberHouse";
            this.cbNumberHouse.Size = new System.Drawing.Size(154, 21);
            this.cbNumberHouse.TabIndex = 1;
            // 
            // nudInformation
            // 
            this.nudInformation.Location = new System.Drawing.Point(137, 66);
            this.nudInformation.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudInformation.Name = "nudInformation";
            this.nudInformation.Size = new System.Drawing.Size(154, 20);
            this.nudInformation.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тип счётчика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер квартиры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Показания";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(15, 103);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Сохранить";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(213, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // fCountersAdd
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(300, 142);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudInformation);
            this.Controls.Add(this.cbNumberHouse);
            this.Controls.Add(this.cbTypeCounter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fCountersAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление счётчиками";
            ((System.ComponentModel.ISupportInitialize)(this.nudInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.ComboBox cbTypeCounter;
        protected internal System.Windows.Forms.ComboBox cbNumberHouse;
        protected internal System.Windows.Forms.NumericUpDown nudInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}