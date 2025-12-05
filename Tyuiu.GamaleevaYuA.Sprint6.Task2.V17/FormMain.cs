using Tyuiu.GamaleevaYuA.Sprint6.Task2.V17.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint6.Task2.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonHelp_GYA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студенит группы ИБКСб-25-1 Гамалеева Юлия Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_GYA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_GYA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_GYA.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_GYA.Titles.Add("График функции cos(x) + 4x/2 - sin(x) * 3x");
                this.chartFunction_GYA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_GYA.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_GYA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_GYA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonDone_GYA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_GYA.BackColor = Color.Red;
        }

        private void buttonDone_GYA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_GYA.BackColor = Color.ForestGreen;
        }

        private void buttonDone_GYA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_GYA.BackColor = Color.Green;
        }
    }
}
