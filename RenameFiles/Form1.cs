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
        List<string> fileNames = new List<string>();

        public frmMain()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            txtFileName.Text = DateTime.Now.ToString("yyyy-MM-dd") + " ";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
            List<int> ints = new List<int>();
            openFileDialog.Title = "Select image files";
            openFileDialog.Filter = "jpg files (*.jpg)|*.jpg";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Multiselect = true;
            openFileDialog.DefaultExt = "jpg";
            openFileDialog.FileName = txtFileName.Text;
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                fileNames = openFileDialog.FileNames.ToList();
                txtPath.Text = Path.GetDirectoryName(fileNames[0]);
            };

        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (fileNames == null || fileNames.Count == 0)
            {
                MessageBox.Show("No files to rename");
            }
            else
            {
                int max = GetMax();

                string folder = Path.GetDirectoryName(fileNames[0]);


                foreach( string file in fileNames)
                {
                    File.Move(file, folder + @"\" + txtFileName.Text + max.ToString().PadLeft(4, '0') + ".jpg");
                    max++;
                }

                MessageBox.Show(fileNames.Count + " files renamed.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                fileNames = new List<string>();
            }

        }

        private int GetMax()
        {
            List<int> ints = new List<int>();

            if (fileNames.Count > 0)
            {
                string folder = Path.GetDirectoryName(fileNames[0]);
                string[] files = Directory.GetFiles(folder);
               

                if(files.Count() > 0)
                {
                    foreach(string file in files)
                    {
                        if (file.Contains(txtFileName.Text))
                        {
                            string intBit = Path.GetFileNameWithoutExtension(file).Replace(txtFileName.Text, "");
                            
                            int number;
                            if (Int32.TryParse(intBit, out number))
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
    }
}
