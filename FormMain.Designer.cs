namespace FileSeek
{
    partial class FormMain
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
            this.textBoxPath1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxPath2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.checkedListBoxPath1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxPath2 = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBoxFiles = new System.Windows.Forms.CheckedListBox();
            this.labelFilesCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPath1
            // 
            this.textBoxPath1.Location = new System.Drawing.Point(75, 6);
            this.textBoxPath1.Name = "textBoxPath1";
            this.textBoxPath1.Size = new System.Drawing.Size(472, 20);
            this.textBoxPath1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1st level :";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(553, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(197, 47);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxPath2
            // 
            this.textBoxPath2.Location = new System.Drawing.Point(75, 32);
            this.textBoxPath2.Name = "textBoxPath2";
            this.textBoxPath2.Size = new System.Drawing.Size(472, 20);
            this.textBoxPath2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "2nd level :";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(13, 483);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(35, 13);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "status";
            // 
            // checkedListBoxPath1
            // 
            this.checkedListBoxPath1.FormattingEnabled = true;
            this.checkedListBoxPath1.Location = new System.Drawing.Point(15, 58);
            this.checkedListBoxPath1.Name = "checkedListBoxPath1";
            this.checkedListBoxPath1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkedListBoxPath1.Size = new System.Drawing.Size(472, 304);
            this.checkedListBoxPath1.TabIndex = 3;
            // 
            // checkedListBoxPath2
            // 
            this.checkedListBoxPath2.FormattingEnabled = true;
            this.checkedListBoxPath2.Location = new System.Drawing.Point(493, 58);
            this.checkedListBoxPath2.Name = "checkedListBoxPath2";
            this.checkedListBoxPath2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkedListBoxPath2.Size = new System.Drawing.Size(472, 304);
            this.checkedListBoxPath2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Level 2";
            // 
            // checkedListBoxFiles
            // 
            this.checkedListBoxFiles.FormattingEnabled = true;
            this.checkedListBoxFiles.Location = new System.Drawing.Point(15, 368);
            this.checkedListBoxFiles.Name = "checkedListBoxFiles";
            this.checkedListBoxFiles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkedListBoxFiles.Size = new System.Drawing.Size(950, 109);
            this.checkedListBoxFiles.TabIndex = 3;
            // 
            // labelFilesCount
            // 
            this.labelFilesCount.AutoSize = true;
            this.labelFilesCount.Location = new System.Drawing.Point(756, 22);
            this.labelFilesCount.Name = "labelFilesCount";
            this.labelFilesCount.Size = new System.Drawing.Size(55, 13);
            this.labelFilesCount.TabIndex = 1;
            this.labelFilesCount.Text = "files count";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 505);
            this.Controls.Add(this.checkedListBoxFiles);
            this.Controls.Add(this.checkedListBoxPath2);
            this.Controls.Add(this.checkedListBoxPath1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelFilesCount);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPath2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPath1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxPath2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.CheckedListBox checkedListBoxPath1;
        private System.Windows.Forms.CheckedListBox checkedListBoxPath2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListBoxFiles;
        private System.Windows.Forms.Label labelFilesCount;
    }
}

