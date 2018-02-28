using System;
using System.Collections.Generic;
using System.Linq;
using AGL.CodeChallenge.Data.Entities;

namespace AGL.CodeChallenge.Utility
{
    public static class PersonRepository
    {
        /// <summary>
        /// Get the result value of the task which loads the list of persons from json 
        /// Call function to group and sort cat names 
        /// </summary>
        /// <param name="personWebServiceUrl"></param>
        /// <returns></returns>
        public static Dictionary<string, List<string>> GetCatsByOwnerGenderFromWebService(string personWebServiceUrl)
        {
            List<Person> Persons = PersonDataLoader.GetData(personWebServiceUrl).Result;

            return GetCatsByOwnerGender(Persons);
        }

        /// <summary>
        /// Implementation of logic of grouping the pets by owner's gender where type is cat
        /// and return the sorted names list
        /// </summary>
        /// <param name="Persons"></param>
        /// <returns>dictionary type having gender of owner and list of cat names</returns>
        public static Dictionary<string, List<string>> GetCatsByOwnerGender(List<Person> Persons)
        {
            var result = from person in Persons
                         where person.Pets != null
                         group person by person.Gender into g
                         select new
                         {
                             Gender = g.Key,
                             Pets = g.SelectMany(a => a.Pets)
                             .Where(b => b.Type.Equals("Cat", StringComparison.InvariantCultureIgnoreCase))
                             .OrderBy(b => b.Name)
                             .ToList(),
                         };

            return result.ToDictionary(a => a.Gender, a => a.Pets.Select(n => n.Name).ToList());

        }

    }
}
