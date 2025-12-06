namespace Tyuiu.GamaleevaYuA.Sprint6.Task4.V10
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            buttonHelp_GYA = new Button();
            buttonDone_GYA = new Button();
            textBoxStopStep_GYA = new TextBox();
            textBoxStartStep_GYA = new TextBox();
            groupBoxTask_GYA = new GroupBox();
            textBoxTask_GYA = new TextBox();
            groupBoxOutput_GYA = new GroupBox();
            textBoxResult_GYA = new TextBox();
            chartFunction_GYA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxInput_GYA = new GroupBox();
            textBoxStart_GYA = new TextBox();
            textBoxStop_GYA = new TextBox();
            buttonSave_GYA = new Button();
            panelTop_GYA = new Panel();
            panelLeft_GYA = new Panel();
            splitContainer1 = new SplitContainer();
            splitterOfViewAndText_GYA = new Splitter();
            panelFill_GYA = new Panel();
            groupBoxTask_GYA.SuspendLayout();
            groupBoxOutput_GYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_GYA).BeginInit();
            groupBoxInput_GYA.SuspendLayout();
            panelTop_GYA.SuspendLayout();
            panelLeft_GYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            panelFill_GYA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHelp_GYA
            // 
            buttonHelp_GYA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_GYA.BackColor = Color.LightSeaGreen;
            buttonHelp_GYA.Location = new Point(824, 32);
            buttonHelp_GYA.Name = "buttonHelp_GYA";
            buttonHelp_GYA.Size = new Size(83, 51);
            buttonHelp_GYA.TabIndex = 0;
            buttonHelp_GYA.Text = "Справка";
            buttonHelp_GYA.UseVisualStyleBackColor = false;
            buttonHelp_GYA.Click += buttonHelp_GYA_Click;
            // 
            // buttonDone_GYA
            // 
            buttonDone_GYA.BackColor = Color.ForestGreen;
            buttonDone_GYA.Location = new Point(644, 32);
            buttonDone_GYA.Name = "buttonDone_GYA";
            buttonDone_GYA.Size = new Size(84, 51);
            buttonDone_GYA.TabIndex = 1;
            buttonDone_GYA.Text = "Выполнить";
            buttonDone_GYA.UseVisualStyleBackColor = false;
            buttonDone_GYA.Click += buttonDone_GYA_Click;
            // 
            // textBoxStopStep_GYA
            // 
            textBoxStopStep_GYA.Location = new Point(152, 56);
            textBoxStopStep_GYA.Name = "textBoxStopStep_GYA";
            textBoxStopStep_GYA.Size = new Size(100, 23);
            textBoxStopStep_GYA.TabIndex = 2;
            // 
            // textBoxStartStep_GYA
            // 
            textBoxStartStep_GYA.Location = new Point(25, 57);
            textBoxStartStep_GYA.Name = "textBoxStartStep_GYA";
            textBoxStartStep_GYA.Size = new Size(100, 23);
            textBoxStartStep_GYA.TabIndex = 3;
            // 
            // groupBoxTask_GYA
            // 
            groupBoxTask_GYA.Controls.Add(textBoxTask_GYA);
            groupBoxTask_GYA.Location = new Point(13, 3);
            groupBoxTask_GYA.Name = "groupBoxTask_GYA";
            groupBoxTask_GYA.Size = new Size(324, 104);
            groupBoxTask_GYA.TabIndex = 5;
            groupBoxTask_GYA.TabStop = false;
            groupBoxTask_GYA.Text = "Условие";
            // 
            // textBoxTask_GYA
            // 
            textBoxTask_GYA.BorderStyle = BorderStyle.None;
            textBoxTask_GYA.Location = new Point(6, 22);
            textBoxTask_GYA.Multiline = true;
            textBoxTask_GYA.Name = "textBoxTask_GYA";
            textBoxTask_GYA.ReadOnly = true;
            textBoxTask_GYA.Size = new Size(321, 62);
            textBoxTask_GYA.TabIndex = 0;
            textBoxTask_GYA.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5. Результат вывести в Text Box Построить график функции и сохранить в файл OutPutFileTask4V10.txt по нажатию кнопки\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // groupBoxOutput_GYA
            // 
            groupBoxOutput_GYA.Controls.Add(textBoxResult_GYA);
            groupBoxOutput_GYA.Dock = DockStyle.Fill;
            groupBoxOutput_GYA.Location = new Point(0, 0);
            groupBoxOutput_GYA.Name = "groupBoxOutput_GYA";
            groupBoxOutput_GYA.Padding = new Padding(5);
            groupBoxOutput_GYA.Size = new Size(308, 480);
            groupBoxOutput_GYA.TabIndex = 6;
            groupBoxOutput_GYA.TabStop = false;
            groupBoxOutput_GYA.Text = "Вывод данных";
            // 
            // textBoxResult_GYA
            // 
            textBoxResult_GYA.Dock = DockStyle.Fill;
            textBoxResult_GYA.Location = new Point(5, 21);
            textBoxResult_GYA.Multiline = true;
            textBoxResult_GYA.Name = "textBoxResult_GYA";
            textBoxResult_GYA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_GYA.Size = new Size(298, 454);
            textBoxResult_GYA.TabIndex = 9;
            // 
            // chartFunction_GYA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_GYA.ChartAreas.Add(chartArea1);
            chartFunction_GYA.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_GYA.Legends.Add(legend1);
            chartFunction_GYA.Location = new Point(0, 0);
            chartFunction_GYA.Name = "chartFunction_GYA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_GYA.Series.Add(series1);
            chartFunction_GYA.Size = new Size(607, 480);
            chartFunction_GYA.TabIndex = 8;
            title1.Name = "TitleFunc";
            title1.Text = "(5*cos(x)+2.5/(sin(x)+3) + 2x + cos(x)";
            chartFunction_GYA.Titles.Add(title1);
            // 
            // groupBoxInput_GYA
            // 
            groupBoxInput_GYA.Controls.Add(textBoxStart_GYA);
            groupBoxInput_GYA.Controls.Add(textBoxStop_GYA);
            groupBoxInput_GYA.Controls.Add(textBoxStartStep_GYA);
            groupBoxInput_GYA.Controls.Add(textBoxStopStep_GYA);
            groupBoxInput_GYA.Location = new Point(343, 3);
            groupBoxInput_GYA.Name = "groupBoxInput_GYA";
            groupBoxInput_GYA.Size = new Size(295, 104);
            groupBoxInput_GYA.TabIndex = 7;
            groupBoxInput_GYA.TabStop = false;
            groupBoxInput_GYA.Text = "Ввод данных";
            // 
            // textBoxStart_GYA
            // 
            textBoxStart_GYA.BorderStyle = BorderStyle.None;
            textBoxStart_GYA.Location = new Point(25, 28);
            textBoxStart_GYA.Name = "textBoxStart_GYA";
            textBoxStart_GYA.ReadOnly = true;
            textBoxStart_GYA.Size = new Size(100, 16);
            textBoxStart_GYA.TabIndex = 8;
            textBoxStart_GYA.Text = "Старт шага";
            // 
            // textBoxStop_GYA
            // 
            textBoxStop_GYA.BorderStyle = BorderStyle.None;
            textBoxStop_GYA.Location = new Point(152, 27);
            textBoxStop_GYA.Name = "textBoxStop_GYA";
            textBoxStop_GYA.ReadOnly = true;
            textBoxStop_GYA.Size = new Size(100, 16);
            textBoxStop_GYA.TabIndex = 1;
            textBoxStop_GYA.Text = "Конец шага";
            // 
            // buttonSave_GYA
            // 
            buttonSave_GYA.BackColor = Color.RoyalBlue;
            buttonSave_GYA.Location = new Point(734, 32);
            buttonSave_GYA.Name = "buttonSave_GYA";
            buttonSave_GYA.Size = new Size(84, 51);
            buttonSave_GYA.TabIndex = 8;
            buttonSave_GYA.Text = "Сохранить";
            buttonSave_GYA.UseVisualStyleBackColor = false;
            buttonSave_GYA.Click += buttonSave_GYA_Click;
            // 
            // panelTop_GYA
            // 
            panelTop_GYA.Controls.Add(buttonSave_GYA);
            panelTop_GYA.Controls.Add(buttonHelp_GYA);
            panelTop_GYA.Controls.Add(groupBoxTask_GYA);
            panelTop_GYA.Controls.Add(groupBoxInput_GYA);
            panelTop_GYA.Controls.Add(buttonDone_GYA);
            panelTop_GYA.Dock = DockStyle.Top;
            panelTop_GYA.Location = new Point(0, 0);
            panelTop_GYA.Name = "panelTop_GYA";
            panelTop_GYA.Size = new Size(918, 116);
            panelTop_GYA.TabIndex = 9;
            // 
            // panelLeft_GYA
            // 
            panelLeft_GYA.Controls.Add(groupBoxOutput_GYA);
            panelLeft_GYA.Dock = DockStyle.Left;
            panelLeft_GYA.Location = new Point(0, 116);
            panelLeft_GYA.Name = "panelLeft_GYA";
            panelLeft_GYA.Size = new Size(308, 480);
            panelLeft_GYA.TabIndex = 10;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(437, 599);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Size = new Size(150, 100);
            splitContainer1.TabIndex = 11;
            // 
            // splitterOfViewAndText_GYA
            // 
            splitterOfViewAndText_GYA.Location = new Point(308, 116);
            splitterOfViewAndText_GYA.Name = "splitterOfViewAndText_GYA";
            splitterOfViewAndText_GYA.Size = new Size(3, 480);
            splitterOfViewAndText_GYA.TabIndex = 12;
            splitterOfViewAndText_GYA.TabStop = false;
            // 
            // panelFill_GYA
            // 
            panelFill_GYA.Controls.Add(chartFunction_GYA);
            panelFill_GYA.Dock = DockStyle.Fill;
            panelFill_GYA.Location = new Point(311, 116);
            panelFill_GYA.Name = "panelFill_GYA";
            panelFill_GYA.Size = new Size(607, 480);
            panelFill_GYA.TabIndex = 13;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 596);
            Controls.Add(panelFill_GYA);
            Controls.Add(splitterOfViewAndText_GYA);
            Controls.Add(splitContainer1);
            Controls.Add(panelLeft_GYA);
            Controls.Add(panelTop_GYA);
            MinimumSize = new Size(934, 635);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 10 | Гамалеева Ю.А.";
            groupBoxTask_GYA.ResumeLayout(false);
            groupBoxTask_GYA.PerformLayout();
            groupBoxOutput_GYA.ResumeLayout(false);
            groupBoxOutput_GYA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_GYA).EndInit();
            groupBoxInput_GYA.ResumeLayout(false);
            groupBoxInput_GYA.PerformLayout();
            panelTop_GYA.ResumeLayout(false);
            panelLeft_GYA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelFill_GYA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHelp_GYA;
        private Button buttonDone_GYA;
        private TextBox textBoxStopStep_GYA;
        private TextBox textBoxStartStep_GYA;
        private GroupBox groupBoxTask_GYA;
        private GroupBox groupBoxOutput_GYA;
        private GroupBox groupBoxInput_GYA;
        private TextBox textBoxTask_GYA;
        private TextBox textBoxStart_GYA;
        private TextBox textBoxStop_GYA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GYA;
        private TextBox textBoxResult_GYA;
        private Button buttonSave_GYA;
        private Panel panelTop_GYA;
        private Panel panelLeft_GYA;
        private SplitContainer splitContainer1;
        private Splitter splitterOfViewAndText_GYA;
        private Panel panelFill_GYA;
    }
}
