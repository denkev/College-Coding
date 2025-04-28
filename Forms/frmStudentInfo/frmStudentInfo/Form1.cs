using System.Xml.Linq;
using System;
using StudentNamespace;
namespace frmStudentInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            string first = firstName.Text;
            string last = lastName.Text;
            string id = studentID.Text;

            StudentInfo s;
            if (!string.IsNullOrWhiteSpace(studentID.Text) && !string.IsNullOrWhiteSpace(studentID.Text))
            {
                s = new StudentInfo(studentID.Text, lastName.Text, firstName.Text);


            }

            else if (!string.IsNullOrWhiteSpace(firstName.Text) && string.IsNullOrWhiteSpace(studentID.Text))
            {
                s = new StudentInfo(lastName.Text, firstName.Text);
            }

            else
            {
                s = new StudentInfo();
            }

            listFirst.Items.Add(s.FName);
            listLast.Items.Add(s.LName);
            listID.Items.Add(s.StuID);


            firstName.Text = "";
            lastName.Text = "";
            studentID.Text = "";
        }

    }
}
