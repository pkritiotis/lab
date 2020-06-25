using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace NestedClassXUnitTest
{
    public class UnitTest1
    {
        public static TheoryData<ParentClass> ParentClassData()
        {

            TheoryData<ParentClass> parentClass = new TheoryData<ParentClass>();

            ChildClass childClass = new ChildClass
            {
                ChildName = "firstChildName"
            };

            parentClass.Add(
                new ParentClass()
                {
                    ParentName = "parentName",
                    MyFirstChild = childClass,
                    AllChildren = new List<ChildClass> { childClass }
                });


            return parentClass;
        }

        [Theory]
        [MemberData(nameof(ParentClassData))]
        public void TestParentData(ParentClass parentClass)
        {
            Assert.NotNull(parentClass);
            Assert.NotNull(parentClass.AllChildren);
            Assert.NotNull(parentClass.MyFirstChild);
            Assert.NotEmpty(parentClass.AllChildren);

            Assert.Equal(parentClass.ParentName, "parentName");
            Assert.Equal(parentClass.MyFirstChild.ChildName, "firstChildName");
            Assert.Equal(parentClass.AllChildren.Count, 1);
            Assert.Equal(parentClass.AllChildren.First().ChildName, "firstChildName");
        }
    }
}
