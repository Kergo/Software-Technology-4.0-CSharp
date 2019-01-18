using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());

            var users = new Dictionary<string, string>();

            for (int i = 0; i < inputCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                string username = input[1];

                if (command == "register")
                {
                    if (!users.ContainsKey(username))
                    {
                        string licensePlate = input[2];
                        users.Add(username, licensePlate);
                        System.Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                    else
                    {
                        System.Console.WriteLine($"ERROR: already registered with plate number {users[username]}");
                    }
                }
                else
                {
                    if (!users.ContainsKey(username))
                    {
                        System.Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        users.Remove(username);
                        System.Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var kvp in users)
            {
                System.Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}