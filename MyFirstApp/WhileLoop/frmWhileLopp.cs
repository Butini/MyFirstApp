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
            var students = new Dictionary<Guid, Student>();

            Student student = new Student();

            student.StudentId = Convert.ToInt32(txtId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Age = Convert.ToInt32(txtAge.Text);

            students.Add(student.Guid, student);

            int i = 0;

            while (i < students.Count)
            {
                KeyValuePair<Guid, Student> entry = students.ElementAt(i);
                if(entry.Value.Name.Equals("Pepe")) 
                    MessageBox.Show("Pepe is found: " + entry.Value.Name + " is welcome, and his Guid is " +
                        entry.Value.Guid.ToString());
                i++;
            }

        }
    }
}
