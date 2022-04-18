using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool check1=RightLength(password);
            bool check2 = OnlyLettersAndDigits(password);
            bool check3 = TwoOrMoreDigits(password);

            if (check1 && check2 && check3)
            {
                Console.WriteLine("Password is valid");
            }
            if (check1==false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
            }
            if (check2==false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (check3==false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        private static bool TwoOrMoreDigits(string password)
        {
            int digits = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    digits++;
                }
            }

            if (digits>=2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool OnlyLettersAndDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!Char.IsDigit(password[i]) && !Char.IsLetter(password[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool RightLength(string password)
        {
            return password.Length>=6 && password.Length<=10;
        }
    }
}
