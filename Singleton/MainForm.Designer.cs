namespace Singleton
{
    partial class MainForm
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
            CourseNameLabel = new Label();
            CreateCourseButton = new Button();
            CourseNameBox = new TextBox();
            CourseListBox = new ListBox();
            CourseDeleteButton = new Button();
            CourseListLabel = new Label();
            StudentListBox = new ListBox();
            TeacherListBox = new ListBox();
            HumanNameBox = new TextBox();
            AddStudentButton = new Button();
            AddTeacherButton = new Button();
            HumanDeleteButton = new Button();
            ExportButton = new Button();
            TeacherLabel = new Label();
            StudentLabel = new Label();
            NameLabel = new Label();
            SuspendLayout();
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Location = new Point(288, 71);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(93, 15);
            CourseNameLabel.TabIndex = 0;
            CourseNameLabel.Text = "Название курса";
            // 
            // CreateCourseButton
            // 
            CreateCourseButton.Location = new Point(288, 127);
            CreateCourseButton.Name = "CreateCourseButton";
            CreateCourseButton.Size = new Size(75, 23);
            CreateCourseButton.TabIndex = 1;
            CreateCourseButton.Text = "Создать курс";
            CreateCourseButton.UseVisualStyleBackColor = true;
            CreateCourseButton.Click += CreateCourseButton_Click;
            // 
            // CourseNameBox
            // 
            CourseNameBox.Location = new Point(288, 89);
            CourseNameBox.Name = "CourseNameBox";
            CourseNameBox.Size = new Size(202, 23);
            CourseNameBox.TabIndex = 2;
            // 
            // CourseListBox
            // 
            CourseListBox.FormattingEnabled = true;
            CourseListBox.ItemHeight = 15;
            CourseListBox.Location = new Point(51, 89);
            CourseListBox.Name = "CourseListBox";
            CourseListBox.Size = new Size(132, 94);
            CourseListBox.TabIndex = 3;
            CourseListBox.SelectedIndexChanged += CourseListBox_SelectedIndexChanged;
            // 
            // CourseDeleteButton
            // 
            CourseDeleteButton.Location = new Point(189, 88);
            CourseDeleteButton.Name = "CourseDeleteButton";
            CourseDeleteButton.Size = new Size(75, 23);
            CourseDeleteButton.TabIndex = 4;
            CourseDeleteButton.Text = "Удалить";
            CourseDeleteButton.UseVisualStyleBackColor = true;
            CourseDeleteButton.Click += CourseDeleteButton_Click;
            // 
            // CourseListLabel
            // 
            CourseListLabel.AutoSize = true;
            CourseListLabel.Location = new Point(51, 71);
            CourseListLabel.Name = "CourseListLabel";
            CourseListLabel.Size = new Size(89, 15);
            CourseListLabel.TabIndex = 5;
            CourseListLabel.Text = "Список курсов";
            // 
            // StudentListBox
            // 
            StudentListBox.FormattingEnabled = true;
            StudentListBox.ItemHeight = 15;
            StudentListBox.Location = new Point(51, 272);
            StudentListBox.Name = "StudentListBox";
            StudentListBox.Size = new Size(132, 94);
            StudentListBox.TabIndex = 6;
            // 
            // TeacherListBox
            // 
            TeacherListBox.FormattingEnabled = true;
            TeacherListBox.ItemHeight = 15;
            TeacherListBox.Location = new Point(51, 233);
            TeacherListBox.Name = "TeacherListBox";
            TeacherListBox.Size = new Size(132, 19);
            TeacherListBox.TabIndex = 7;
            // 
            // HumanNameBox
            // 
            HumanNameBox.Location = new Point(288, 272);
            HumanNameBox.Name = "HumanNameBox";
            HumanNameBox.Size = new Size(202, 23);
            HumanNameBox.TabIndex = 8;
            // 
            // AddStudentButton
            // 
            AddStudentButton.Location = new Point(288, 324);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(75, 42);
            AddStudentButton.TabIndex = 9;
            AddStudentButton.Text = "Добавить студента";
            AddStudentButton.UseVisualStyleBackColor = true;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // AddTeacherButton
            // 
            AddTeacherButton.Location = new Point(389, 325);
            AddTeacherButton.Name = "AddTeacherButton";
            AddTeacherButton.Size = new Size(101, 41);
            AddTeacherButton.TabIndex = 10;
            AddTeacherButton.Text = "Добавить преподавателя";
            AddTeacherButton.UseVisualStyleBackColor = true;
            AddTeacherButton.Click += AddTeacherButton_Click;
            // 
            // HumanDeleteButton
            // 
            HumanDeleteButton.Location = new Point(189, 272);
            HumanDeleteButton.Name = "HumanDeleteButton";
            HumanDeleteButton.Size = new Size(75, 23);
            HumanDeleteButton.TabIndex = 11;
            HumanDeleteButton.Text = "Удалить";
            HumanDeleteButton.UseVisualStyleBackColor = true;
            HumanDeleteButton.Click += HumanDeleteButton_Click;
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(521, 444);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(10, 10);
            ExportButton.TabIndex = 12;
            ExportButton.Text = "Экспортировать в .json";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // TeacherLabel
            // 
            TeacherLabel.AutoSize = true;
            TeacherLabel.Location = new Point(51, 215);
            TeacherLabel.Name = "TeacherLabel";
            TeacherLabel.Size = new Size(91, 15);
            TeacherLabel.TabIndex = 13;
            TeacherLabel.Text = "Преподаватель";
            // 
            // StudentLabel
            // 
            StudentLabel.AutoSize = true;
            StudentLabel.Location = new Point(51, 254);
            StudentLabel.Name = "StudentLabel";
            StudentLabel.Size = new Size(105, 15);
            StudentLabel.TabIndex = 14;
            StudentLabel.Text = "Список студентов";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(288, 254);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(31, 15);
            NameLabel.TabIndex = 15;
            NameLabel.Text = "Имя";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 466);
            Controls.Add(NameLabel);
            Controls.Add(StudentLabel);
            Controls.Add(TeacherLabel);
            Controls.Add(ExportButton);
            Controls.Add(HumanDeleteButton);
            Controls.Add(AddTeacherButton);
            Controls.Add(AddStudentButton);
            Controls.Add(HumanNameBox);
            Controls.Add(TeacherListBox);
            Controls.Add(StudentListBox);
            Controls.Add(CourseListLabel);
            Controls.Add(CourseDeleteButton);
            Controls.Add(CourseListBox);
            Controls.Add(CourseNameBox);
            Controls.Add(CreateCourseButton);
            Controls.Add(CourseNameLabel);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CourseNameLabel;
        private Button CreateCourseButton;
        private TextBox CourseNameBox;
        private ListBox CourseListBox;
        private Button CourseDeleteButton;
        private Label CourseListLabel;
        private ListBox StudentListBox;
        private ListBox TeacherListBox;
        public TextBox HumanNameBox;
        private Button AddStudentButton;
        private Button AddTeacherButton;
        private Button HumanDeleteButton;
        private Button ExportButton;
        private Label TeacherLabel;
        private Label StudentLabel;
        private Label NameLabel;
    }
}