using System;

namespace Login
{
   public class Program
    {
       public static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            for (int i = username.Length -1; i >= 0; i--)
            {
                password += username[i];
            }
            int counter = 3;
            string loginPass = "";
            do
            {
                loginPass = Console.ReadLine();
                if (password != loginPass)
                {
                     System.Console.WriteLine("Incorrect password. Try again.");
                     counter--;
                }
                else if (password == loginPass)
                {
                    System.Console.WriteLine($"User {username} logged in.");
                    counter = 0;
                }
                if (counter == 0 && password != loginPass)
                {
                    System.Console.WriteLine($"User {username} blocked!");

                }

            } while (counter > 0);
        }
    }
}
