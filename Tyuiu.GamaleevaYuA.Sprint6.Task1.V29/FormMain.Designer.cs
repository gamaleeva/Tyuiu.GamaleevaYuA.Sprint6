namespace Tyuiu.GamaleevaYuA.Sprint6.Task1.V29
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
            buttonHelp_GYA = new Button();
            buttonDone_GYA = new Button();
            textBoxStopStep_GYA = new TextBox();
            textBoxStartStep_GYA = new TextBox();
            textBoxResult_GYA = new TextBox();
            groupBoxTask_GYA = new GroupBox();
            textBoxTask_GYA = new TextBox();
            groupBoxOutput_GYA = new GroupBox();
            textBoxFunc_GYA = new TextBox();
            groupBoxInput_GYA = new GroupBox();
            textBoxStart_GYA = new TextBox();
            textBoxStop_GYA = new TextBox();
            groupBoxTask_GYA.SuspendLayout();
            groupBoxOutput_GYA.SuspendLayout();
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
            buttonHelp_GYA.Click += buttonHelp_Click;
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
            buttonDone_GYA.Click += buttonDone_Click;
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
            // textBoxResult_GYA
            // 
            textBoxResult_GYA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_GYA.Location = new Point(16, 44);
            textBoxResult_GYA.Multiline = true;
            textBoxResult_GYA.Name = "textBoxResult_GYA";
            textBoxResult_GYA.ReadOnly = true;
            textBoxResult_GYA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_GYA.Size = new Size(255, 369);
            textBoxResult_GYA.TabIndex = 4;
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
            textBoxTask_GYA.Size = new Size(303, 275);
            textBoxTask_GYA.TabIndex = 0;
            textBoxTask_GYA.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести в виде таблицы";
            // 
            // groupBoxOutput_GYA
            // 
            groupBoxOutput_GYA.Controls.Add(textBoxFunc_GYA);
            groupBoxOutput_GYA.Controls.Add(textBoxResult_GYA);
            groupBoxOutput_GYA.Location = new Point(502, 12);
            groupBoxOutput_GYA.Name = "groupBoxOutput_GYA";
            groupBoxOutput_GYA.Size = new Size(286, 426);
            groupBoxOutput_GYA.TabIndex = 6;
            groupBoxOutput_GYA.TabStop = false;
            groupBoxOutput_GYA.Text = "Вывод данных";
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
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxInput_GYA);
            Controls.Add(groupBoxOutput_GYA);
            Controls.Add(groupBoxTask_GYA);
            Controls.Add(buttonDone_GYA);
            Controls.Add(buttonHelp_GYA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 29 | Гамалеева Ю.А.";
            groupBoxTask_GYA.ResumeLayout(false);
            groupBoxTask_GYA.PerformLayout();
            groupBoxOutput_GYA.ResumeLayout(false);
            groupBoxOutput_GYA.PerformLayout();
            groupBoxInput_GYA.ResumeLayout(false);
            groupBoxInput_GYA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHelp_GYA;
        private Button buttonDone_GYA;
        private TextBox textBoxStopStep_GYA;
        private TextBox textBoxStartStep_GYA;
        private TextBox textBoxResult_GYA;
        private GroupBox groupBoxTask_GYA;
        private GroupBox groupBoxOutput_GYA;
        private GroupBox groupBoxInput_GYA;
        private TextBox textBoxTask_GYA;
        private TextBox textBoxFunc_GYA;
        private TextBox textBoxStart_GYA;
        private TextBox textBoxStop_GYA;
    }



}
