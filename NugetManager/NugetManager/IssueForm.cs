using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NugetManager.Utils;
namespace NugetManager
{
    public partial class IssueForm : Form
    {
        private readonly string baseDir;
        private List<string> _allNupkgs;
        public IssueForm(SelectedProject selectedProject)
            : this(selectedProject.ProjectDirectoryName)
        {
        }

        public IssueForm(string solutionDir)
        {
            baseDir = solutionDir;
            InitializeComponent();
        }

        private async void btnIssue_Click(object sender, EventArgs e)
        {
            btnIssue.Enabled = false;
            btnIssue.Text = "正在发布...";
            try
            {
                if (txtUrl.Text.IsNullOrWhiteSpace())
                {
                    MessageBox.Show("Nuget推送Url地址不能为空!");
                    return;
                }
                if (txtKey.Text.IsNullOrWhiteSpace())
                {
                    MessageBox.Show("Nuget推送Key不能为空!");
                    return;
                }

                foreach (var item in cboxPackages.CheckedItems)
                {
                    await Task.Run(async () =>
                    {
                        var nupkg = Path.Combine(baseDir, item.ToString());
                        string command = $"dotnet nuget push \"{nupkg}\" -k {txtKey.Text.Trim()} -s {txtUrl.Text.Trim()}";
                        string r = Cmd.Execute(command);
                        await Log(r);
                    });
                }

                SaveLastData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnIssue.Enabled = true;
            btnIssue.Text = "发布";
        }


        private void DataBind(string search = null)
        {
            cbxAll.Checked = false;
            cboxPackages.Items.Clear();
            _allNupkgs = Directory
                  .EnumerateFiles(baseDir, "*.nupkg", SearchOption.AllDirectories)
                  .Select(r => r.Substring(baseDir.Length + 1))
                  .Where(r => !r.StartsWith("packages"))
                  .ToList();

            if (search.IsNullOrWhiteSpace())
                cboxPackages.Items.AddRange(_allNupkgs.ToArray());
            else
                cboxPackages.Items.AddRange(_allNupkgs.Where(r => Path.GetFileName(r).Contains(search.Trim())).ToArray());
        }

        private void IssueForm_Load(object sender, EventArgs e)
        {
            DataBind();
            LoadLastData();
        }

        private async Task Log(string msg)
        {
            if (!txtLog.Text.IsNullOrWhiteSpace())
                txtLog.AppendText("\r\n");
            txtLog.AppendText(DateTime.Now.ToString("HH:mm:ss\t"));
            txtLog.AppendText(msg);
            txtLog.AppendText("\r\n");
            txtLog.ScrollToCaret();

            await Task.CompletedTask;
        }

        private void SaveLastData()
        {
            LastDataConfiguration.Instance.Set("NugetUrl", txtUrl.Text);
            LastDataConfiguration.Instance.Set("NugetKey", txtKey.Text);

            LastDataConfiguration.Instance.Save();
        }

        private void LoadLastData()
        {
            var url = LastDataConfiguration.Instance.Get("NugetUrl");
            var key = LastDataConfiguration.Instance.Get("NugetKey");
            txtUrl.Text = url.IsNullOrWhiteSpace() ? "https://www.nuget.org" : url;
            txtKey.Text = key;
        }

        private void btnRefesh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataBind();
        }

        private void cbxAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cboxPackages.Items.Count; i++)
            {
                cboxPackages.SetItemChecked(i, cbxAll.Checked);
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            DataBind(txtSearch.Text.Trim());
        }

        private async void btnDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cboxPackages.CheckedItems.Count == 0)
                return;
            foreach (var item in cboxPackages.CheckedItems)
            {
                var path = Path.Combine(baseDir, item.ToString());
                if (File.Exists(path))
                {
                    try
                    {
                        File.Delete(path);
                        await Log($"{path} 删除成功!");
                    }
                    catch (Exception ex)
                    {
                        await Log(ex.Message);
                    }
                }
            }

            DataBind();
        }
    }
}