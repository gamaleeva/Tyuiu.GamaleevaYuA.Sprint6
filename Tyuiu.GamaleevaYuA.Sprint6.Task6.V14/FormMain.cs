using System.Runtime.CompilerServices;
using Tyuiu.GamaleevaYuA.Sprint6.Task6.V14.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint6.Task6.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_GYA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GYA.ShowDialog();
            openFilePath = openFileDialogTask_GYA.FileName;
            textBoxIn_GYA.Text = File.ReadAllText(openFilePath);
            textBoxInput_GYA.Text = textBoxInput_GYA.Text + " " + openFileDialogTask_GYA.FileName;
            buttonDone_GYA.Enabled = true;

        }

        private void buttonDone_GYA_Click(object sender, EventArgs e)
        {

            string str = "";
            textBoxOut_GYA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonAbout_GYA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
