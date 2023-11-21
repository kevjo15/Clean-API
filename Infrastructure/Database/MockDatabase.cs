using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database
{
    public class MockDatabase
    {
        public List<Dog> allDogs
        {
            get { return allDogsFromMockDatabase; }
            set { allDogsFromMockDatabase = value; }
        }
        private static List<Dog> allDogsFromMockDatabase = new()
        {
            new Dog
            {
                animalID = Guid.NewGuid(), Name = "Peppe"
            },
            new Dog
            {
                animalID = Guid.NewGuid(), Name = "LeDawg James"
            },
            new Dog
            {
                animalID = Guid.NewGuid(), Name = "Ghost"
            },
            new Dog
            {
                animalID = Guid.NewGuid(), Name = "Kobe"
            },
        };
    }
}
