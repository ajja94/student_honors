using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Gpa
{
    class student
    {
        public string studentName;
        public string major;
        public double gpa;

        public student(string aStudentName, string aMajor, double aGpa)
        {
            studentName = aStudentName;
            major = aMajor;
            gpa = aGpa;

        }
        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
