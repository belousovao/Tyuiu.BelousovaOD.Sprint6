using Tyuiu.BelousovaOD.Sprint6.Task6.V20.Lib;
namespace Tyuiu.BelousovaOD.Sprint6.Task6.V20
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
            components = new System.ComponentModel.Container();
            panelTop_BOD = new Panel();
            buttonDone_BOD = new Button();
            buttonOpenFile_BOD = new Button();
            buttonHelp_BOD = new Button();
            groupBoxTask_BOD = new GroupBox();
            textBoxTask_BOD = new TextBox();
            groupBoxInput_BOD = new GroupBox();
            textBoxInput_BOD = new TextBox();
            groupBoxOutput_BOD = new GroupBox();
            textBoxOutput_BOD = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTipTask = new ToolTip(components);
            panelPredTop_BOD = new Panel();
            splitContainer_BOD = new SplitContainer();
            panelTop_BOD.SuspendLayout();
            groupBoxTask_BOD.SuspendLayout();
            groupBoxInput_BOD.SuspendLayout();
            groupBoxOutput_BOD.SuspendLayout();
            panelPredTop_BOD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_BOD).BeginInit();
            splitContainer_BOD.Panel1.SuspendLayout();
            splitContainer_BOD.Panel2.SuspendLayout();
            splitContainer_BOD.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_BOD
            // 
            panelTop_BOD.BackColor = Color.White;
            panelTop_BOD.Controls.Add(buttonDone_BOD);
            panelTop_BOD.Controls.Add(buttonOpenFile_BOD);
            panelTop_BOD.Controls.Add(buttonHelp_BOD);
            panelTop_BOD.Dock = DockStyle.Top;
            panelTop_BOD.Location = new Point(0, 0);
            panelTop_BOD.Margin = new Padding(3, 4, 3, 4);
            panelTop_BOD.Name = "panelTop_BOD";
            panelTop_BOD.Size = new Size(925, 117);
            panelTop_BOD.TabIndex = 3;
            // 
            // buttonDone_BOD
            // 
            buttonDone_BOD.BackColor = Color.White;
            buttonDone_BOD.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone_BOD.Cursor = Cursors.Hand;
            buttonDone_BOD.Enabled = false;
            buttonDone_BOD.Location = new Point(102, 16);
            buttonDone_BOD.Margin = new Padding(3, 4, 3, 4);
            buttonDone_BOD.Name = "buttonDone_BOD";
            buttonDone_BOD.Size = new Size(75, 87);
            buttonDone_BOD.TabIndex = 4;
            toolTipTask.SetToolTip(buttonDone_BOD, "Произвести обработку файла");
            buttonDone_BOD.UseVisualStyleBackColor = false;
            // 
            // buttonOpenFile_BOD
            // 
            buttonOpenFile_BOD.BackColor = Color.White;
            buttonOpenFile_BOD.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOpenFile_BOD.Cursor = Cursors.Hand;
            buttonOpenFile_BOD.Location = new Point(19, 16);
            buttonOpenFile_BOD.Margin = new Padding(3, 4, 3, 4);
            buttonOpenFile_BOD.Name = "buttonOpenFile_BOD";
            buttonOpenFile_BOD.Size = new Size(75, 87);
            buttonOpenFile_BOD.TabIndex = 5;
            buttonOpenFile_BOD.Text = "\r\n";
            toolTipTask.SetToolTip(buttonOpenFile_BOD, "Открыть файл\r\nВыберите нужный файл для обработки.\r\n");
            buttonOpenFile_BOD.UseVisualStyleBackColor = false;
            // 
            // buttonHelp_BOD
            // 
            buttonHelp_BOD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BOD.BackColor = Color.White;
            buttonHelp_BOD.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHelp_BOD.Cursor = Cursors.Hand;
            buttonHelp_BOD.Location = new Point(833, 16);
            buttonHelp_BOD.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_BOD.Name = "buttonHelp_BOD";
            buttonHelp_BOD.Size = new Size(78, 87);
            buttonHelp_BOD.TabIndex = 6;
            buttonHelp_BOD.UseVisualStyleBackColor = false;
            // 
            // groupBoxTask_BOD
            // 
            groupBoxTask_BOD.Controls.Add(textBoxTask_BOD);
            groupBoxTask_BOD.Dock = DockStyle.Fill;
            groupBoxTask_BOD.Location = new Point(0, 0);
            groupBoxTask_BOD.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask_BOD.Name = "groupBoxTask_BOD";
            groupBoxTask_BOD.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask_BOD.Size = new Size(925, 133);
            groupBoxTask_BOD.TabIndex = 3;
            groupBoxTask_BOD.TabStop = false;
            groupBoxTask_BOD.Text = "Условие:";
            // 
            // textBoxTask_BOD
            // 
            textBoxTask_BOD.Dock = DockStyle.Fill;
            textBoxTask_BOD.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_BOD.Location = new Point(3, 24);
            textBoxTask_BOD.Margin = new Padding(3, 4, 3, 4);
            textBoxTask_BOD.Multiline = true;
            textBoxTask_BOD.Name = "textBoxTask_BOD";
            textBoxTask_BOD.ReadOnly = true;
            textBoxTask_BOD.Size = new Size(919, 105);
            textBoxTask_BOD.TabIndex = 0;
            textBoxTask_BOD.TabStop = false;
            // 
            // groupBoxInput_BOD
            // 
            groupBoxInput_BOD.Controls.Add(textBoxInput_BOD);
            groupBoxInput_BOD.Dock = DockStyle.Fill;
            groupBoxInput_BOD.Location = new Point(0, 0);
            groupBoxInput_BOD.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput_BOD.Name = "groupBoxInput_BOD";
            groupBoxInput_BOD.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput_BOD.Size = new Size(307, 495);
            groupBoxInput_BOD.TabIndex = 0;
            groupBoxInput_BOD.TabStop = false;
            groupBoxInput_BOD.Text = "Ввод:";
            // 
            // textBoxInput_BOD
            // 
            textBoxInput_BOD.Dock = DockStyle.Fill;
            textBoxInput_BOD.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxInput_BOD.Location = new Point(3, 24);
            textBoxInput_BOD.Margin = new Padding(3, 4, 3, 4);
            textBoxInput_BOD.Multiline = true;
            textBoxInput_BOD.Name = "textBoxInput_BOD";
            textBoxInput_BOD.ReadOnly = true;
            textBoxInput_BOD.Size = new Size(301, 467);
            textBoxInput_BOD.TabIndex = 0;
            // 
            // groupBoxOutput_BOD
            // 
            groupBoxOutput_BOD.Controls.Add(textBoxOutput_BOD);
            groupBoxOutput_BOD.Dock = DockStyle.Fill;
            groupBoxOutput_BOD.Location = new Point(0, 0);
            groupBoxOutput_BOD.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput_BOD.Name = "groupBoxOutput_BOD";
            groupBoxOutput_BOD.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutput_BOD.Size = new Size(613, 495);
            groupBoxOutput_BOD.TabIndex = 0;
            groupBoxOutput_BOD.TabStop = false;
            groupBoxOutput_BOD.Text = "Вывод:";
            // 
            // textBoxOutput_BOD
            // 
            textBoxOutput_BOD.Dock = DockStyle.Fill;
            textBoxOutput_BOD.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxOutput_BOD.Location = new Point(3, 24);
            textBoxOutput_BOD.Margin = new Padding(3, 4, 3, 4);
            textBoxOutput_BOD.Multiline = true;
            textBoxOutput_BOD.Name = "textBoxOutput_BOD";
            textBoxOutput_BOD.ReadOnly = true;
            textBoxOutput_BOD.Size = new Size(607, 467);
            textBoxOutput_BOD.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTipTask
            // 
            toolTipTask.ToolTipIcon = ToolTipIcon.Info;
            toolTipTask.ToolTipTitle = "Подсказка";
            // 
            // panelPredTop_BOD
            // 
            panelPredTop_BOD.Controls.Add(groupBoxTask_BOD);
            panelPredTop_BOD.Dock = DockStyle.Top;
            panelPredTop_BOD.Location = new Point(0, 117);
            panelPredTop_BOD.Margin = new Padding(3, 4, 3, 4);
            panelPredTop_BOD.Name = "panelPredTop_BOD";
            panelPredTop_BOD.Size = new Size(925, 133);
            panelPredTop_BOD.TabIndex = 4;
            // 
            // splitContainer_BOD
            // 
            splitContainer_BOD.Dock = DockStyle.Fill;
            splitContainer_BOD.Location = new Point(0, 250);
            splitContainer_BOD.Margin = new Padding(3, 4, 3, 4);
            splitContainer_BOD.Name = "splitContainer_BOD";
            // 
            // splitContainer_BOD.Panel1
            // 
            splitContainer_BOD.Panel1.Controls.Add(groupBoxInput_BOD);
            // 
            // splitContainer_BOD.Panel2
            // 
            splitContainer_BOD.Panel2.Controls.Add(groupBoxOutput_BOD);
            splitContainer_BOD.Size = new Size(925, 495);
            splitContainer_BOD.SplitterDistance = 307;
            splitContainer_BOD.SplitterWidth = 5;
            splitContainer_BOD.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 745);
            Controls.Add(splitContainer_BOD);
            Controls.Add(panelPredTop_BOD);
            Controls.Add(panelTop_BOD);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(940, 782);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 20 | Белоусова Ольга";
            Load += FormMain_Load;
            panelTop_BOD.ResumeLayout(false);
            groupBoxTask_BOD.ResumeLayout(false);
            groupBoxTask_BOD.PerformLayout();
            groupBoxInput_BOD.ResumeLayout(false);
            groupBoxInput_BOD.PerformLayout();
            groupBoxOutput_BOD.ResumeLayout(false);
            groupBoxOutput_BOD.PerformLayout();
            panelPredTop_BOD.ResumeLayout(false);
            splitContainer_BOD.Panel1.ResumeLayout(false);
            splitContainer_BOD.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_BOD).EndInit();
            splitContainer_BOD.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panelTop_BOD;
        private Button buttonDone_BOD;
        private Button buttonOpenFile_BOD;
        private Button buttonHelp_BOD;
        private GroupBox groupBoxTask_BOD;
        private TextBox textBoxTask_BOD;
        private GroupBox groupBoxOutput_BOD;
        private GroupBox groupBoxInput_BOD;
        private ToolTip toolTipTask;
        private OpenFileDialog openFileDialogTask;
        private TextBox textBoxInput_BOD;
        private TextBox textBoxOutput_BOD;
        private Panel panelPredTop_BOD;
        private SplitContainer splitContainer_BOD;
    }
}
