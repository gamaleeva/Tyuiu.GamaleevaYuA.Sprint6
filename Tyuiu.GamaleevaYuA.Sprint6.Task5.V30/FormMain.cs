using System.IO;
using Tyuiu.GamaleevaYuA.Sprint6.Task5.V30.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint6.Task5.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataSErvice ds = new DataSErvice();
        string path = @"C:\Users\Юлия\source\repos\Tyuiu.GamaleevaYuA.Sprint6\Tyuiu.GamaleevaYuA.Sprint6.Task5.V30\bin\Debug\InPutDataFileTask5V30.txt";

        private void buttonDone_GYA_Click(object sender, EventArgs e)
        {
            dataGridViewNums_GYA.ColumnCount = 2;
            dataGridViewNums_GYA.Columns[0].Width = 20;
            dataGridViewNums_GYA.Columns[1].Width = 50;
            this.chartDiag_GYA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_GYA.ChartAreas[0].AxisY.Title = "Ось Y";
            chartDiag_GYA.Series[0].Points.Clear();
            double[] numMass = new double[ds.len];
            numMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewNums_GYA.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartDiag_GYA.Series[0].Points.AddXY(i, numMass[i]);

            }
        }

        private void buttonOpen_GYA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();

        }

        private void buttonHelp_GYA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИБКСб-25-1 Гамалеева Юлия Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
