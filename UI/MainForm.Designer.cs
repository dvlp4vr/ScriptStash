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
            this.SuspendLayout();
            // 
            // tvFiles
            // 
            this.tvFiles.Location = new System.Drawing.Point(12, 12);
            this.tvFiles.Name = "tvFiles";
            this.tvFiles.Size = new System.Drawing.Size(156, 433);
            this.tvFiles.TabIndex = 0;
            this.tvFiles.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvFiles_NodeMouseClick);
            // 
            // rtbFileContent
            // 
            this.rtbFileContent.Location = new System.Drawing.Point(189, 12);
            this.rtbFileContent.Name = "rtbFileContent";
            this.rtbFileContent.Size = new System.Drawing.Size(587, 433);
            this.rtbFileContent.TabIndex = 5;
            this.rtbFileContent.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 456);
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
    }
}