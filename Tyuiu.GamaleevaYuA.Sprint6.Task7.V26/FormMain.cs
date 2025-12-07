using System.IO;
using Tyuiu.GamaleevaYuA.Sprint6.Task7.V26.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint6.Task7.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_GYA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_GYA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int cols;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            cols = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);

                }
            }
            return arrayValues;
        }
        private void buttonOpenFile_GYA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GYA.ShowDialog();
            openFilePath = openFileDialogTask_GYA.FileName;
            int[,] arrayValues = new int[rows, cols];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_GYA.ColumnCount = cols;
            dataGridViewIn_GYA.RowCount = rows;
            dataGridViewOut_GYA.ColumnCount = cols;
            dataGridViewOut_GYA.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewIn_GYA.Columns[i].Width = 25;
                    dataGridViewOut_GYA.Columns[i].Width = 25;
                }
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewIn_GYA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonDone_GYA.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_GYA.ColumnCount = 50;
            dataGridViewOut_GYA.ColumnCount = 50;
            dataGridViewIn_GYA.RowCount = 50;
            dataGridViewOut_GYA.RowCount = 50;
        }

        private void buttonDone_GYA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, cols];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewOut_GYA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_GYA.Enabled = true;
        }

        private void buttonSave_GYA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_GYA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_GYA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_GYA.ShowDialog();

            string path = saveFileDialogMatrix_GYA.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_GYA.RowCount;
            int cols = dataGridViewOut_GYA.ColumnCount;
            string str = "";
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (c != cols - 1)
                    {
                        str = str + dataGridViewOut_GYA.Rows[r].Cells[c].Value + ";";

                    }
                    else
                    {
                        str = str + dataGridViewOut_GYA.Rows[r].Cells[c].Value;

                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_GYA_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_GYA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_GYA_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_GYA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_GYA_MouseEnter(object sender, MouseEventArgs e)
        {
            toolTipTask_GYA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonAbout_GYA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();

        }
        private void buttonAbout_GYA_MouseEnter(Object sender, EventArgs e)
        {
            toolTipTask_GYA.ToolTipTitle = "Справка";

        }
    }
}
