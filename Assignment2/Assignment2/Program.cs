namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.AcceptDetails();
            student.PrintDetails();
        }

        public struct Student
        {
            private string _name;
            private int _age;
            private char _div;
            private int _std;
            private bool _gender;
            private double _marks;

            public Student()
            {
                _name = "";
                _age = 0;
                _div = ' ';
                _std = 0;
                _gender = true;
                _marks = 0.0;

            }

            public Student(string name , int age , char div, int std, bool gender , double marks)
            {
                _name = name;
                _age = age;
                _div = div;
                _std = std;
                _gender = gender;
                _marks = marks;
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public int Age
            {
                get { return _age; }
                set { _age = value; }
            }

            public char Div
            {
                get { return _div; }
                set { _div = value; }
            }

            public int Std
            {
                get { return _std; }
                set { _std = value; }
            }

            public bool Gender
            {
                get { return _gender; }
                set { _gender = value; }
            }

            public double Marks
            {
                get { return _marks; }
                set { _marks = value; }
            }

            public void AcceptDetails()
            {
                Console.WriteLine("Enter the name:- ");
                _name = Console.ReadLine();

                Console.WriteLine("Enter the age:- ");
                _age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the div:- ");
                _div = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter the std:- ");
                _std = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Gender:- ");
                Console.WriteLine("1.For Male   2.For Female:- ");
                int result = Convert.ToInt32(Console.ReadLine());
                if (result == 1)
                {
                    _gender = true;
                }
                else
                {
                    _gender = false;
                }

                Console.WriteLine("Enter the marks:- ");
                double marks = Convert.ToDouble(Console.ReadLine());
            }

            public void PrintDetails()
            {
                Console.WriteLine("Name is:- "+_name);
                Console.WriteLine("Age is:- "+_age);
                Console.WriteLine("Div is:- "+_div);
                Console.WriteLine("Std is:- "+_std);
                Console.WriteLine("Gender is:- "+_gender);
                Console.WriteLine("Marks are:- "+_marks);
            }
        }
    }
}
