using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12_oop_revision
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent();
            p.field = 0;
            var c = new Child();
            c.field = 0;
        }
    }

    interface IDoSomething
    {

    }

    public class Parent
    {
        // field 
        public int field;
    }
    // inherit from parent and implement an interface 
    public class Child : Parent, IDoSomething
    {

    }
    // Sealed : NO MORE CHILDREN
    sealed class GrandChild : Child
    {

    }
    // Cannot inherit from grandchild as it is sealed
    class Invalid : GrandChild { }
}
