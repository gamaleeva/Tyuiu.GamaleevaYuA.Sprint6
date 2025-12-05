using Tyuiu.GamaleevaYuA.Sprint6.Task3.V22.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint6.Task3.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = { { 17, 0, 19, -8, -1 }, { 9, 4, -5, 7, 15 }, { 11, 13, 4, -4, -14 }, { 11, 14, 5, -15, 16 }, { 2, -14, -2, 11, 11 } };

        private void buttonDone_Click(object sender, EventArgs e)
        {

            textBoxResult_GYA.Text = Convert.ToString(ds.Calculate(mtrx));

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студенит группы ИБКСб-25-1 Гамалеева Юлия Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int cols = mtrx.GetUpperBound(1) + 1;
            dataGridViewMatrix_GYA.ColumnCount = cols;
            dataGridViewMatrix_GYA.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix_GYA.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int  j = 0; j < cols; j++)
                {
                    dataGridViewMatrix_GYA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }

        }
    }
}
