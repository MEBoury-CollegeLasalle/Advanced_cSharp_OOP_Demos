using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesAndAbstractClasses
{
    internal class ConcreteClass : AbstractClass {


        public ConcreteClass() : base() {

        }

        /// <summary>
        /// The final definition of the doSomething method, first declared in the 
        /// <see cref="ConsoleApp1.InterfacesAndAbstractClasses.IInterface"/> interface
        /// and then re-declared as an abstract method in the 
        /// <see cref="ConsoleApp1.InterfacesAndAbstractClasses.AbstractClass"/> abstract class.
        /// <br></br>
        /// Note the use of the override keyword in the method signature.
        /// <br></br>
        /// This method simply calls the protected 
        /// <see cref="ConsoleApp1.InterfacesAndAbstractClasses.AbstractClass.doSomethingInAbstractClass(object)"/>
        /// method that is declared AND defined in <see cref="ConsoleApp1.InterfacesAndAbstractClasses.AbstractClass"/>.
        /// </summary>
        /// <param name="parameter"></param>
        public override void doSomething(object parameter)
        {
            Console.WriteLine("ConcreteClass.doSomething(object) method called.");
            this.doSomethingInAbstractClass(parameter);
        }
    }
}
