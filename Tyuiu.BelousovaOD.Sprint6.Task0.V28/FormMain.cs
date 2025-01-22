using Tyuiu.BelousovaOD.Sprint6.Task0.V28.Lib;
namespace Tyuiu.BelousovaOD.Sprint6.Task0.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxRes_BOD.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxXX_BOD.Text)));
            }
            catch
            {
                MessageBox.Show("??????? ???????? ??????", "??????!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarXC_ReyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
