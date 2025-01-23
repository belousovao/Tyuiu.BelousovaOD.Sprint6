using Tyuiu.BelousovaOD.Sprint6.Task6.V20.Lib;
namespace Tyuiu.BelousovaOD.Sprint6.Task6.V20
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            textBoxHelp_BOD = new TextBox();
            buttonOK_BOD = new Button();
            pictureBoxAuthor_BOD = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAuthor_BOD).BeginInit();
            SuspendLayout();
            // 
            // textBoxHelp_BOD
            // 
            textBoxHelp_BOD.Location = new Point(129, 12);
            textBoxHelp_BOD.Multiline = true;
            textBoxHelp_BOD.Name = "textBoxHelp_BOD";
            textBoxHelp_BOD.ReadOnly = true;
            textBoxHelp_BOD.Size = new Size(313, 151);
            textBoxHelp_BOD.TabIndex = 0;
            textBoxHelp_BOD.TabStop = false;
            textBoxHelp_BOD.Text = resources.GetString("textBoxHelp_BOD.Text");
            // 
            // buttonOK_BOD
            // 
            buttonOK_BOD.Cursor = Cursors.Hand;
            buttonOK_BOD.Location = new Point(354, 180);
            buttonOK_BOD.Name = "buttonOK_BOD";
            buttonOK_BOD.Size = new Size(75, 23);
            buttonOK_BOD.TabIndex = 1;
            buttonOK_BOD.Text = "Ок";
            buttonOK_BOD.UseVisualStyleBackColor = true;
            buttonOK_BOD.Click += buttonOK_BOD_Click;
            // 
            // pictureBoxAuthor_BOD
            // 
            pictureBoxAuthor_BOD.Image = (Image)resources.GetObject("pictureBoxAuthor_BOD.Image");
            pictureBoxAuthor_BOD.Location = new Point(12, 12);
            pictureBoxAuthor_BOD.Name = "pictureBoxAuthor_BOD";
            pictureBoxAuthor_BOD.Size = new Size(111, 151);
            pictureBoxAuthor_BOD.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAuthor_BOD.TabIndex = 2;
            pictureBoxAuthor_BOD.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 215);
            Controls.Add(pictureBoxAuthor_BOD);
            Controls.Add(buttonOK_BOD);
            Controls.Add(textBoxHelp_BOD);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAuthor_BOD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox textBoxHelp_BOD;
        private Button buttonOK_BOD;
        private PictureBox pictureBoxAuthor_BOD;
    }
}