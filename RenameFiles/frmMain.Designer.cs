namespace RenameFiles
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbxMoveFiles = new System.Windows.Forms.GroupBox();
            this.lblNumFilesMovedCount = new System.Windows.Forms.Label();
            this.lblNumFilesMoved = new System.Windows.Forms.Label();
            this.lblNumFilesSelectedCount = new System.Windows.Forms.Label();
            this.lblNumFilesSelected = new System.Windows.Forms.Label();
            this.txtToFolder = new System.Windows.Forms.TextBox();
            this.txtFromFolder = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnMoveTo = new System.Windows.Forms.Button();
            this.btnGetFrom = new System.Windows.Forms.Button();
            this.gbxRenameFiles = new System.Windows.Forms.GroupBox();
            this.lblRenameNumFilesRenamedCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRenameNumFilesMoved = new System.Windows.Forms.Label();
            this.lblRenameNumFilesSelectedCount = new System.Windows.Forms.Label();
            this.lblRenameNumFilesSelected = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gbxMoveFiles.SuspendLayout();
            this.gbxRenameFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(6, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse:";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(87, 21);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(541, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(553, 73);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 2;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(87, 47);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(541, 20);
            this.txtFileName.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // gbxMoveFiles
            // 
            this.gbxMoveFiles.Controls.Add(this.lblNumFilesMovedCount);
            this.gbxMoveFiles.Controls.Add(this.lblNumFilesMoved);
            this.gbxMoveFiles.Controls.Add(this.lblNumFilesSelectedCount);
            this.gbxMoveFiles.Controls.Add(this.lblNumFilesSelected);
            this.gbxMoveFiles.Controls.Add(this.txtToFolder);
            this.gbxMoveFiles.Controls.Add(this.txtFromFolder);
            this.gbxMoveFiles.Controls.Add(this.btnMove);
            this.gbxMoveFiles.Controls.Add(this.btnMoveTo);
            this.gbxMoveFiles.Controls.Add(this.btnGetFrom);
            this.gbxMoveFiles.Location = new System.Drawing.Point(12, 12);
            this.gbxMoveFiles.Name = "gbxMoveFiles";
            this.gbxMoveFiles.Size = new System.Drawing.Size(634, 106);
            this.gbxMoveFiles.TabIndex = 4;
            this.gbxMoveFiles.TabStop = false;
            this.gbxMoveFiles.Text = "Move Files";
            // 
            // lblNumFilesMovedCount
            // 
            this.lblNumFilesMovedCount.AutoSize = true;
            this.lblNumFilesMovedCount.Location = new System.Drawing.Point(389, 81);
            this.lblNumFilesMovedCount.Name = "lblNumFilesMovedCount";
            this.lblNumFilesMovedCount.Size = new System.Drawing.Size(13, 13);
            this.lblNumFilesMovedCount.TabIndex = 9;
            this.lblNumFilesMovedCount.Text = "0";
            this.lblNumFilesMovedCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumFilesMoved
            // 
            this.lblNumFilesMoved.AutoSize = true;
            this.lblNumFilesMoved.Location = new System.Drawing.Point(264, 81);
            this.lblNumFilesMoved.Name = "lblNumFilesMoved";
            this.lblNumFilesMoved.Size = new System.Drawing.Size(119, 13);
            this.lblNumFilesMoved.TabIndex = 8;
            this.lblNumFilesMoved.Text = "Number of Files Moved:";
            this.lblNumFilesMoved.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumFilesSelectedCount
            // 
            this.lblNumFilesSelectedCount.AutoSize = true;
            this.lblNumFilesSelectedCount.Location = new System.Drawing.Point(218, 81);
            this.lblNumFilesSelectedCount.Name = "lblNumFilesSelectedCount";
            this.lblNumFilesSelectedCount.Size = new System.Drawing.Size(13, 13);
            this.lblNumFilesSelectedCount.TabIndex = 7;
            this.lblNumFilesSelectedCount.Text = "0";
            this.lblNumFilesSelectedCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumFilesSelected
            // 
            this.lblNumFilesSelected.AutoSize = true;
            this.lblNumFilesSelected.Location = new System.Drawing.Point(84, 81);
            this.lblNumFilesSelected.Name = "lblNumFilesSelected";
            this.lblNumFilesSelected.Size = new System.Drawing.Size(128, 13);
            this.lblNumFilesSelected.TabIndex = 6;
            this.lblNumFilesSelected.Text = "Number of Files Selected:";
            this.lblNumFilesSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtToFolder
            // 
            this.txtToFolder.Location = new System.Drawing.Point(87, 50);
            this.txtToFolder.Name = "txtToFolder";
            this.txtToFolder.Size = new System.Drawing.Size(541, 20);
            this.txtToFolder.TabIndex = 4;
            // 
            // txtFromFolder
            // 
            this.txtFromFolder.Location = new System.Drawing.Point(87, 21);
            this.txtFromFolder.Name = "txtFromFolder";
            this.txtFromFolder.Size = new System.Drawing.Size(541, 20);
            this.txtFromFolder.TabIndex = 3;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(553, 76);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnMoveTo
            // 
            this.btnMoveTo.Location = new System.Drawing.Point(6, 48);
            this.btnMoveTo.Name = "btnMoveTo";
            this.btnMoveTo.Size = new System.Drawing.Size(75, 23);
            this.btnMoveTo.TabIndex = 1;
            this.btnMoveTo.Text = "Move To:";
            this.btnMoveTo.UseVisualStyleBackColor = true;
            this.btnMoveTo.Click += new System.EventHandler(this.btnMoveTo_Click);
            // 
            // btnGetFrom
            // 
            this.btnGetFrom.Location = new System.Drawing.Point(6, 19);
            this.btnGetFrom.Name = "btnGetFrom";
            this.btnGetFrom.Size = new System.Drawing.Size(75, 23);
            this.btnGetFrom.TabIndex = 0;
            this.btnGetFrom.Text = "Get From:";
            this.btnGetFrom.UseVisualStyleBackColor = true;
            this.btnGetFrom.Click += new System.EventHandler(this.btnGetFrom_Click);
            // 
            // gbxRenameFiles
            // 
            this.gbxRenameFiles.Controls.Add(this.lblRenameNumFilesRenamedCount);
            this.gbxRenameFiles.Controls.Add(this.label1);
            this.gbxRenameFiles.Controls.Add(this.lblRenameNumFilesMoved);
            this.gbxRenameFiles.Controls.Add(this.txtPath);
            this.gbxRenameFiles.Controls.Add(this.lblRenameNumFilesSelectedCount);
            this.gbxRenameFiles.Controls.Add(this.btnBrowse);
            this.gbxRenameFiles.Controls.Add(this.lblRenameNumFilesSelected);
            this.gbxRenameFiles.Controls.Add(this.txtFileName);
            this.gbxRenameFiles.Controls.Add(this.btnRename);
            this.gbxRenameFiles.Location = new System.Drawing.Point(12, 124);
            this.gbxRenameFiles.Name = "gbxRenameFiles";
            this.gbxRenameFiles.Size = new System.Drawing.Size(634, 104);
            this.gbxRenameFiles.TabIndex = 5;
            this.gbxRenameFiles.TabStop = false;
            this.gbxRenameFiles.Text = "Rename Files";
            // 
            // lblRenameNumFilesRenamedCount
            // 
            this.lblRenameNumFilesRenamedCount.AutoSize = true;
            this.lblRenameNumFilesRenamedCount.Location = new System.Drawing.Point(402, 78);
            this.lblRenameNumFilesRenamedCount.Name = "lblRenameNumFilesRenamedCount";
            this.lblRenameNumFilesRenamedCount.Size = new System.Drawing.Size(13, 13);
            this.lblRenameNumFilesRenamedCount.TabIndex = 13;
            this.lblRenameNumFilesRenamedCount.Text = "0";
            this.lblRenameNumFilesRenamedCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRenameNumFilesMoved
            // 
            this.lblRenameNumFilesMoved.AutoSize = true;
            this.lblRenameNumFilesMoved.Location = new System.Drawing.Point(264, 78);
            this.lblRenameNumFilesMoved.Name = "lblRenameNumFilesMoved";
            this.lblRenameNumFilesMoved.Size = new System.Drawing.Size(132, 13);
            this.lblRenameNumFilesMoved.TabIndex = 12;
            this.lblRenameNumFilesMoved.Text = "Number of Files Renamed:";
            this.lblRenameNumFilesMoved.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRenameNumFilesSelectedCount
            // 
            this.lblRenameNumFilesSelectedCount.AutoSize = true;
            this.lblRenameNumFilesSelectedCount.Location = new System.Drawing.Point(218, 78);
            this.lblRenameNumFilesSelectedCount.Name = "lblRenameNumFilesSelectedCount";
            this.lblRenameNumFilesSelectedCount.Size = new System.Drawing.Size(13, 13);
            this.lblRenameNumFilesSelectedCount.TabIndex = 11;
            this.lblRenameNumFilesSelectedCount.Text = "0";
            this.lblRenameNumFilesSelectedCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRenameNumFilesSelected
            // 
            this.lblRenameNumFilesSelected.AutoSize = true;
            this.lblRenameNumFilesSelected.Location = new System.Drawing.Point(84, 78);
            this.lblRenameNumFilesSelected.Name = "lblRenameNumFilesSelected";
            this.lblRenameNumFilesSelected.Size = new System.Drawing.Size(128, 13);
            this.lblRenameNumFilesSelected.TabIndex = 10;
            this.lblRenameNumFilesSelected.Text = "Number of Files Selected:";
            this.lblRenameNumFilesSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 243);
            this.Controls.Add(this.gbxRenameFiles);
            this.Controls.Add(this.gbxMoveFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename Files";
            this.gbxMoveFiles.ResumeLayout(false);
            this.gbxMoveFiles.PerformLayout();
            this.gbxRenameFiles.ResumeLayout(false);
            this.gbxRenameFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox gbxMoveFiles;
        private System.Windows.Forms.TextBox txtToFolder;
        private System.Windows.Forms.TextBox txtFromFolder;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnMoveTo;
        private System.Windows.Forms.Button btnGetFrom;
        private System.Windows.Forms.GroupBox gbxRenameFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label lblNumFilesMovedCount;
        private System.Windows.Forms.Label lblNumFilesMoved;
        private System.Windows.Forms.Label lblNumFilesSelectedCount;
        private System.Windows.Forms.Label lblNumFilesSelected;
        private System.Windows.Forms.Label lblRenameNumFilesRenamedCount;
        private System.Windows.Forms.Label lblRenameNumFilesMoved;
        private System.Windows.Forms.Label lblRenameNumFilesSelectedCount;
        private System.Windows.Forms.Label lblRenameNumFilesSelected;
    }
}

