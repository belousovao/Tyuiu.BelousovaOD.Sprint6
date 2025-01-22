using Tyuiu.BelousovaOD.Sprint6.Task0.V28.Lib;
namespace Tyuiu.BelousovaOD.Sprint6.Task0.V28
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
        private void InitializeComponent()
        {
            textBoxI_BOD = new TextBox();
            textBoxV_BOD = new TextBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBoxY_BOD = new TextBox();
            textBoxVV_BOD = new TextBox();
            textBoxX_BOD = new TextBox();
            textBoxResult_BOD = new TextBox();
            textBoxRes_BOD = new TextBox();
            textBoxXX_BOD = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBoxI_BOD
            // 
            textBoxI_BOD.BackColor = SystemColors.InactiveCaption;
            textBoxI_BOD.Location = new Point(577, 415);
            textBoxI_BOD.Name = "textBoxI_BOD";
            textBoxI_BOD.Size = new Size(168, 23);
            textBoxI_BOD.TabIndex = 11;
            textBoxI_BOD.Text = "Выполнить";
            // 
            // textBoxV_BOD
            // 
            textBoxV_BOD.Location = new Point(12, 249);
            textBoxV_BOD.Multiline = true;
            textBoxV_BOD.Name = "textBoxV_BOD";
            textBoxV_BOD.ReadOnly = true;
            textBoxV_BOD.Size = new Size(341, 141);
            textBoxV_BOD.TabIndex = 0;
            textBoxV_BOD.Text = "Ввод Данных";
            textBoxV_BOD.KeyPress += textBoxVarXC_ReyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(200, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(12, 51);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(341, 200);
            textBox1.TabIndex = 3;
            textBox1.Text = "Вычислить выражение по формуле";
            // 
            // textBoxY_BOD
            // 
            textBoxY_BOD.Cursor = Cursors.IBeam;
            textBoxY_BOD.ForeColor = SystemColors.MenuText;
            textBoxY_BOD.Location = new Point(12, 12);
            textBoxY_BOD.Multiline = true;
            textBoxY_BOD.Name = "textBoxY_BOD";
            textBoxY_BOD.ReadOnly = true;
            textBoxY_BOD.Size = new Size(100, 23);
            textBoxY_BOD.TabIndex = 4;
            textBoxY_BOD.Text = "Условие";
            // 
            // textBoxVV_BOD
            // 
            textBoxVV_BOD.Location = new Point(397, 249);
            textBoxVV_BOD.Multiline = true;
            textBoxVV_BOD.Name = "textBoxVV_BOD";
            textBoxVV_BOD.ReadOnly = true;
            textBoxVV_BOD.Size = new Size(341, 141);
            textBoxVV_BOD.TabIndex = 5;
            textBoxVV_BOD.Text = "Вывод Данных";
            // 
            // textBoxX_BOD
            // 
            textBoxX_BOD.Location = new Point(129, 303);
            textBoxX_BOD.Name = "textBoxX_BOD";
            textBoxX_BOD.ReadOnly = true;
            textBoxX_BOD.Size = new Size(100, 23);
            textBoxX_BOD.TabIndex = 6;
            textBoxX_BOD.Text = "Переменная Х:";
            textBoxX_BOD.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxResult_BOD
            // 
            textBoxResult_BOD.Location = new Point(528, 303);
            textBoxResult_BOD.Name = "textBoxResult_BOD";
            textBoxResult_BOD.ReadOnly = true;
            textBoxResult_BOD.Size = new Size(100, 23);
            textBoxResult_BOD.TabIndex = 7;
            textBoxResult_BOD.Text = "Результат:";
            textBoxResult_BOD.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxRes_BOD
            // 
            textBoxRes_BOD.Location = new Point(510, 356);
            textBoxRes_BOD.Name = "textBoxRes_BOD";
            textBoxRes_BOD.ReadOnly = true;
            textBoxRes_BOD.Size = new Size(137, 23);
            textBoxRes_BOD.TabIndex = 9;
            textBoxRes_BOD.Enter += button_Click;
            textBoxRes_BOD.KeyPress += textBoxVarXC_ReyPress;
            // 
            // textBoxXX_BOD
            // 
            textBoxXX_BOD.Location = new Point(129, 356);
            textBoxXX_BOD.Name = "textBoxXX_BOD";
            textBoxXX_BOD.Size = new Size(100, 23);
            textBoxXX_BOD.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(434, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.WaitOnLoad = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(textBoxI_BOD);
            Controls.Add(textBoxXX_BOD);
            Controls.Add(textBoxRes_BOD);
            Controls.Add(textBoxResult_BOD);
            Controls.Add(textBoxX_BOD);
            Controls.Add(textBoxVV_BOD);
            Controls.Add(textBoxY_BOD);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxV_BOD);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Спринт 6 | Таск 0 | Вариант 28 |Белоусова О.Д,";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        private TextBox textBoxV_BOD;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBoxY_BOD;
        private TextBox textBoxVV_BOD;
        private TextBox textBoxX_BOD;
        private TextBox textBoxResult_BOD;
        private TextBox textBoxRes_BOD;
        private TextBox textBoxXX_BOD;
        private TextBox textBoxI_BOD;
        private PictureBox pictureBox2;
    }
}
    
       
    

