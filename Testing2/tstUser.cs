﻿using ClassLibrary;
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
            //create an instance of the new class we want to create
            clsUser AnUser = new clsUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }
    }
}