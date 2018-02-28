using System;
using System.Collections.Generic;
using System.Linq;
using AGL.CodeChallenge.Data;
using AGL.CodeChallenge.Data.Entities;
using AGL.CodeChallenge.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass()]
public class PersonRepositoryTests
{
    [TestMethod()]
    public void GetCatsByOwnerGender_Sort_Test()
    {
        /// Sort

        List<Person> Persons = new List<Person> {
                    new Person
                    {
                        Gender = "Male",
                        Pets = new List<Pet>
                        {
                            new Pet
                            {
                                Type = "Cat",
                                Name = "Garfield",
                            },
                            new Pet
                            {
                                Type = "Dog",
                                Name = "Fido",
                            },
                              new Pet
                            {
                                Type = "Cat",
                                Name = "Tom",
                            },
                                new Pet
                            {
                                Type = "Cat",
                                Name = "Jim",
                            },
                                  new Pet
                            {
                                Type = "Cat",
                                Name = "Max",
                            },
                        }
                    },
                    new Person
                    {
                        Gender = "Female",
                        Pets = new List<Pet>
                        {
                            new Pet
                            {
                                Type = "Cat",
                                Name = "Garfield",
                            },
                            new Pet
                            {
                                Type = "Cat",
                                Name = "Tabby",
                            },
                            new Pet
                            {
                                Type = "Cat",
                                Name = "Simba",
                            },
                            new Pet
                            {
                                Type = "Fish",
                                Name = "Nemo",
                            },
                        }

                    }
                };



         var items = PersonRepository.GetCatsByOwnerGender(Persons);

        
        Assert.IsTrue(items.Count == 2);
        Assert.IsTrue(items.Keys.ToList()[0] == "Male");
        Assert.IsTrue(items["Male"].Count == 4);
        Assert.IsTrue(items["Male"][0] == "Garfield");
        Assert.IsTrue(items["Male"][1] == "Jim");
        Assert.IsTrue(items.Keys.ToList()[1] == "Female");
        Assert.IsTrue(items["Female"].Count == 3);
        Assert.IsTrue(items["Female"][0] == "Garfield");
    }

    [TestMethod()]
    public void GetCatsByOwnerGender_NullPets_Test()
    {

        List<Person> Persons = new List<Person> {
                    new Person
                    {
                        Gender = "Female",
                        Pets = null  /// Null pets
                    }
                };
    
        var items = PersonRepository.GetCatsByOwnerGender(Persons);

         Assert.IsTrue(items.Count == 0);
    }

    [TestMethod()]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetCatsByOwnerGender_ArgumentNullException_Test()
    {

        List<Person> Persons = new List<Person> {
                    new Person
                {
                    Gender = null,
                    Pets = new List<Pet>
                    {
                        new Pet
                        {
                            Type = "Cat",
                            Name = "Garfield",
                        },
                    }
                }
        };
  
     
         var items = PersonRepository.GetCatsByOwnerGender(Persons);

        Assert.IsTrue(false);
    }
}

