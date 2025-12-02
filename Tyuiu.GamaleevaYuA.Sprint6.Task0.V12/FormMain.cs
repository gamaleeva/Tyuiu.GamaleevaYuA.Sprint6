using Tyuiu.GamaleevaYuA.Sprint6.Task0.V12.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint6.Task0.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_GYA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_GYA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void TextBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студенит группы ИБКСб-25-1 Гамалеева Юлия Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}