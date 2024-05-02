using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create
            clsUser AnAddress = new clsUser();
            // test to see that it exists
            Assert.IsNotNull(AnAddress);
        }
    }
}
