using System;
using System.Collections.Generic;
using System.Configuration;
using AGL.CodeChallenge.Utility;

namespace AGL.CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fetch the WebService URL from app.config
            string personWebServiceUrl = ConfigurationManager.AppSettings["personWebServiceUrl"];

            
            Dictionary<string, List<String>> items = PersonRepository.GetCatsByOwnerGenderFromWebService(personWebServiceUrl);

           WriteCatNamesByOwnersGender(items);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
                     
        }

        /// <summary>
        /// Function to write sorted cat names by owners gender in list format from dictionary
        /// </summary>
        /// <param name="items"></param>

        private static void WriteCatNamesByOwnersGender(Dictionary<string, List<String>> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Key);
                foreach (var name in item.Value)
                {
                    Console.WriteLine("\t{0}", name);
                }
            }
        }
    }
}
