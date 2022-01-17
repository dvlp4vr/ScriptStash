
namespace ScriptStash.Components.Dialogs
{
    public partial class TextInputBox : Form
    {
        public string? Result { get; set; }

        public TextInputBox(string formName, string labelText)
        {
            InitializeComponent();

            this.Text = formName;
            lblInput.Text = labelText;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Result = String.Empty;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Result = txtInput.Text;
            this.Close();
        }
    }
}
