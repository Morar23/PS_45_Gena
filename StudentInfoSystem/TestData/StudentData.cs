using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem.TestData
{
    static public class StudentData
    {
        static public List<Student> TestStudents
        {
            get
            {
                ResetTestStudentData();
                return _testStudents;
            }
            set { }
        }

        static private List<Student> _testStudents;

        static private void ResetTestStudentData()
        {
            if (_testStudents == null)
            {
                _testStudents = new List<Student>
                {
                    new Student
                    {
                        FirstName = "Ivan",
                        SecondName = "Ivanov",
                        LastName = "Stoianov",
                        Faculty = "FCST",
                        Major = "CSE",
                        OKS = "Bachelor",
                        Status = "Редовен",
                        FacNum = "123211112",
                        Course = 3,
                        Stream = 9,
                        Group = 45,
                    },
                    new Student
                    {
                        FirstName = "Gena",
                        SecondName = "Morar",
                        LastName = "Cys",
                        Faculty = "EF",
                        Major = "ABC",
                        OKS = "Bachelor",
                        Status = "Редовен",
                        FacNum = "123220018",
                        Course = 1,
                        Stream = 9,
                        Group = 45,
                    },
                    new Student
                    {
                        FirstName = "Maik",
                        SecondName = "Maik",
                        LastName = "Maik",
                        Faculty = "FCST",
                        Major = "CSE",
                        OKS = "Bachelor",
                        Status = "Редовен",
                        FacNum = "123211111",
                        Course = 3,
                        Stream = 9,
                        Group = 45,
                    },
                };
            }
        }
    }
}
