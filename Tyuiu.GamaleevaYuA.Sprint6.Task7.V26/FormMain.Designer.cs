namespace Tyuiu.GamaleevaYuA.Sprint6.Task7.V26
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_GYA = new Panel();
            buttonSave_GYA = new Button();
            buttonAbout_GYA = new Button();
            buttonDone_GYA = new Button();
            buttonOpenFile_GYA = new Button();
            groupBoxTask_GYA = new GroupBox();
            textBoxTask_GYA = new TextBox();
            openFileDialogTask_GYA = new OpenFileDialog();
            toolTipTask_GYA = new ToolTip(components);
            panel1 = new Panel();
            panelInput_GYA = new Panel();
            groupBoxIn_GYA = new GroupBox();
            dataGridViewIn_GYA = new DataGridView();
            panelOutput_GYA = new Panel();
            groupBoxOut_GYA = new GroupBox();
            dataGridViewOut_GYA = new DataGridView();
            splitter2 = new Splitter();
            saveFileDialogMatrix_GYA = new SaveFileDialog();
            panelButtons_GYA.SuspendLayout();
            groupBoxTask_GYA.SuspendLayout();
            panel1.SuspendLayout();
            panelInput_GYA.SuspendLayout();
            groupBoxIn_GYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_GYA).BeginInit();
            panelOutput_GYA.SuspendLayout();
            groupBoxOut_GYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_GYA).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_GYA
            // 
            panelButtons_GYA.Controls.Add(buttonSave_GYA);
            panelButtons_GYA.Controls.Add(buttonAbout_GYA);
            panelButtons_GYA.Controls.Add(buttonDone_GYA);
            panelButtons_GYA.Controls.Add(buttonOpenFile_GYA);
            panelButtons_GYA.Dock = DockStyle.Top;
            panelButtons_GYA.Location = new Point(0, 0);
            panelButtons_GYA.Name = "panelButtons_GYA";
            panelButtons_GYA.Size = new Size(935, 75);
            panelButtons_GYA.TabIndex = 3;
            // 
            // buttonSave_GYA
            // 
            buttonSave_GYA.BackColor = SystemColors.ButtonFace;
            buttonSave_GYA.Enabled = false;
            buttonSave_GYA.Image = (Image)resources.GetObject("buttonSave_GYA.Image");
            buttonSave_GYA.Location = new Point(165, 3);
            buttonSave_GYA.Name = "buttonSave_GYA";
            buttonSave_GYA.Size = new Size(75, 68);
            buttonSave_GYA.TabIndex = 4;
            toolTipTask_GYA.SetToolTip(buttonSave_GYA, "Сохранить файл\r\nВыберите место для сохранения файла\r\n\r\n");
            buttonSave_GYA.UseVisualStyleBackColor = false;
            buttonSave_GYA.Click += buttonSave_GYA_Click;
            buttonSave_GYA.MouseEnter += buttonDone_GYA_MouseEnter;
            // 
            // buttonAbout_GYA
            // 
            buttonAbout_GYA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_GYA.BackColor = SystemColors.ButtonFace;
            buttonAbout_GYA.Image = (Image)resources.GetObject("buttonAbout_GYA.Image");
            buttonAbout_GYA.Location = new Point(857, 3);
            buttonAbout_GYA.Name = "buttonAbout_GYA";
            buttonAbout_GYA.Size = new Size(75, 68);
            buttonAbout_GYA.TabIndex = 3;
            toolTipTask_GYA.SetToolTip(buttonAbout_GYA, "Сведения о программе");
            buttonAbout_GYA.UseVisualStyleBackColor = false;
            buttonAbout_GYA.Click += buttonAbout_GYA_Click;
            // 
            // buttonDone_GYA
            // 
            buttonDone_GYA.BackColor = SystemColors.ButtonFace;
            buttonDone_GYA.Enabled = false;
            buttonDone_GYA.Image = (Image)resources.GetObject("buttonDone_GYA.Image");
            buttonDone_GYA.Location = new Point(84, 3);
            buttonDone_GYA.Name = "buttonDone_GYA";
            buttonDone_GYA.Size = new Size(75, 68);
            buttonDone_GYA.TabIndex = 2;
            toolTipTask_GYA.SetToolTip(buttonDone_GYA, "Выполнить\r\n");
            buttonDone_GYA.UseVisualStyleBackColor = false;
            buttonDone_GYA.Click += buttonDone_GYA_Click;
            buttonDone_GYA.MouseEnter += buttonDone_GYA_MouseEnter;
            // 
            // buttonOpenFile_GYA
            // 
            buttonOpenFile_GYA.BackColor = SystemColors.ButtonFace;
            buttonOpenFile_GYA.Image = (Image)resources.GetObject("buttonOpenFile_GYA.Image");
            buttonOpenFile_GYA.Location = new Point(3, 3);
            buttonOpenFile_GYA.Name = "buttonOpenFile_GYA";
            buttonOpenFile_GYA.Size = new Size(75, 68);
            buttonOpenFile_GYA.TabIndex = 1;
            toolTipTask_GYA.SetToolTip(buttonOpenFile_GYA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_GYA.UseVisualStyleBackColor = false;
            buttonOpenFile_GYA.Click += buttonOpenFile_GYA_Click;
            buttonOpenFile_GYA.MouseEnter += buttonOpenFile_GYA_MouseEnter;
            // 
            // groupBoxTask_GYA
            // 
            groupBoxTask_GYA.Controls.Add(textBoxTask_GYA);
            groupBoxTask_GYA.Dock = DockStyle.Fill;
            groupBoxTask_GYA.Location = new Point(0, 0);
            groupBoxTask_GYA.Name = "groupBoxTask_GYA";
            groupBoxTask_GYA.Size = new Size(935, 87);
            groupBoxTask_GYA.TabIndex = 0;
            groupBoxTask_GYA.TabStop = false;
            groupBoxTask_GYA.Text = "Условие";
            // 
            // textBoxTask_GYA
            // 
            textBoxTask_GYA.BorderStyle = BorderStyle.None;
            textBoxTask_GYA.Dock = DockStyle.Fill;
            textBoxTask_GYA.Location = new Point(3, 19);
            textBoxTask_GYA.Multiline = true;
            textBoxTask_GYA.Name = "textBoxTask_GYA";
            textBoxTask_GYA.ReadOnly = true;
            textBoxTask_GYA.Size = new Size(929, 65);
            textBoxTask_GYA.TabIndex = 0;
            textBoxTask_GYA.Text = resources.GetString("textBoxTask_GYA.Text");
            // 
            // openFileDialogTask_GYA
            // 
            openFileDialogTask_GYA.FileName = "openFileDialog1";
            // 
            // toolTipTask_GYA
            // 
            toolTipTask_GYA.IsBalloon = true;
            toolTipTask_GYA.ToolTipIcon = ToolTipIcon.Info;
            toolTipTask_GYA.ToolTipTitle = "Подсказка";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxTask_GYA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 87);
            panel1.TabIndex = 5;
            // 
            // panelInput_GYA
            // 
            panelInput_GYA.Controls.Add(groupBoxIn_GYA);
            panelInput_GYA.Dock = DockStyle.Left;
            panelInput_GYA.Location = new Point(0, 162);
            panelInput_GYA.Name = "panelInput_GYA";
            panelInput_GYA.Padding = new Padding(5);
            panelInput_GYA.Size = new Size(366, 288);
            panelInput_GYA.TabIndex = 6;
            // 
            // groupBoxIn_GYA
            // 
            groupBoxIn_GYA.Controls.Add(dataGridViewIn_GYA);
            groupBoxIn_GYA.Dock = DockStyle.Fill;
            groupBoxIn_GYA.Location = new Point(5, 5);
            groupBoxIn_GYA.Name = "groupBoxIn_GYA";
            groupBoxIn_GYA.Padding = new Padding(5);
            groupBoxIn_GYA.Size = new Size(356, 278);
            groupBoxIn_GYA.TabIndex = 0;
            groupBoxIn_GYA.TabStop = false;
            groupBoxIn_GYA.Text = "Ввод:";
            // 
            // dataGridViewIn_GYA
            // 
            dataGridViewIn_GYA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_GYA.ColumnHeadersVisible = false;
            dataGridViewIn_GYA.Dock = DockStyle.Fill;
            dataGridViewIn_GYA.Location = new Point(5, 21);
            dataGridViewIn_GYA.Name = "dataGridViewIn_GYA";
            dataGridViewIn_GYA.RowHeadersVisible = false;
            dataGridViewIn_GYA.Size = new Size(346, 252);
            dataGridViewIn_GYA.TabIndex = 0;
            // 
            // panelOutput_GYA
            // 
            panelOutput_GYA.Controls.Add(groupBoxOut_GYA);
            panelOutput_GYA.Dock = DockStyle.Right;
            panelOutput_GYA.Location = new Point(372, 162);
            panelOutput_GYA.Name = "panelOutput_GYA";
            panelOutput_GYA.Padding = new Padding(5);
            panelOutput_GYA.Size = new Size(563, 288);
            panelOutput_GYA.TabIndex = 7;
            // 
            // groupBoxOut_GYA
            // 
            groupBoxOut_GYA.Controls.Add(dataGridViewOut_GYA);
            groupBoxOut_GYA.Dock = DockStyle.Fill;
            groupBoxOut_GYA.Location = new Point(5, 5);
            groupBoxOut_GYA.Name = "groupBoxOut_GYA";
            groupBoxOut_GYA.Padding = new Padding(5);
            groupBoxOut_GYA.Size = new Size(553, 278);
            groupBoxOut_GYA.TabIndex = 1;
            groupBoxOut_GYA.TabStop = false;
            groupBoxOut_GYA.Text = "Вывод";
            // 
            // dataGridViewOut_GYA
            // 
            dataGridViewOut_GYA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_GYA.ColumnHeadersVisible = false;
            dataGridViewOut_GYA.Dock = DockStyle.Fill;
            dataGridViewOut_GYA.Location = new Point(5, 21);
            dataGridViewOut_GYA.Name = "dataGridViewOut_GYA";
            dataGridViewOut_GYA.RowHeadersVisible = false;
            dataGridViewOut_GYA.Size = new Size(543, 252);
            dataGridViewOut_GYA.TabIndex = 1;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(366, 162);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(3, 288);
            splitter2.TabIndex = 9;
            splitter2.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 450);
            Controls.Add(splitter2);
            Controls.Add(panelOutput_GYA);
            Controls.Add(panelInput_GYA);
            Controls.Add(panel1);
            Controls.Add(panelButtons_GYA);
            MinimumSize = new Size(951, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 26 | Гамалеева Ю.А.";
            Load += FormMain_Load;
            panelButtons_GYA.ResumeLayout(false);
            groupBoxTask_GYA.ResumeLayout(false);
            groupBoxTask_GYA.PerformLayout();
            panel1.ResumeLayout(false);
            panelInput_GYA.ResumeLayout(false);
            groupBoxIn_GYA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_GYA).EndInit();
            panelOutput_GYA.ResumeLayout(false);
            groupBoxOut_GYA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_GYA).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelButtons_GYA;
        private Button buttonOpenFile_GYA;
        private GroupBox groupBoxTask_GYA;
        private Button buttonAbout_GYA;
        private Button buttonDone_GYA;
        private TextBox textBoxTask_GYA;
        private OpenFileDialog openFileDialogTask_GYA;
        private ToolTip toolTipTask_GYA;
        private Button buttonSave_GYA;
        private Panel panel1;
        private Panel panelInput_GYA;
        private GroupBox groupBoxIn_GYA;
        private DataGridView dataGridViewIn_GYA;
        private Panel panelOutput_GYA;
        private GroupBox groupBoxOut_GYA;
        private DataGridView dataGridViewOut_GYA;
        private Splitter splitter2;
        private SaveFileDialog saveFileDialogMatrix_GYA;
    }
}
