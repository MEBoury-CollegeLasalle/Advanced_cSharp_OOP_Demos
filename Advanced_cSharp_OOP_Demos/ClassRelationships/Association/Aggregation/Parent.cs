using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ClassRelationships.Association.Aggregation
{
    internal class Parent {

        private Child _childInstance;

        public Child ChildInstance {  
            get { return _childInstance; } 
            private set { this._childInstance = value; } 
        }

        public Parent(Child childInstance) {
            // AGGREGATION: the child comes from somewhere else and is not tightly
            // associated with the class
            this.ChildInstance = childInstance;
        }
    }
}
