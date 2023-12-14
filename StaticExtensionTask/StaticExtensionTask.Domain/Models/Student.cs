using System;
namespace StaticExtensionTask.Domain.Models
{
	public class Student
	{
		private static int _id;
		public int Id { get; set; }
		private string Fullname { get; set; }
		private int  Point { get; set; }

		public void StudentInfo ()
		{
			Console.WriteLine($"id:{Id} fullame:{Fullname} point:{Point}");
		}

		public Student(string fullname,int point )
		{
			Id = ++_id;
			Fullname = fullname;
			Point = point;
		}
	}
}

