using MyFirstApp.ForeachLoop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyFirstApp.WhileLoop
{
    public partial class frmWhileLopp : Form
    {
        public frmWhileLopp()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var students = new Dictionary<int, Student>();

            Student student = new Student();

            student.StudentId = Convert.ToInt32(txtId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Age = Convert.ToInt32(txtAge.Text);

            students.Add(student.StudentId, student);

            int i = 0;

            while (i < students.Count)
            {
                KeyValuePair<int, Student> entry = students.ElementAt(i);
                if(entry.Value.Name.Equals("Pepe")) MessageBox.Show(entry.Key + " : " + entry.Value.Name + " " + entry.Value.Surname);
                i++;
            }

        }
    }
}
