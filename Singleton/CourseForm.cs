namespace Singleton
{
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var HForm = new HumanForm();
            HForm.Show();
        }
        public void AddStudent (Student st)
        {
            StudentListBox.Items.Add(st);
        }
    }
}
