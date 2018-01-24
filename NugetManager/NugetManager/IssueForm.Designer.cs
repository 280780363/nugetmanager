namespace NugetManager
{
    partial class IssueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueForm));
            this.cboxPackages = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnIssue = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cboxPackages
            // 
            this.cboxPackages.FormattingEnabled = true;
            this.cboxPackages.Location = new System.Drawing.Point(15, 12);
            this.cboxPackages.Name = "cboxPackages";
            this.cboxPackages.Size = new System.Drawing.Size(562, 84);
            this.cboxPackages.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "推送服务器url";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(15, 125);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(454, 21);
            this.txtUrl.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "key";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(15, 164);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(454, 21);
            this.txtKey.TabIndex = 3;
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(475, 124);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(102, 60);
            this.btnIssue.TabIndex = 4;
            this.btnIssue.Text = "发布";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(13, 192);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(564, 228);
            this.txtLog.TabIndex = 5;
            this.txtLog.Text = "";
            // 
            // IssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 427);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxPackages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IssueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuget包发布";
            this.Load += new System.EventHandler(this.IssueForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cboxPackages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.RichTextBox txtLog;
    }
}