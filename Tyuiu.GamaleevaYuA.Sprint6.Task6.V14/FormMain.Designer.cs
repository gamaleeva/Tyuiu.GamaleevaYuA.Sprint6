namespace Tyuiu.GamaleevaYuA.Sprint6.Task6.V14
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
            panelInput_GYA = new Panel();
            textBoxIn_GYA = new TextBox();
            textBoxInput_GYA = new TextBox();
            panelOutput_GYA = new Panel();
            textBoxOut_GYA = new TextBox();
            textBoxOutput_GYA = new TextBox();
            panelButtons_GYA = new Panel();
            buttonAbout_GYA = new Button();
            buttonDone_GYA = new Button();
            buttonOpenFile_GYA = new Button();
            groupBoxTask_GYA = new GroupBox();
            textBoxTask_GYA = new TextBox();
            splitter1 = new Splitter();
            openFileDialogTask_GYA = new OpenFileDialog();
            toolTipTask_GYA = new ToolTip(components);
            panelInput_GYA.SuspendLayout();
            panelOutput_GYA.SuspendLayout();
            panelButtons_GYA.SuspendLayout();
            groupBoxTask_GYA.SuspendLayout();
            SuspendLayout();
            // 
            // panelInput_GYA
            // 
            panelInput_GYA.Controls.Add(textBoxIn_GYA);
            panelInput_GYA.Controls.Add(textBoxInput_GYA);
            panelInput_GYA.Dock = DockStyle.Left;
            panelInput_GYA.Location = new Point(0, 180);
            panelInput_GYA.Name = "panelInput_GYA";
            panelInput_GYA.Padding = new Padding(5);
            panelInput_GYA.Size = new Size(408, 270);
            panelInput_GYA.TabIndex = 1;
            // 
            // textBoxIn_GYA
            // 
            textBoxIn_GYA.Dock = DockStyle.Fill;
            textBoxIn_GYA.Location = new Point(5, 21);
            textBoxIn_GYA.Multiline = true;
            textBoxIn_GYA.Name = "textBoxIn_GYA";
            textBoxIn_GYA.ScrollBars = ScrollBars.Vertical;
            textBoxIn_GYA.Size = new Size(398, 244);
            textBoxIn_GYA.TabIndex = 1;
            // 
            // textBoxInput_GYA
            // 
            textBoxInput_GYA.BorderStyle = BorderStyle.None;
            textBoxInput_GYA.Dock = DockStyle.Top;
            textBoxInput_GYA.Location = new Point(5, 5);
            textBoxInput_GYA.Name = "textBoxInput_GYA";
            textBoxInput_GYA.ReadOnly = true;
            textBoxInput_GYA.Size = new Size(398, 16);
            textBoxInput_GYA.TabIndex = 0;
            textBoxInput_GYA.Text = "Ввод:";
            // 
            // panelOutput_GYA
            // 
            panelOutput_GYA.Controls.Add(textBoxOut_GYA);
            panelOutput_GYA.Controls.Add(textBoxOutput_GYA);
            panelOutput_GYA.Dock = DockStyle.Right;
            panelOutput_GYA.Location = new Point(412, 180);
            panelOutput_GYA.Name = "panelOutput_GYA";
            panelOutput_GYA.Padding = new Padding(5);
            panelOutput_GYA.Size = new Size(523, 270);
            panelOutput_GYA.TabIndex = 2;
            // 
            // textBoxOut_GYA
            // 
            textBoxOut_GYA.Dock = DockStyle.Fill;
            textBoxOut_GYA.Location = new Point(5, 21);
            textBoxOut_GYA.Multiline = true;
            textBoxOut_GYA.Name = "textBoxOut_GYA";
            textBoxOut_GYA.ScrollBars = ScrollBars.Vertical;
            textBoxOut_GYA.Size = new Size(513, 244);
            textBoxOut_GYA.TabIndex = 2;
            // 
            // textBoxOutput_GYA
            // 
            textBoxOutput_GYA.BorderStyle = BorderStyle.None;
            textBoxOutput_GYA.Dock = DockStyle.Top;
            textBoxOutput_GYA.Location = new Point(5, 5);
            textBoxOutput_GYA.Name = "textBoxOutput_GYA";
            textBoxOutput_GYA.ReadOnly = true;
            textBoxOutput_GYA.Size = new Size(513, 16);
            textBoxOutput_GYA.TabIndex = 0;
            textBoxOutput_GYA.Text = "Вывод:";
            // 
            // panelButtons_GYA
            // 
            panelButtons_GYA.Controls.Add(buttonAbout_GYA);
            panelButtons_GYA.Controls.Add(buttonDone_GYA);
            panelButtons_GYA.Controls.Add(buttonOpenFile_GYA);
            panelButtons_GYA.Controls.Add(groupBoxTask_GYA);
            panelButtons_GYA.Dock = DockStyle.Top;
            panelButtons_GYA.Location = new Point(0, 0);
            panelButtons_GYA.Name = "panelButtons_GYA";
            panelButtons_GYA.Size = new Size(935, 180);
            panelButtons_GYA.TabIndex = 3;
            // 
            // buttonAbout_GYA
            // 
            buttonAbout_GYA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_GYA.Location = new Point(857, 3);
            buttonAbout_GYA.Name = "buttonAbout_GYA";
            buttonAbout_GYA.Size = new Size(75, 68);
            buttonAbout_GYA.TabIndex = 3;
            buttonAbout_GYA.Text = "button3";
            toolTipTask_GYA.SetToolTip(buttonAbout_GYA, "Сведения о программе");
            buttonAbout_GYA.UseVisualStyleBackColor = true;
            buttonAbout_GYA.Click += buttonAbout_GYA_Click;
            // 
            // buttonDone_GYA
            // 
            buttonDone_GYA.Location = new Point(84, 3);
            buttonDone_GYA.Name = "buttonDone_GYA";
            buttonDone_GYA.Size = new Size(75, 68);
            buttonDone_GYA.TabIndex = 2;
            buttonDone_GYA.Text = "button2";
            buttonDone_GYA.UseVisualStyleBackColor = true;
            buttonDone_GYA.Click += buttonDone_GYA_Click;
            // 
            // buttonOpenFile_GYA
            // 
            buttonOpenFile_GYA.Location = new Point(3, 3);
            buttonOpenFile_GYA.Name = "buttonOpenFile_GYA";
            buttonOpenFile_GYA.Size = new Size(75, 68);
            buttonOpenFile_GYA.TabIndex = 1;
            buttonOpenFile_GYA.Text = "button1";
            toolTipTask_GYA.SetToolTip(buttonOpenFile_GYA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_GYA.UseVisualStyleBackColor = true;
            buttonOpenFile_GYA.Click += buttonOpenFile_GYA_Click;
            // 
            // groupBoxTask_GYA
            // 
            groupBoxTask_GYA.Controls.Add(textBoxTask_GYA);
            groupBoxTask_GYA.Dock = DockStyle.Bottom;
            groupBoxTask_GYA.Location = new Point(0, 80);
            groupBoxTask_GYA.Name = "groupBoxTask_GYA";
            groupBoxTask_GYA.Size = new Size(935, 100);
            groupBoxTask_GYA.TabIndex = 0;
            groupBoxTask_GYA.TabStop = false;
            groupBoxTask_GYA.Text = "Условие";
            // 
            // textBoxTask_GYA
            // 
            textBoxTask_GYA.Dock = DockStyle.Fill;
            textBoxTask_GYA.Location = new Point(3, 19);
            textBoxTask_GYA.Multiline = true;
            textBoxTask_GYA.Name = "textBoxTask_GYA";
            textBoxTask_GYA.ReadOnly = true;
            textBoxTask_GYA.Size = new Size(929, 78);
            textBoxTask_GYA.TabIndex = 0;
            textBoxTask_GYA.Text = resources.GetString("textBoxTask_GYA.Text");
            // 
            // splitter1
            // 
            splitter1.Location = new Point(408, 180);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 270);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // openFileDialogTask_GYA
            // 
            openFileDialogTask_GYA.FileName = "openFileDialog1";
            // 
            // toolTipTask_GYA
            // 
            toolTipTask_GYA.ToolTipIcon = ToolTipIcon.Info;
            toolTipTask_GYA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 450);
            Controls.Add(splitter1);
            Controls.Add(panelOutput_GYA);
            Controls.Add(panelInput_GYA);
            Controls.Add(panelButtons_GYA);
            MinimumSize = new Size(951, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 14 | Гамалеева Ю.А.";
            panelInput_GYA.ResumeLayout(false);
            panelInput_GYA.PerformLayout();
            panelOutput_GYA.ResumeLayout(false);
            panelOutput_GYA.PerformLayout();
            panelButtons_GYA.ResumeLayout(false);
            groupBoxTask_GYA.ResumeLayout(false);
            groupBoxTask_GYA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelInput_GYA;
        private Panel panelOutput_GYA;
        private Panel panelButtons_GYA;
        private Splitter splitter1;
        private Button buttonOpenFile_GYA;
        private GroupBox groupBoxTask_GYA;
        private Button buttonAbout_GYA;
        private Button buttonDone_GYA;
        private TextBox textBoxTask_GYA;
        private TextBox textBoxInput_GYA;
        private TextBox textBoxIn_GYA;
        private TextBox textBoxOut_GYA;
        private TextBox textBoxOutput_GYA;
        private OpenFileDialog openFileDialogTask_GYA;
        private ToolTip toolTipTask_GYA;
    }
}
