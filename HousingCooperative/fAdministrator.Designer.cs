namespace HousingCooperative
{
    partial class fAdministrator
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
            this.btnOwners = new System.Windows.Forms.Button();
            this.btnHouses = new System.Windows.Forms.Button();
            this.btnOwnersOfHouses = new System.Windows.Forms.Button();
            this.btnCounters = new System.Windows.Forms.Button();
            this.btnRates = new System.Windows.Forms.Button();
            this.btnReceipts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOwners
            // 
            this.btnOwners.Location = new System.Drawing.Point(12, 12);
            this.btnOwners.Name = "btnOwners";
            this.btnOwners.Size = new System.Drawing.Size(193, 23);
            this.btnOwners.TabIndex = 0;
            this.btnOwners.Text = "Владельцы";
            this.btnOwners.UseVisualStyleBackColor = true;
            this.btnOwners.Click += new System.EventHandler(this.btnOwners_Click);
            // 
            // btnHouses
            // 
            this.btnHouses.Location = new System.Drawing.Point(12, 50);
            this.btnHouses.Name = "btnHouses";
            this.btnHouses.Size = new System.Drawing.Size(193, 23);
            this.btnHouses.TabIndex = 1;
            this.btnHouses.Text = "Квартиры";
            this.btnHouses.UseVisualStyleBackColor = true;
            this.btnHouses.Click += new System.EventHandler(this.btnHouses_Click);
            // 
            // btnOwnersOfHouses
            // 
            this.btnOwnersOfHouses.Location = new System.Drawing.Point(12, 96);
            this.btnOwnersOfHouses.Name = "btnOwnersOfHouses";
            this.btnOwnersOfHouses.Size = new System.Drawing.Size(193, 23);
            this.btnOwnersOfHouses.TabIndex = 2;
            this.btnOwnersOfHouses.Text = "Владельцы квартир";
            this.btnOwnersOfHouses.UseVisualStyleBackColor = true;
            this.btnOwnersOfHouses.Click += new System.EventHandler(this.btnOwnersOfHouses_Click);
            // 
            // btnCounters
            // 
            this.btnCounters.Location = new System.Drawing.Point(12, 145);
            this.btnCounters.Name = "btnCounters";
            this.btnCounters.Size = new System.Drawing.Size(193, 23);
            this.btnCounters.TabIndex = 3;
            this.btnCounters.Text = "Счётчики";
            this.btnCounters.UseVisualStyleBackColor = true;
            this.btnCounters.Click += new System.EventHandler(this.btnCounters_Click);
            // 
            // btnRates
            // 
            this.btnRates.Location = new System.Drawing.Point(12, 187);
            this.btnRates.Name = "btnRates";
            this.btnRates.Size = new System.Drawing.Size(193, 23);
            this.btnRates.TabIndex = 4;
            this.btnRates.Text = "Тарифы";
            this.btnRates.UseVisualStyleBackColor = true;
            this.btnRates.Click += new System.EventHandler(this.btnRates_Click);
            // 
            // btnReceipts
            // 
            this.btnReceipts.Location = new System.Drawing.Point(12, 230);
            this.btnReceipts.Name = "btnReceipts";
            this.btnReceipts.Size = new System.Drawing.Size(193, 23);
            this.btnReceipts.TabIndex = 5;
            this.btnReceipts.Text = "Квитанции";
            this.btnReceipts.UseVisualStyleBackColor = true;
            this.btnReceipts.Click += new System.EventHandler(this.btnReceipts_Click);
            // 
            // fAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 297);
            this.Controls.Add(this.btnReceipts);
            this.Controls.Add(this.btnRates);
            this.Controls.Add(this.btnCounters);
            this.Controls.Add(this.btnOwnersOfHouses);
            this.Controls.Add(this.btnHouses);
            this.Controls.Add(this.btnOwners);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOwners;
        private System.Windows.Forms.Button btnHouses;
        private System.Windows.Forms.Button btnOwnersOfHouses;
        private System.Windows.Forms.Button btnCounters;
        private System.Windows.Forms.Button btnRates;
        private System.Windows.Forms.Button btnReceipts;
    }
}