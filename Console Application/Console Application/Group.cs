using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class Group
    {
        public int No;
        Categories categorie;
        public bool IsOnline;
        public int limit;
        public List <Student> students = new List<Student> ();
        public string name;
        public string no;

        public Group(int no, Categories Categorie, bool isOnline, int Limit)
        {
            No = no;
            Categorie = categorie;

            IsOnline = isOnline;
            Limit = limit;

        }
        public List<Student> Students
        {
            get => students;
            set
            {
                if (!IsOnline)
                {
                    limit = 20;
                    students = new List<Student>(limit);
                }
                else
                {
                    limit = 10;
                    students = new List<Student>(limit);
                }
            }
        }
        public void StudentInfo(Student student)
        {
            Console.WriteLine($"First Name : {student.FirstName} \n Midle Name : {student.MidleName} \n Last Name : {student.LastName} \n  Groupno : {student.GroupNo} \n Id : {student.Id} \n Guaranty: {student.Guaranty} ");
        }
    }
}
