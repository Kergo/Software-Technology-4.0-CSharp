using System;
using System.Text.RegularExpressions;

namespace PasswordValidator
{
   public class Program
    {
       public static void Main(string[] args)
        {
            PasswordValidator(Console.ReadLine());
        }
        public static void PasswordValidator(string password)
        {           
            bool lengthCheck = LengthChecker(password);
            bool contentCheck = ContentChecker(password);
            bool digitsCheck = DigitsLengthChecker(password);

            if (lengthCheck == false)
            {
                MessagePrinter(1);
            }

            if (contentCheck == false)
            {
                MessagePrinter(2);
            }

            if (digitsCheck == false)
            {
                MessagePrinter(3);
            }
            else
            {
                MessagePrinter();
            }
        }
        public static bool LengthChecker(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ContentChecker(string password)
        {
            Regex regex = new Regex(@"[\W_]");
            return !regex.IsMatch(password);     
        }

        public static bool DigitsLengthChecker(string password)
        {
            int digitsCounter = 0;

            foreach (char ch in password)
            {
                if (ch >= 48 && ch <= 57)
                {
                    digitsCounter++;
                }
            }

            if (digitsCounter > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void MessagePrinter(int msg = 0)
        {
            
            switch (msg)
            {
                case 1:
                System.Console.WriteLine("Password must be between 6 and 10 characters");
                    break;
                case 2:
                System.Console.WriteLine("Password must consist only of letters and digits");
                    break;
                case 3:
                System.Console.WriteLine("Password must have at least 2 digits");
                    break;
                default:
                System.Console.WriteLine("Password is valid");
                break;
            }
        }
    }
}
