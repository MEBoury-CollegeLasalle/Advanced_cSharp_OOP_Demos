using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ClassRelationships.Association.Composition
{
    internal class Parent {

        private Child _childInstance;

        public Child ChildInstance {
            get { return _childInstance; }
            private set { this._childInstance = value; }
        }


        public Parent() {
            // Composition: the child instance exists only insofar as the parent does:
            // they are tightly associated.
            this.ChildInstance = new Child();
        }
    }
}
