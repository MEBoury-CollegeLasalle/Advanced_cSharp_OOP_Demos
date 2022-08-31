using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesAndAbstractClasses
{
    internal interface IInterface {

        /// <summary>
        /// Declaration, but no implementation of a public method in an interface.
        /// This method MUST be defined later down the class inheritance hiearchy.
        /// </summary>
        /// <returns></returns>
        public void doSomething(object parameter);

    }
}
