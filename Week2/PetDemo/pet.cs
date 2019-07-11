using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo
{
    class pet
    {
        public string Name { get; private set; }
        public string Owner { get; private set; }
        public int Age { get; private set; }
        public string Description { get; private set; }
        public bool IsHouseTrained { get; private set; }

        public pet(string name,int age,string description)
        {
            Name=name;
            Owner = "No owner";
            Age = age;
            Description = description;
            IsHouseTrained = false;
        }
       	public void SetOwner(string owner)
        {
            Owner = owner;
        }
       	public void Train()
        {
            IsHouseTrained = true;
        }
        public override string ToString()
        {
            return $"{Name} {Age} {Owner} {Description} {(IsHouseTrained?"train": "not ")}";
        }
    }
}
