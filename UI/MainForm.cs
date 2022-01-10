namespace ScriptStash
{
    public partial class MainForm : Form
    {
        private const string CONST_PROJECT_NAME = "ScriptStash";

        public MainForm()
        {
            InitializeComponent();
            PreLoadFiles();
        }

        private void PreLoadFiles()
        {
            string scriptDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), CONST_PROJECT_NAME);

            if (!Directory.Exists(scriptDirectory))
            {
                Directory.CreateDirectory(scriptDirectory);
            }

            foreach (var directory in Directory.GetDirectories(scriptDirectory))
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
        }

        private void tvFiles_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string fileName = e.Node.Name;

            if (!String.IsNullOrEmpty(fileName))
            {
                rtbFileContent.LoadFile(fileName);
            }
        }
    }
}