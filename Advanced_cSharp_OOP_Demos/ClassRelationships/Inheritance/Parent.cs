using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ClassRelationships.Inheritance
{
    internal class Parent {

        private string _name;

        public string Name {
            get { return _name; } 
            set { this._name = value; } 
        }

        /// <summary>
        /// Parent class default constructor. This constructor actually calls the overloaded
        /// constructor <see cref="ConsoleApp1.ClassRelationships.Inheritance.Parent(string)"/>
        /// and passes it a default name string as argument for its name parameter.
        /// </summary>
        public Parent() : this("Default Name") {
            Console.WriteLine("Class Parent default constructor called.");
        }

        /// <summary>
        /// An overloaded constructor of the <see cref="Parent"/> class.
        /// </summary>
        /// <param name="name"></param>
        public Parent(string name) {
            Console.WriteLine("Class Parent overloaded constructor called.");
            this._name = name;
        }


        public virtual void parentMethod() {
            Console.WriteLine("Parent.parentMethod() method called.");
        }

    }
}
