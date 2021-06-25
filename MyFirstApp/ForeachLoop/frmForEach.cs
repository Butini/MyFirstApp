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

namespace MyFirstApp.ForeachLoop
{
    public partial class frmForEach : Form
    {
        public frmForEach()
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

            var studentList = new ArrayList();
            //Boxing-Polymorphism -> Agregar un objeto dentro de la Array
            studentList.Add(student);

            foreach (var _student in studentList)
            {
                //Unboxing-Polymorphism -> Sacar un objeto de la Array
                MessageBox.Show(((Student)_student).Name + " " + ((Student)_student).Surname);
            }
        }
    }
}
