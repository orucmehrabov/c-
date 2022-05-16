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
        public bool Guaranty;

        public Student(int id, string firstName, string midleName, string lastName, string groupNo, string type, bool guaranty)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.MidleName = midleName;
            this.LastName = lastName;
            this.GroupNo = groupNo;
            this.Type = type;
            this.Guaranty = guaranty;
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
