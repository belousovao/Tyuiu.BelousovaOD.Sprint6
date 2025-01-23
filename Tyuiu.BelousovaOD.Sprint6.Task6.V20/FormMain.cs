using Tyuiu.BelousovaOD.Sprint6.Task6.V20.Lib;
namespace Tyuiu.BelousovaOD.Sprint6.Task6.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            foreach (string line in File.ReadLines(openFilePath))
            {
                textBoxInput_BOD.AppendText(line + Environment.NewLine);
            }
            groupBoxInput_BOD.Text = groupBoxInput_BOD.Text + " " + openFileDialogTask.FileName;
            buttonDone_BOD.Enabled = true;
        }

        string openFilePath;
        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
