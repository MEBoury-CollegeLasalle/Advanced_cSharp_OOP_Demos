using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ClassRelationships.Inheritance
{
    internal class Child : Parent {

        public Child() : base() {
            Console.WriteLine("Class Child default constructor called.");
        }

        public Child(string name) : base(name) {
            Console.WriteLine("Class Child overloaded constructor called.");
        }

        public void childMethod() {
            Console.WriteLine("Child.childMethod() method called.");
            base.parentMethod();
        }

        /// <summary>
        /// 
        /// </summary>
        public override void parentMethod() {
            Console.WriteLine("Child.parentMethod() overriden method called.");
        }
    }
}
