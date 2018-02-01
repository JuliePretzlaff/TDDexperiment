using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDexperiment;

namespace TDDexperiement.Tests
{
    [TestFixture]
    public class DogTests
    {
        [Test]
        public void DoesDogClassExist()
            {
            Dog dogOne = new Dog();
            Assert.That(dogOne, Is.InstanceOf<Dog>());
            }

        [Test]
        public void DoesDogHaveAge()
        {
            Dog dogOne = new Dog();

            dogOne.ReturnDogAge(2);

            Assert.That(dogOne.DogAge, Is.EqualTo(2));
        }

      
    }
}
