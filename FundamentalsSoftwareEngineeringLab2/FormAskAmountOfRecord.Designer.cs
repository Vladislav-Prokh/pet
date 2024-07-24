
namespace FundamentalsSoftwareEngineeringLab2
{
    partial class FormAskAmountOfRecord
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
            this.AcceptAmountRecordsBtn = new System.Windows.Forms.Button();
            this.textBoxAmountRecords = new System.Windows.Forms.TextBox();
            this.labelAmountOfRecords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AcceptAmountRecordsBtn
            // 
            this.AcceptAmountRecordsBtn.Location = new System.Drawing.Point(83, 118);
            this.AcceptAmountRecordsBtn.Name = "AcceptAmountRecordsBtn";
            this.AcceptAmountRecordsBtn.Size = new System.Drawing.Size(75, 23);
            this.AcceptAmountRecordsBtn.TabIndex = 0;
            this.AcceptAmountRecordsBtn.Text = "Ok";
            this.AcceptAmountRecordsBtn.UseVisualStyleBackColor = true;
            this.AcceptAmountRecordsBtn.Click += new System.EventHandler(this.AcceptAmountRecordsBtn_Click);
            // 
            // textBoxAmountRecords
            // 
            this.textBoxAmountRecords.Location = new System.Drawing.Point(102, 44);
            this.textBoxAmountRecords.Name = "textBoxAmountRecords";
            this.textBoxAmountRecords.Size = new System.Drawing.Size(118, 20);
            this.textBoxAmountRecords.TabIndex = 1;
            this.textBoxAmountRecords.TextChanged += new System.EventHandler(this.textBoxAmountRecords_TextChanged);
            // 
            // labelAmountOfRecords
            // 
            this.labelAmountOfRecords.AutoSize = true;
            this.labelAmountOfRecords.Location = new System.Drawing.Point(13, 47);
            this.labelAmountOfRecords.Name = "labelAmountOfRecords";
            this.labelAmountOfRecords.Size = new System.Drawing.Size(83, 13);
            this.labelAmountOfRecords.TabIndex = 2;
            this.labelAmountOfRecords.Text = "AmountRecords";
            // 
            // FormAskAmountOfRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 153);
            this.Controls.Add(this.labelAmountOfRecords);
            this.Controls.Add(this.textBoxAmountRecords);
            this.Controls.Add(this.AcceptAmountRecordsBtn);
            this.Name = "FormAskAmountOfRecord";
            this.Text = "FormAskAmountOfRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcceptAmountRecordsBtn;
        private System.Windows.Forms.TextBox textBoxAmountRecords;
        private System.Windows.Forms.Label labelAmountOfRecords;
    }
}