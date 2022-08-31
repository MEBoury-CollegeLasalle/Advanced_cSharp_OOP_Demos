using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesAndAbstractClasses
{
    internal abstract class AbstractClass : IInterface {

        protected AbstractClass() {
            // A protected constructor.
        }

        /// <summary>
        /// Like interfaces, an abstract class can contain method declarations that MUST be defined later
        /// down the class inheritance hiearchy by adding the "abstract" keyword to the method declaration.
        /// However, unlike interfaces, abstract classes can contain protected methods (not private ones
        /// as that makes no conceptual sense).
        /// <br></br>
        /// In this example, this method is actually declared in the <see cref="IInterface"/> interface.
        /// declaring it as abstract (or fully defining) it here in the abstract class fulfills the contractual
        /// obligations of the interface.
        /// <br></br>
        /// By simply declaring it as an abstract method, we sort of transfer the onbligation to define it to the
        /// child classes lower down the hierarchy.
        /// </summary>
        /// <param name="parameter"></param>
        public abstract void doSomething(object parameter);

        /// <summary>
        /// This method is simply an example that abstract protected methods can declared
        /// in abstract classes for future
        /// </summary>
        protected abstract void exampleProtectedAbstractMethod();

        
        /// <summary>
        /// An abstract class can also declare AND define methods that are then inherited by
        /// child classes.
        /// </summary>
        /// <param name="parameter"></param>
        protected void doSomethingInAbstractClass(object parameter)
        {
            Console.WriteLine("AbstractClass.doSomethingInAbstractClass(object) method called.");
            this.doSomethingOnlyInTheAbstractClass(parameter);
        }

        /// <summary>
        /// Abstract class can also contain not-abstract private methods, but be aware that due to their
        /// visibility, those can only be used within the abstract class itself.
        /// </summary>
        /// <param name="parameter"></param>
        private void doSomethingOnlyInTheAbstractClass(object parameter)
        {
            Console.WriteLine("AbstractClass.doSomethingOnlyInTheAbstractClass(object) method called.");
            Console.WriteLine(parameter.ToString());
        }

    }
}
