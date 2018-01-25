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
            this.btnRefesh = new System.Windows.Forms.LinkLabel();
            this.cbxAll = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cboxPackages
            // 
            this.cboxPackages.FormattingEnabled = true;
            this.cboxPackages.Location = new System.Drawing.Point(2, 26);
            this.cboxPackages.Name = "cboxPackages";
            this.cboxPackages.Size = new System.Drawing.Size(421, 388);
            this.cboxPackages.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "server";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(442, 25);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(281, 21);
            this.txtUrl.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "key";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(442, 64);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(281, 21);
            this.txtKey.TabIndex = 3;
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(729, 24);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(102, 60);
            this.btnIssue.TabIndex = 4;
            this.btnIssue.Text = "发布";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(442, 91);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(389, 323);
            this.txtLog.TabIndex = 5;
            this.txtLog.Text = "";
            // 
            // btnRefesh
            // 
            this.btnRefesh.AutoSize = true;
            this.btnRefesh.Location = new System.Drawing.Point(57, 7);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(29, 12);
            this.btnRefesh.TabIndex = 6;
            this.btnRefesh.TabStop = true;
            this.btnRefesh.Text = "刷新";
            this.btnRefesh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnRefesh_LinkClicked);
            // 
            // cbxAll
            // 
            this.cbxAll.AutoSize = true;
            this.cbxAll.Location = new System.Drawing.Point(5, 5);
            this.cbxAll.Name = "cbxAll";
            this.cbxAll.Size = new System.Drawing.Size(48, 16);
            this.cbxAll.TabIndex = 7;
            this.cbxAll.Text = "全选";
            this.cbxAll.UseVisualStyleBackColor = true;
            this.cbxAll.CheckedChanged += new System.EventHandler(this.cbxAll_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(239, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(184, 21);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(91, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(29, 12);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.TabStop = true;
            this.btnDelete.Text = "删除";
            this.btnDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnDelete_LinkClicked);
            // 
            // IssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 414);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbxAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefesh);
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
        private System.Windows.Forms.LinkLabel btnRefesh;
        private System.Windows.Forms.CheckBox cbxAll;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.LinkLabel btnDelete;
    }
}