using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDexperiment
{
    public class Dog
    {
        //fields
        private string dogName;
        private int dogAge;

        //properties
        public string DogName
        {
            get { return this.dogName; }
            set { this.dogName = value; }
        }

        public int DogAge
        { 
            get { return this.dogAge; }
            set { this.dogAge = value; }
        }

        //constructors
        public Dog()
        {
            //default constructor
        }

        public Dog(string name, int age)
        {
            this.dogName = name;
            this.dogAge = age;
        }

        //methods
        public void ReturnDogAge(int age)
        {
            DogAge = age;
        }


    }
}
