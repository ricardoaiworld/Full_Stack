using System;

namespace Exercise4
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Student s = new Student();
            s.SetAge(21);
            s.ShowAge();
            Teacher t = new Teacher();
            t.SetAge(30);
            t.Explain();

        }
    }
}
