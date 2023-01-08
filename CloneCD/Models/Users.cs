using System;
namespace CloneCD.Models
{
	public class Users
	{
		string first, last, middle;
		public Users()
		{
		}

        public string First { get => first; set => first = value; }
        public string Last { get => last; set => last = value; }
        public string Middle { get => middle; set => middle = value; }
    }
}

