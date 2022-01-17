namespace ScriptStash
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tvFiles = new System.Windows.Forms.TreeView();
            this.rtbFileContent = new System.Windows.Forms.RichTextBox();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.btnCreateScript = new System.Windows.Forms.Button();
            this.btnSaveScript = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvFiles
            // 
            this.tvFiles.Location = new System.Drawing.Point(12, 42);
            this.tvFiles.Name = "tvFiles";
            this.tvFiles.Size = new System.Drawing.Size(156, 403);
            this.tvFiles.TabIndex = 0;
            this.tvFiles.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvFiles_NodeMouseClick);
            // 
            // rtbFileContent
            // 
            this.rtbFileContent.Location = new System.Drawing.Point(189, 42);
            this.rtbFileContent.Name = "rtbFileContent";
            this.rtbFileContent.Size = new System.Drawing.Size(587, 403);
            this.rtbFileContent.TabIndex = 5;
            this.rtbFileContent.Text = "";
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Location = new System.Drawing.Point(12, 11);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(156, 23);
            this.btnCreateProject.TabIndex = 6;
            this.btnCreateProject.Text = "Add New Project";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // btnCreateScript
            // 
            this.btnCreateScript.Location = new System.Drawing.Point(189, 11);
            this.btnCreateScript.Name = "btnCreateScript";
            this.btnCreateScript.Size = new System.Drawing.Size(87, 23);
            this.btnCreateScript.TabIndex = 7;
            this.btnCreateScript.Text = "Create Script";
            this.btnCreateScript.UseVisualStyleBackColor = true;
            this.btnCreateScript.Click += new System.EventHandler(this.btnCreateScript_Click);
            // 
            // btnSaveScript
            // 
            this.btnSaveScript.Location = new System.Drawing.Point(701, 13);
            this.btnSaveScript.Name = "btnSaveScript";
            this.btnSaveScript.Size = new System.Drawing.Size(75, 23);
            this.btnSaveScript.TabIndex = 8;
            this.btnSaveScript.Text = "Save";
            this.btnSaveScript.UseVisualStyleBackColor = true;
            this.btnSaveScript.Click += new System.EventHandler(this.btnSaveScript_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 456);
            this.Controls.Add(this.btnSaveScript);
            this.Controls.Add(this.btnCreateScript);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.rtbFileContent);
            this.Controls.Add(this.tvFiles);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Script Stash";
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView tvFiles;
        private RichTextBox rtbFileContent;
        private Button btnCreateProject;
        private Button btnCreateScript;
        private Button btnSaveScript;
    }
}