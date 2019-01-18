using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
           string input = Console.ReadLine();

           var companyAndEmployees = new Dictionary<string, List<string>>();

           while (input != "End")
           {
               string[] tockens = input.Split(" -> ");
               string companyName = tockens[0];
               string employeeID = tockens[1];

               if (!companyAndEmployees.ContainsKey(companyName))
               {
                   companyAndEmployees.Add(companyName, new List<string>());
               }
               if (!companyAndEmployees[companyName].Contains(employeeID))
               {
                   companyAndEmployees[companyName].Add(employeeID);
               }

               input = Console.ReadLine();
           }

           foreach (var kvp in companyAndEmployees.OrderBy(w => w.Key))
           {
               System.Console.WriteLine($"{kvp.Key}");
               kvp.Value.ForEach(e => System.Console.WriteLine("-- " + e));
           }
        }
    }
}