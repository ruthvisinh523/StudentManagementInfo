using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementInfo
{
    public class StudetManagement
    {
        public List<StudentInfo> studentInfos;

        public StudetManagement()
        {
            studentInfos = new List<StudentInfo>();
        }

        public void AddStudent(StudentInfo studentInfo)
        {
            studentInfos.Add(studentInfo);
        }

        public void DisplayStudent()
        {
            foreach (StudentInfo studentInfo in studentInfos)
            {
                Console.WriteLine(studentInfo.Name);
                Console.WriteLine(studentInfo.Mark1);
            }
        }
    }
}
