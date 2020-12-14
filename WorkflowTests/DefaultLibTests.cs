using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkflowCore.DAL;
using WorkflowCore.DefaultLibs;
using WorkflowCore.Models;
using WorkflowCore.Services;

namespace WorkflowTests
{
    [TestClass]
    public class DefaultLibTests
    {
        [TestMethod]
        public void TestDefaultLib(){
            DefaultLib defaultLib = new DefaultLib();
            Type objType = typeof(DefaultLib);

        // Print the assembly full name.
            Console.WriteLine($"Assembly full name:\n   {objType.Assembly.FullName}.");

            // Print the assembly qualified name.
            Console.WriteLine($"Assembly qualified name:\n   {objType.AssemblyQualifiedName}.");
        }
    }
}
