using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNamespace
{
    public class StudentInfo
    {
        private string stuID;
        private string fName;
        private string lName;


        public string StuID
        {
            get { return stuID; }
            set { stuID = value; }

        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }

        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }

        }

        public StudentInfo()
        {
            this.stuID = "None";
            this.fName = "None";
            this.lName = "None";
            MessageBox.Show("Overloaded Method #1");
        }

        public StudentInfo(string lName, string fName)
        {
            this.stuID = "None";
            this.fName = fName;
            this.lName = lName;
            MessageBox.Show("Overloaded Method #2");

        }
        public StudentInfo(string stuID, string lName, string fName)
        {
            this.stuID = stuID; 
            this.fName = fName;
            this.lName = lName;
            MessageBox.Show("Overloaded Method #3");
        }
    }
}
