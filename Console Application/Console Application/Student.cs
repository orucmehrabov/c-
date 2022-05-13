using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class Student
    {
        int _Id;
        public string FirstName;
        public string MidleName;
        public string LastName;
        public string GroupNo;
        public string Type;
        public Student(int id, string FirstName, string MidleName, string LastName, string GroupNo, string Type)
        {
            this.Id = id;
            this.FirstName = FirstName;
            this.MidleName = MidleName;
            this.LastName = LastName;
            this.GroupNo = GroupNo;
            this.Type = Type;
        }
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }
    }
}
