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
        SelectedProject selectedProject;
        public IssueForm(SelectedProject selectedProject)
        {
            this.selectedProject = selectedProject;
            InitializeComponent();
        }

        private async void btnIssue_Click(object sender, EventArgs e)
        {
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
                        var nupkg = Path.Combine(selectedProject.ProjectDirectoryName, item.ToString());
                        string command = $"dotnet nuget push \"{nupkg}\" -k {txtKey.Text.Trim()} -s {txtUrl.Text.Trim()}";
                        string r = Cmd.Execute(command);
                        await ShowBuildMsg(r);
                    });
                }

                SaveLastData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void DataBind()
        {
            cboxPackages.Items.Clear();
            var list = Directory.EnumerateFiles(selectedProject.ProjectDirectoryName, "*.nupkg", SearchOption.AllDirectories);

            if (list.Any())
            {
                foreach (var item in list)
                {
                    cboxPackages.Items.Add(item.Substring(selectedProject.ProjectDirectoryName.Length));
                }
            }
        }

        private void IssueForm_Load(object sender, EventArgs e)
        {
            DataBind();
            LoadLastData();
        }

        private async Task ShowBuildMsg(string msg)
        {
            await Task.Run(() =>
            {
                if (!txtLog.Text.IsNullOrWhiteSpace())
                    txtLog.AppendText("\r\n");
                txtLog.AppendText(msg);
                txtLog.ScrollToCaret();
            });
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
    }
}
