
namespace FundamentalsSoftwareEngineeringLab2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.editTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correctTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadZNUNewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonSaveCorrectedTxt = new System.Windows.Forms.Button();
            this.buttonCancelCorrectedTxt = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editTextBox
            // 
            this.editTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editTextBox.Location = new System.Drawing.Point(0, 37);
            this.editTextBox.Name = "editTextBox";
            this.editTextBox.Size = new System.Drawing.Size(628, 519);
            this.editTextBox.TabIndex = 0;
            this.editTextBox.Text = "";
            this.editTextBox.TextChanged += new System.EventHandler(this.editTextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuStrip,
            this.editToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuStrip
            // 
            this.FileMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.Size = new System.Drawing.Size(37, 20);
            this.FileMenuStrip.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showStatisticToolStripMenuItem,
            this.correctTextToolStripMenuItem,
            this.loadZNUNewsToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // showStatisticToolStripMenuItem
            // 
            this.showStatisticToolStripMenuItem.Name = "showStatisticToolStripMenuItem";
            this.showStatisticToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showStatisticToolStripMenuItem.Text = "Show statistic";
            this.showStatisticToolStripMenuItem.Click += new System.EventHandler(this.showStatisticToolStripMenuItem_Click);
            // 
            // correctTextToolStripMenuItem
            // 
            this.correctTextToolStripMenuItem.Name = "correctTextToolStripMenuItem";
            this.correctTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.correctTextToolStripMenuItem.Text = "Correct text";
            this.correctTextToolStripMenuItem.Click += new System.EventHandler(this.correctTextToolStripMenuItem_Click);
            // 
            // loadZNUNewsToolStripMenuItem
            // 
            this.loadZNUNewsToolStripMenuItem.Name = "loadZNUNewsToolStripMenuItem";
            this.loadZNUNewsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadZNUNewsToolStripMenuItem.Text = "Load ZNU News";
            this.loadZNUNewsToolStripMenuItem.Click += new System.EventHandler(this.loadZNUNewsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(634, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // buttonSaveCorrectedTxt
            // 
            this.buttonSaveCorrectedTxt.Location = new System.Drawing.Point(549, 0);
            this.buttonSaveCorrectedTxt.Name = "buttonSaveCorrectedTxt";
            this.buttonSaveCorrectedTxt.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveCorrectedTxt.TabIndex = 3;
            this.buttonSaveCorrectedTxt.Text = "Save";
            this.buttonSaveCorrectedTxt.UseVisualStyleBackColor = true;
            this.buttonSaveCorrectedTxt.Click += new System.EventHandler(this.buttonSaveCorrectedTxt_Click);
            // 
            // buttonCancelCorrectedTxt
            // 
            this.buttonCancelCorrectedTxt.Location = new System.Drawing.Point(481, 1);
            this.buttonCancelCorrectedTxt.Name = "buttonCancelCorrectedTxt";
            this.buttonCancelCorrectedTxt.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelCorrectedTxt.TabIndex = 4;
            this.buttonCancelCorrectedTxt.Text = "Cancel";
            this.buttonCancelCorrectedTxt.UseVisualStyleBackColor = true;
            this.buttonCancelCorrectedTxt.Click += new System.EventHandler(this.buttonCancelCorrectedTxt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 566);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.editTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonSaveCorrectedTxt);
            this.Controls.Add(this.buttonCancelCorrectedTxt);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Text edit";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox editTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStatisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correctTextToolStripMenuItem;
        private System.Windows.Forms.Button buttonSaveCorrectedTxt;
        private System.Windows.Forms.Button buttonCancelCorrectedTxt;
        private System.Windows.Forms.ToolStripMenuItem loadZNUNewsToolStripMenuItem;
    }
}

