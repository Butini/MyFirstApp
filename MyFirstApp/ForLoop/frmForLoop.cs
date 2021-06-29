using MyFirstApp.ForeachLoop;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.ForLoop
{
    public partial class frmForLoop : Form
    {
        public frmForLoop()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.StudentId = Convert.ToInt32(txtId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Age = Convert.ToInt32(txtAge.Text);

            //Generic collections
            var studentList = new List<Student>();
    
            studentList.Add(student);

            for (int i = 0; i < studentList.Count; i++)
            {
                //Unboxing-Polymorphism -> Sacar un objeto de la Array
                MessageBox.Show(studentList[i].Name + " " + studentList[i].Surname);
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
