using System;

namespace HelloWorldApp
{
	public static class ArrayTest
	{
		public static void execute()
		{
            const String LINE_DIVISOR = "=====================================";

            Student[] students = new Student[10];

            for (int i = 0; i < students.Length; i++)
            {
                int sid = (i + 1 + 100);
                students[i] = new Student(sid, "Student " + sid, "M");
            }

            Console.WriteLine(LINE_DIVISOR);

            foreach (Student s in students)
            {
                Console.WriteLine(s.getDetails());
            }

            Console.WriteLine(LINE_DIVISOR);

        }
    }
}

