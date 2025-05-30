using System.Security.Cryptography.X509Certificates;

namespace Question3
{
    internal class Program
    {
        public static int choice;
        public static int menuList()
        {
            int choice;
            Console.WriteLine("0.Exit");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Sub");
            Console.WriteLine("3.Mul");
            Console.WriteLine("4.Div");
            Console.WriteLine("Enter the choice:- ");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number:- ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number:- ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (choice)
                {
                    case 1:
                        int result = Add(num1, num2);
                        Console.WriteLine(result);
                        break;
                    case 2:
                        int result2 = Sub(num1, num2);
                        Console.WriteLine(result2);
                        break;
                    case 3:
                        int result3 = Mul(num1, num2);
                        Console.WriteLine(result3);
                        break;
                    case 4:
                        int result4 = Div(num1, num2);
                        Console.WriteLine(result4);
                        break;
                       
                }
            } while((choice=menuList())!=0);
            

        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x , int y)
        {
            return x - y;
        }

        public static int Mul(int x , int y)
        {
            return x * y;
        }

        public static int Div(int x , int y)
        {
            return x / y;
        }


    }
}
