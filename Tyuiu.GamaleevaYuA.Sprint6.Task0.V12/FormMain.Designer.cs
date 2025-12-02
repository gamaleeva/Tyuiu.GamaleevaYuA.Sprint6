
namespace Tyuiu.GamaleevaYuA.Sprint6.Task0.V12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_GYA = new GroupBox();
            textBoxTask_GYA = new TextBox();
            pictureBoxTask_GYA = new PictureBox();
            groupBoxVarX_GYA = new GroupBox();
            textBoxX_GYA = new TextBox();
            textBoxVarX_GYA = new TextBox();
            groupBoxResult_GYA = new GroupBox();
            textBoxOutput_GYA = new TextBox();
            textBoxResult_GYA = new TextBox();
            buttonDone_GYA = new Button();
            buttonName_GYA = new Button();
            groupBoxTask_GYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_GYA).BeginInit();
            groupBoxVarX_GYA.SuspendLayout();
            groupBoxResult_GYA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_GYA
            // 
            groupBoxTask_GYA.Controls.Add(textBoxTask_GYA);
            groupBoxTask_GYA.Controls.Add(pictureBoxTask_GYA);
            groupBoxTask_GYA.Location = new Point(12, 12);
            groupBoxTask_GYA.Name = "groupBoxTask_GYA";
            groupBoxTask_GYA.Size = new Size(540, 176);
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
            textBoxTask_GYA.Size = new Size(351, 148);
            textBoxTask_GYA.TabIndex = 0;
            textBoxTask_GYA.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxTask_GYA
            // 
            pictureBoxTask_GYA.ErrorImage = (Image)resources.GetObject("pictureBoxTask_GYA.ErrorImage");
            pictureBoxTask_GYA.Image = (Image)resources.GetObject("pictureBoxTask_GYA.Image");
            pictureBoxTask_GYA.InitialImage = (Image)resources.GetObject("pictureBoxTask_GYA.InitialImage");
            pictureBoxTask_GYA.Location = new Point(363, 51);
            pictureBoxTask_GYA.Name = "pictureBoxTask_GYA";
            pictureBoxTask_GYA.Size = new Size(155, 78);
            pictureBoxTask_GYA.TabIndex = 1;
            pictureBoxTask_GYA.TabStop = false;
            // 
            // groupBoxVarX_GYA
            // 
            groupBoxVarX_GYA.Controls.Add(textBoxX_GYA);
            groupBoxVarX_GYA.Controls.Add(textBoxVarX_GYA);
            groupBoxVarX_GYA.Location = new Point(12, 194);
            groupBoxVarX_GYA.Name = "groupBoxVarX_GYA";
            groupBoxVarX_GYA.Size = new Size(321, 177);
            groupBoxVarX_GYA.TabIndex = 2;
            groupBoxVarX_GYA.TabStop = false;
            groupBoxVarX_GYA.Text = "Ввод данных";
            // 
            // textBoxX_GYA
            // 
            textBoxX_GYA.BorderStyle = BorderStyle.None;
            textBoxX_GYA.Location = new Point(103, 50);
            textBoxX_GYA.Name = "textBoxX_GYA";
            textBoxX_GYA.ReadOnly = true;
            textBoxX_GYA.Size = new Size(100, 16);
            textBoxX_GYA.TabIndex = 4;
            textBoxX_GYA.Text = "Переменная X";
            // 
            // textBoxVarX_GYA
            // 
            textBoxVarX_GYA.Location = new Point(103, 79);
            textBoxVarX_GYA.Name = "textBoxVarX_GYA";
            textBoxVarX_GYA.Size = new Size(100, 23);
            textBoxVarX_GYA.TabIndex = 1;
            textBoxVarX_GYA.KeyPress += TextBoxVarX_KeyPress;
            // 
            // groupBoxResult_GYA
            // 
            groupBoxResult_GYA.Controls.Add(textBoxOutput_GYA);
            groupBoxResult_GYA.Controls.Add(textBoxResult_GYA);
            groupBoxResult_GYA.Controls.Add(buttonDone_GYA);
            groupBoxResult_GYA.Controls.Add(buttonName_GYA);
            groupBoxResult_GYA.Location = new Point(339, 194);
            groupBoxResult_GYA.Name = "groupBoxResult_GYA";
            groupBoxResult_GYA.Size = new Size(213, 177);
            groupBoxResult_GYA.TabIndex = 3;
            groupBoxResult_GYA.TabStop = false;
            groupBoxResult_GYA.Text = "Вывод данных";
            // 
            // textBoxOutput_GYA
            // 
            textBoxOutput_GYA.BorderStyle = BorderStyle.None;
            textBoxOutput_GYA.Location = new Point(53, 50);
            textBoxOutput_GYA.Name = "textBoxOutput_GYA";
            textBoxOutput_GYA.ReadOnly = true;
            textBoxOutput_GYA.Size = new Size(100, 16);
            textBoxOutput_GYA.TabIndex = 5;
            textBoxOutput_GYA.Text = "Результат";
            // 
            // textBoxResult_GYA
            // 
            textBoxResult_GYA.Location = new Point(53, 79);
            textBoxResult_GYA.Name = "textBoxResult_GYA";
            textBoxResult_GYA.ReadOnly = true;
            textBoxResult_GYA.Size = new Size(100, 23);
            textBoxResult_GYA.TabIndex = 2;
            // 
            // buttonDone_GYA
            // 
            buttonDone_GYA.BackColor = SystemColors.Control;
            buttonDone_GYA.Location = new Point(86, 131);
            buttonDone_GYA.Name = "buttonDone_GYA";
            buttonDone_GYA.Size = new Size(89, 27);
            buttonDone_GYA.TabIndex = 1;
            buttonDone_GYA.Text = "Выполнить";
            buttonDone_GYA.UseVisualStyleBackColor = false;
            buttonDone_GYA.Click += buttonDone_Click;
            // 
            // buttonName_GYA
            // 
            buttonName_GYA.FlatStyle = FlatStyle.Flat;
            buttonName_GYA.Location = new Point(36, 133);
            buttonName_GYA.Name = "buttonName_GYA";
            buttonName_GYA.Size = new Size(26, 25);
            buttonName_GYA.TabIndex = 0;
            buttonName_GYA.Text = "?";
            buttonName_GYA.UseVisualStyleBackColor = true;
            buttonName_GYA.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 383);
            Controls.Add(groupBoxResult_GYA);
            Controls.Add(groupBoxVarX_GYA);
            Controls.Add(groupBoxTask_GYA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 12 | Гамалеева Ю.А.";
            groupBoxTask_GYA.ResumeLayout(false);
            groupBoxTask_GYA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_GYA).EndInit();
            groupBoxVarX_GYA.ResumeLayout(false);
            groupBoxVarX_GYA.PerformLayout();
            groupBoxResult_GYA.ResumeLayout(false);
            groupBoxResult_GYA.PerformLayout();
            ResumeLayout(false);
        }


        #endregion
        private GroupBox groupBoxTask_GYA;
        private TextBox textBoxTask_GYA;
        private PictureBox pictureBoxTask_GYA;
        private GroupBox groupBoxVarX_GYA;
        private TextBox textBoxX_GYA;
        private TextBox textBoxVarX_GYA;
        private GroupBox groupBoxResult_GYA;
        private TextBox textBoxResult_GYA;
        private Button buttonDone_GYA;
        private Button buttonName_GYA;
        private TextBox textBoxOutput_GYA;
    }
}
