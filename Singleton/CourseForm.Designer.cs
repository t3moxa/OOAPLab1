namespace Singleton
{
    partial class CourseForm
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
            saveFileDialog1 = new SaveFileDialog();
            StudentListBox = new ListBox();
            AddButton = new Button();
            DeleteButton = new Button();
            TeacherListBox = new ListBox();
            SuspendLayout();
            // 
            // StudentListBox
            // 
            StudentListBox.FormattingEnabled = true;
            StudentListBox.ItemHeight = 15;
            StudentListBox.Location = new Point(180, 107);
            StudentListBox.Name = "StudentListBox";
            StudentListBox.Size = new Size(120, 94);
            StudentListBox.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(332, 107);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(134, 23);
            AddButton.TabIndex = 1;
            AddButton.Text = "Добавить участника";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(332, 178);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(134, 23);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Удалить участника";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // TeacherListBox
            // 
            TeacherListBox.FormattingEnabled = true;
            TeacherListBox.ItemHeight = 15;
            TeacherListBox.Location = new Point(26, 107);
            TeacherListBox.Name = "TeacherListBox";
            TeacherListBox.Size = new Size(120, 94);
            TeacherListBox.TabIndex = 3;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 580);
            Controls.Add(TeacherListBox);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(StudentListBox);
            Name = "CourseForm";
            Text = "CourseForm";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private ListBox StudentListBox;
        private Button AddButton;
        private Button DeleteButton;
        private ListBox TeacherListBox;
    }
}
