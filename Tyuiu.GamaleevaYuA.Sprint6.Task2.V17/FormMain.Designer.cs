namespace Tyuiu.GamaleevaYuA.Sprint6.Task2.V17
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
            buttonHelp_GYA = new Button();
            buttonDone_GYA = new Button();
            textBoxStopStep_GYA = new TextBox();
            textBoxStartStep_GYA = new TextBox();
            groupBoxTask_GYA = new GroupBox();
            textBoxTask_GYA = new TextBox();
            groupBoxOutput_GYA = new GroupBox();
            chartFunction_GYA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_GYA = new DataGridView();
            ColumnX = new DataGridViewTextBoxColumn();
            ColumnFX = new DataGridViewTextBoxColumn();
            textBoxFunc_GYA = new TextBox();
            groupBoxInput_GYA = new GroupBox();
            textBoxStart_GYA = new TextBox();
            textBoxStop_GYA = new TextBox();
            groupBoxTask_GYA.SuspendLayout();
            groupBoxOutput_GYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_GYA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_GYA).BeginInit();
            groupBoxInput_GYA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHelp_GYA
            // 
            buttonHelp_GYA.BackColor = Color.LightSeaGreen;
            buttonHelp_GYA.Location = new Point(313, 362);
            buttonHelp_GYA.Name = "buttonHelp_GYA";
            buttonHelp_GYA.Size = new Size(75, 51);
            buttonHelp_GYA.TabIndex = 0;
            buttonHelp_GYA.Text = "Справка";
            buttonHelp_GYA.UseVisualStyleBackColor = false;
            buttonHelp_GYA.Click += buttonHelp_GYA_Click;
            // 
            // buttonDone_GYA
            // 
            buttonDone_GYA.BackColor = Color.ForestGreen;
            buttonDone_GYA.Location = new Point(394, 362);
            buttonDone_GYA.Name = "buttonDone_GYA";
            buttonDone_GYA.Size = new Size(102, 50);
            buttonDone_GYA.TabIndex = 1;
            buttonDone_GYA.Text = "Выполнить";
            buttonDone_GYA.UseVisualStyleBackColor = false;
            buttonDone_GYA.Click += buttonDone_GYA_Click;
            buttonDone_GYA.MouseDown += buttonDone_GYA_MouseDown;
            buttonDone_GYA.MouseEnter += buttonDone_GYA_MouseEnter;
            buttonDone_GYA.MouseLeave += buttonDone_GYA_MouseLeave;
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
            groupBoxTask_GYA.Location = new Point(12, 12);
            groupBoxTask_GYA.Name = "groupBoxTask_GYA";
            groupBoxTask_GYA.Size = new Size(484, 316);
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
            textBoxTask_GYA.Size = new Size(472, 294);
            textBoxTask_GYA.TabIndex = 0;
            textBoxTask_GYA.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести в DataGridView и построить график функции\r\n\r\n";
            // 
            // groupBoxOutput_GYA
            // 
            groupBoxOutput_GYA.Controls.Add(chartFunction_GYA);
            groupBoxOutput_GYA.Controls.Add(dataGridViewFunction_GYA);
            groupBoxOutput_GYA.Controls.Add(textBoxFunc_GYA);
            groupBoxOutput_GYA.Location = new Point(502, 12);
            groupBoxOutput_GYA.Name = "groupBoxOutput_GYA";
            groupBoxOutput_GYA.Size = new Size(531, 426);
            groupBoxOutput_GYA.TabIndex = 6;
            groupBoxOutput_GYA.TabStop = false;
            groupBoxOutput_GYA.Text = "Вывод данных";
            // 
            // chartFunction_GYA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_GYA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_GYA.Legends.Add(legend1);
            chartFunction_GYA.Location = new Point(190, 56);
            chartFunction_GYA.Name = "chartFunction_GYA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_GYA.Series.Add(series1);
            chartFunction_GYA.Size = new Size(312, 330);
            chartFunction_GYA.TabIndex = 8;
            // 
            // dataGridViewFunction_GYA
            // 
            dataGridViewFunction_GYA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_GYA.Columns.AddRange(new DataGridViewColumn[] { ColumnX, ColumnFX });
            dataGridViewFunction_GYA.Location = new Point(25, 56);
            dataGridViewFunction_GYA.Name = "dataGridViewFunction_GYA";
            dataGridViewFunction_GYA.RowHeadersVisible = false;
            dataGridViewFunction_GYA.Size = new Size(129, 330);
            dataGridViewFunction_GYA.TabIndex = 6;
            // 
            // ColumnX
            // 
            ColumnX.HeaderText = "X";
            ColumnX.Name = "ColumnX";
            ColumnX.Width = 50;
            // 
            // ColumnFX
            // 
            ColumnFX.HeaderText = "F(X)";
            ColumnFX.Name = "ColumnFX";
            ColumnFX.Width = 50;
            // 
            // textBoxFunc_GYA
            // 
            textBoxFunc_GYA.BorderStyle = BorderStyle.None;
            textBoxFunc_GYA.Location = new Point(16, 22);
            textBoxFunc_GYA.Name = "textBoxFunc_GYA";
            textBoxFunc_GYA.ReadOnly = true;
            textBoxFunc_GYA.Size = new Size(100, 16);
            textBoxFunc_GYA.TabIndex = 5;
            textBoxFunc_GYA.Text = "Результат";
            // 
            // groupBoxInput_GYA
            // 
            groupBoxInput_GYA.Controls.Add(textBoxStart_GYA);
            groupBoxInput_GYA.Controls.Add(textBoxStop_GYA);
            groupBoxInput_GYA.Controls.Add(textBoxStartStep_GYA);
            groupBoxInput_GYA.Controls.Add(textBoxStopStep_GYA);
            groupBoxInput_GYA.Location = new Point(12, 334);
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 450);
            Controls.Add(groupBoxInput_GYA);
            Controls.Add(groupBoxOutput_GYA);
            Controls.Add(groupBoxTask_GYA);
            Controls.Add(buttonDone_GYA);
            Controls.Add(buttonHelp_GYA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 17 | Гамалеева Ю.А.";
            groupBoxTask_GYA.ResumeLayout(false);
            groupBoxTask_GYA.PerformLayout();
            groupBoxOutput_GYA.ResumeLayout(false);
            groupBoxOutput_GYA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_GYA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_GYA).EndInit();
            groupBoxInput_GYA.ResumeLayout(false);
            groupBoxInput_GYA.PerformLayout();
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
        private TextBox textBoxFunc_GYA;
        private TextBox textBoxStart_GYA;
        private TextBox textBoxStop_GYA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GYA;
        private DataGridView dataGridViewFunction_GYA;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnFX;
    }
}
