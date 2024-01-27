using System;

namespace HelloWorldApp
{
	public class Student
	{
		public Student(int sid, String name, String gender)
		{
			Sid = sid;
			Name = name;
			Gender = gender;
		}

		public int Sid { get; }

		public String Name { get; set; }

		public String Gender { get; set; }

		public String getDetails()
		{
			return Sid + "\t" + Name + "\t" + Gender;
		}
    }
}

