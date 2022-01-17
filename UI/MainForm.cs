using ScriptStash.Components.Dialogs;

namespace ScriptStash
{
    public partial class MainForm : Form
    {
        private const string CONST_PROJECT_NAME = "ScriptStash";

        private readonly string _scriptDirectory;

        public MainForm()
        {
            InitializeComponent();

            _scriptDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), CONST_PROJECT_NAME);

            if (!Directory.Exists(_scriptDirectory))
            {
                Directory.CreateDirectory(_scriptDirectory);
            }

            LoadFiles();
        }


        #region Methods

        private void LoadFiles()
        {
            tvFiles.Nodes.Clear();

            foreach (var directory in Directory.GetDirectories(_scriptDirectory))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(directory);
                TreeNode directoryNode = new TreeNode(directoryInfo.Name);

                foreach (var file in Directory.GetFiles(directoryInfo.FullName))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    directoryNode.Nodes.Add(fileInfo.FullName, fileInfo.Name);
                }

                tvFiles.Nodes.Add(directoryNode);
            }

            tvFiles.ExpandAll();
        }

        private string? GetInputBoxText(object sender)
        {
            if (sender is TextInputBox)
            {
                return ((TextInputBox)sender).Result;
            }

            return String.Empty;
        }

        #endregion
        #region Events

        private void tvFiles_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string fileName = e.Node.Name;

            if (!String.IsNullOrEmpty(fileName))
            {
                rtbFileContent.LoadFile(fileName);
            }
        }
        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            TextInputBox projectInputBox = new TextInputBox("Create Project", "Enter Project Name:");
            projectInputBox.FormClosed += new FormClosedEventHandler(ProjectInputForm_FormClosed);
            projectInputBox.ShowDialog();
            projectInputBox.Dispose();
        }
        private void btnCreateScript_Click(object sender, EventArgs e)
        {

        }
        private void btnSaveScript_Click(object sender, EventArgs e)
        {

        }
        private void ProjectInputForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string? projectName = GetInputBoxText(sender);

            if (!String.IsNullOrEmpty(projectName))
            {
                string projectDirectory = Path.Combine(_scriptDirectory, projectName);

                if (!Directory.Exists(projectDirectory))
                {
                    Directory.CreateDirectory(Path.Combine(_scriptDirectory, projectName));
                    LoadFiles();
                }
            }
        }

        #endregion
    }
}