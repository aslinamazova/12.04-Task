using System;
namespace _12._04Task.Models
{
	public class Person
	{
        public string Surname { get; set; }
        public double BirthDay { get; set; }
        private string _name;
        private int _age;

        public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (value.Length>2)
				{
					_name=value;
                    return;
                }
                Console.WriteLine("Give me another name");
            }
		}


        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 16)
                {
                    _age = value;
                    return;
                }
                Console.WriteLine("Give me another age");
            }
        }

    }
}

