namespace Singleton
{
    partial class HumanForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fileSystemWatcher1 = new FileSystemWatcher();
            nameBox = new TextBox();
            label1 = new Label();
            AddTeacherButton = new Button();
            AddStudentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(84, 43);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(100, 23);
            nameBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 25);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "Имя";
            label1.Click += label1_Click;
            // 
            // AddTeacherButton
            // 
            AddTeacherButton.Location = new Point(35, 122);
            AddTeacherButton.Name = "AddTeacherButton";
            AddTeacherButton.Size = new Size(100, 51);
            AddTeacherButton.TabIndex = 4;
            AddTeacherButton.Text = "Добавить как преподавателя";
            AddTeacherButton.UseVisualStyleBackColor = true;
            AddTeacherButton.Click += AddTeacherButton_Click;
            // 
            // AddStudentButton
            // 
            AddStudentButton.Location = new Point(141, 122);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(100, 51);
            AddStudentButton.TabIndex = 5;
            AddStudentButton.Text = "Добавить как студента";
            AddStudentButton.UseVisualStyleBackColor = true;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // HumanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 204);
            Controls.Add(AddStudentButton);
            Controls.Add(AddTeacherButton);
            Controls.Add(label1);
            Controls.Add(nameBox);
            Name = "HumanForm";
            Text = "HumanForm";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Label label1;
        private TextBox nameBox;
        private Button AddTeacherButton;
        private Button AddStudentButton;
    }
}