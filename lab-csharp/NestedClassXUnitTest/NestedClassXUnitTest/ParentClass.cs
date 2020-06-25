using System;
using System.Collections.Generic;
using System.Text;

namespace NestedClassXUnitTest
{
    public class ParentClass
    {
        public string ParentName { get; set; }
        public ChildClass? MyFirstChild { get; set; }
        public ICollection<ChildClass>? AllChildren { get; set; }
    }
}
