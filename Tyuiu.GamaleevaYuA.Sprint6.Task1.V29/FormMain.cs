using Tyuiu.GamaleevaYuA.Sprint6.Task1.V29.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint6.Task1.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_GYA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_GYA.Text);
                string strline;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_GYA.Text = "";
                textBoxResult_GYA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_GYA.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_GYA.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strline = String.Format("|{0,5:d}     | {1,  6:f2}   | ", startStep, valueArray[i]);
                    textBoxResult_GYA.AppendText(strline + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_GYA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студенит группы ИБКСб-25-1 Гамалеева Юлия Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

