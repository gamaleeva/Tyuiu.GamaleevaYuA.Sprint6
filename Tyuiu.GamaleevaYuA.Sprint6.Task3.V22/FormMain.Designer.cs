namespace Tyuiu.GamaleevaYuA.Sprint6.Task3.V22
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
            groupBoxTask_GYA = new GroupBox();
            textBoxTask_GYA = new TextBox();
            groupBoxResult_GYA = new GroupBox();
            textBoxOutput_GYA = new TextBox();
            textBoxResult_GYA = new TextBox();
            buttonName_GYA = new Button();
            buttonDone_GYA = new Button();
            dataGridViewMatrix_GYA = new DataGridView();
            groupBoxTask_GYA.SuspendLayout();
            groupBoxResult_GYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_GYA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_GYA
            // 
            groupBoxTask_GYA.Controls.Add(textBoxTask_GYA);
            groupBoxTask_GYA.Location = new Point(12, 12);
            groupBoxTask_GYA.Name = "groupBoxTask_GYA";
            groupBoxTask_GYA.Size = new Size(239, 361);
            groupBoxTask_GYA.TabIndex = 0;
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
            textBoxTask_GYA.Size = new Size(227, 266);
            textBoxTask_GYA.TabIndex = 0;
            textBoxTask_GYA.Text = "Дана матрица 5 на 5\r\n17 0 19 - 8 -1\r\n9 4 -5 7 15\r\n11 13 4 -4 -14\r\n11 14 5 -15 16\r\n2 -14 -2 11 11\r\nЗаменить четные значения в первой строке на 0";
            // 
            // groupBoxResult_GYA
            // 
            groupBoxResult_GYA.Controls.Add(textBoxOutput_GYA);
            groupBoxResult_GYA.Controls.Add(textBoxResult_GYA);
            groupBoxResult_GYA.Controls.Add(buttonName_GYA);
            groupBoxResult_GYA.Controls.Add(buttonDone_GYA);
            groupBoxResult_GYA.Location = new Point(487, 5);
            groupBoxResult_GYA.Name = "groupBoxResult_GYA";
            groupBoxResult_GYA.Size = new Size(133, 376);
            groupBoxResult_GYA.TabIndex = 3;
            groupBoxResult_GYA.TabStop = false;
            groupBoxResult_GYA.Text = "Вывод данных";
            // 
            // textBoxOutput_GYA
            // 
            textBoxOutput_GYA.BorderStyle = BorderStyle.None;
            textBoxOutput_GYA.Location = new Point(6, 29);
            textBoxOutput_GYA.Name = "textBoxOutput_GYA";
            textBoxOutput_GYA.ReadOnly = true;
            textBoxOutput_GYA.Size = new Size(100, 16);
            textBoxOutput_GYA.TabIndex = 5;
            textBoxOutput_GYA.Text = "Результат";
            // 
            // textBoxResult_GYA
            // 
            textBoxResult_GYA.Location = new Point(6, 51);
            textBoxResult_GYA.Multiline = true;
            textBoxResult_GYA.Name = "textBoxResult_GYA";
            textBoxResult_GYA.ReadOnly = true;
            textBoxResult_GYA.Size = new Size(100, 23);
            textBoxResult_GYA.TabIndex = 2;
            // 
            // buttonName_GYA
            // 
            buttonName_GYA.FlatStyle = FlatStyle.Flat;
            buttonName_GYA.Location = new Point(6, 341);
            buttonName_GYA.Name = "buttonName_GYA";
            buttonName_GYA.Size = new Size(26, 25);
            buttonName_GYA.TabIndex = 0;
            buttonName_GYA.Text = "?";
            buttonName_GYA.UseVisualStyleBackColor = true;
            buttonName_GYA.Click += buttonHelp_Click;
            // 
            // buttonDone_GYA
            // 
            buttonDone_GYA.BackColor = SystemColors.Control;
            buttonDone_GYA.Location = new Point(38, 341);
            buttonDone_GYA.Name = "buttonDone_GYA";
            buttonDone_GYA.Size = new Size(89, 27);
            buttonDone_GYA.TabIndex = 1;
            buttonDone_GYA.Text = "Выполнить";
            buttonDone_GYA.UseVisualStyleBackColor = false;
            buttonDone_GYA.Click += buttonDone_Click;
            // 
            // dataGridViewMatrix_GYA
            // 
            dataGridViewMatrix_GYA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_GYA.ColumnHeadersVisible = false;
            dataGridViewMatrix_GYA.Location = new Point(251, 21);
            dataGridViewMatrix_GYA.Name = "dataGridViewMatrix_GYA";
            dataGridViewMatrix_GYA.RowHeadersVisible = false;
            dataGridViewMatrix_GYA.Size = new Size(236, 215);
            dataGridViewMatrix_GYA.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 383);
            Controls.Add(dataGridViewMatrix_GYA);
            Controls.Add(groupBoxResult_GYA);
            Controls.Add(groupBoxTask_GYA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 22 | Гамалеева Ю.А.";
            Load += FormMain_Load;
            groupBoxTask_GYA.ResumeLayout(false);
            groupBoxTask_GYA.PerformLayout();
            groupBoxResult_GYA.ResumeLayout(false);
            groupBoxResult_GYA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_GYA).EndInit();
            ResumeLayout(false);
        }


        #endregion
        private GroupBox groupBoxTask_GYA;
        private TextBox textBoxTask_GYA;
        private GroupBox groupBoxResult_GYA;
        private TextBox textBoxResult_GYA;
        private Button buttonDone_GYA;
        private Button buttonName_GYA;
        private TextBox textBoxOutput_GYA;
        private DataGridView dataGridViewMatrix_GYA;
    }
}
