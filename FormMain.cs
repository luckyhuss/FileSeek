using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSeek
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            checkedListBoxPath1.Items.Clear();
            checkedListBoxPath2.Items.Clear();
            checkedListBoxFiles.Items.Clear();
            labelStatus.Text = labelFilesCount.Text = string.Empty;

            await PopulateFilesAsync();
        }

        private async Task PopulateFilesAsync()
        {
            var path = new List<string>();
            path.Add(textBoxPath2.Text);
            IEnumerable<string> path1 = path;

            if (!string.IsNullOrEmpty(textBoxPath1.Text))
            {
                // list top level folders
                labelStatus.Text = "searching " + textBoxPath1.Text + " .. ";
                path1 = await GetDirectoriesAsync(textBoxPath1.Text, 1);
            }
            
            foreach (var s1 in path1)
            {
                var indexPath1 = checkedListBoxPath1.Items.Add(s1);

                // search for subfolders
                labelStatus.Text = "searching " + s1 + " .. ";
                var path2 = await GetDirectoriesAsync(s1, 2);

                foreach (var s2 in path2)
                {
                    var indexPath2 = checkedListBoxPath2.Items.Add(s2);

                    // list all files
                    labelStatus.Text = "loading files from " + s2 + " .. ";
                    var files = await GetFilesAsync(s2);

                    foreach (var f in files)
                    {
                        var indexfile = checkedListBoxFiles.Items.Add(f);
                        labelFilesCount.Text = string.Format("Files count : {0}", checkedListBoxFiles.Items.Count);

                        MessageBox.Show(Path.GetDirectoryName(f));
                        MessageBox.Show(Path.GetDirectoryName(f));

                        // check the item
                        checkedListBoxFiles.SetItemCheckState(indexfile, CheckState.Checked);
                    }

                    // check the item
                    checkedListBoxPath2.SetItemCheckState(indexPath2, CheckState.Checked);
                }

                // check the item
                checkedListBoxPath1.SetItemCheckState(indexPath1, CheckState.Checked);
            }

            labelStatus.Text = "search completed";
        }

        private async Task<IEnumerable<string>> GetDirectoriesAsync(string path, int level)
        {
            if (level == 2)
            {
                return await Task.Run(() => Directory.EnumerateDirectories(path.Trim())
                .Where(dir => dir.ToLower().Contains("pv") || dir.ToLower().Contains("proposition")));
            }
            if (level == 1)
            {
                return await Task.Run(() => Directory.EnumerateDirectories(path.Trim()));
            }
            return null;
        }

        private async Task<IEnumerable<string>> GetFilesAsync(string path)
        {
            return await Task.Run(() => Directory.EnumerateFiles(path.Trim(), "*", SearchOption.AllDirectories)
            .Where(file => file.ToLower().Contains(".doc") || file.ToLower().Contains(".pdf")));
        }
    }
}
