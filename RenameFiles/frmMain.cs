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

namespace RenameFiles
{

    public partial class frmMain : Form
    {
        private enum FileFlow { Fetch, Save };

        List<string> filesToRenameNames = new List<string>();
        List<string> filesToMoveNames = new List<string>();

        public frmMain()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            txtFileName.Text = DateTime.Now.ToString("yyyy-MM-dd") + " ";
            
            txtFromFolder.Text = Properties.Settings.Default.GetFromFolder;
            txtToFolder.Text = Properties.Settings.Default.SendToFolder;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            lblRenameNumFilesRenamedCount.Text = "0";

            openFileDialog.Title = "Select image files";
            openFileDialog.Filter = "jpg files (*.jpg)|*.jpg";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Multiselect = true;
            openFileDialog.DefaultExt = "jpg";
            openFileDialog.FileName = txtFileName.Text;

            openFileDialog.InitialDirectory = GetInitialDirectory(FileFlow.Save);

            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                filesToRenameNames = openFileDialog.FileNames.ToList();
                txtPath.Text = Path.GetDirectoryName(filesToRenameNames[0]);
            };

            lblRenameNumFilesSelectedCount.Text = filesToRenameNames.Count.ToString();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (filesToRenameNames == null || filesToRenameNames.Count == 0)
            {
                MessageBox.Show("No files to rename");
            }
            else
            {
                int max = GetMax();

                string folder = Path.GetDirectoryName(filesToRenameNames[0]);

                int countToRename = filesToRenameNames.Count;
                int countRenamed = 0;

                foreach ( string file in filesToRenameNames)
                {
                    File.Move(file, folder + @"\" + txtFileName.Text + max.ToString().PadLeft(4, '0') + ".jpg");
                    max++;

                    countToRename--;
                    countRenamed++;

                    lblRenameNumFilesSelectedCount.Text = countToRename.ToString();
                    lblRenameNumFilesRenamedCount.Text = countRenamed.ToString();
                }

                MessageBox.Show(filesToRenameNames.Count + " files renamed.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                filesToRenameNames = new List<string>();
            }

        }

        private int GetMax()
        {
            List<int> ints = new List<int>();

            if (filesToRenameNames.Count > 0)
            {
                string folder = Path.GetDirectoryName(filesToRenameNames[0]);
                string[] files = Directory.GetFiles(folder);
               

                if(files.Count() > 0)
                {
                    foreach(string file in files)
                    {
                        if (file.Contains(txtFileName.Text))
                        {
                            string intBit = Path.GetFileNameWithoutExtension(file).Replace(txtFileName.Text, "");

                            if (Int32.TryParse(intBit, out int number))
                            {
                                ints.Add(number);
                            }
                        }
                    }
                }
            }

            if (ints.Count > 0)
            {
                return ints.Max() + 1;
            }
            else return 0;
        }

        private void btnGetFrom_Click(object sender, EventArgs e)
        {
            lblNumFilesMovedCount.Text = "0";

            openFileDialog.Title = "Select image files";
            openFileDialog.Filter = "jpg files (*.jpg)|*.jpg";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Multiselect = true;
            openFileDialog.DefaultExt = "jpg";
            openFileDialog.FileName = txtFileName.Text;

            openFileDialog.InitialDirectory = GetInitialDirectory(FileFlow.Fetch);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filesToMoveNames = openFileDialog.FileNames.ToList();
                
                txtFromFolder.Text = Path.GetDirectoryName(openFileDialog.FileName);
            };

            lblNumFilesSelectedCount.Text = filesToMoveNames != null
                                                ? filesToMoveNames.Count.ToString()
                                                : "0";
        }

        private string GetInitialDirectory(FileFlow fileFlow)
        {
            string setting = @"C\:"; 
            string initialDirectory = @"C\:";

            switch (fileFlow)
            {
                case FileFlow.Fetch:
                    setting = Properties.Settings.Default.GetFromFolder;
                    break;
                case FileFlow.Save:
                    setting = Properties.Settings.Default.SendToFolder;
                    break;
            }

            if (Directory.Exists(setting))
            {
                initialDirectory = setting;
            } 
            else if(Directory.GetParent(setting) != null)
            {
                initialDirectory = Directory.GetParent(setting).FullName;
            }

            return initialDirectory;
        }

        private void btnMoveTo_Click(object sender, EventArgs e)
        {
            lblNumFilesMovedCount.Text = "0";
            folderBrowserDialog.SelectedPath = GetInitialDirectory(FileFlow.Save);

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtToFolder.Text = folderBrowserDialog.SelectedPath;
            };
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtFromFolder.Text))
            {
                MessageBox.Show("'Get From' folder does not exist.", "Check Folder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(txtToFolder.Text))
            {
                MessageBox.Show("'Move To' folder does not exist.", "Check Folder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (filesToMoveNames == null || filesToMoveNames.Count == 0 )
            {
                MessageBox.Show("No files have been selected.", "Select Files", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int countToMove = filesToMoveNames.Count;
            int countMoved = 0;

            foreach (var file in filesToMoveNames)
            {
                File.Move(file, txtToFolder.Text + @"\" + Path.GetFileName(file));

                countToMove--;
                countMoved++;

                lblNumFilesSelectedCount.Text = countToMove.ToString();
                lblNumFilesMovedCount.Text = countMoved.ToString();
            }

            filesToMoveNames = new List<string>();

            txtPath.Text = txtToFolder.Text;
            Properties.Settings.Default.GetFromFolder = txtFromFolder.Text;
            Properties.Settings.Default.SendToFolder = txtToFolder.Text;
            Properties.Settings.Default.Save();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
