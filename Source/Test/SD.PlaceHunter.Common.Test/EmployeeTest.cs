//-----------------------------------------------------------------------
// <copyright file="EmployeeTest.cs" company="SD">
//     Copyright (c) 2015. All rights reserved.
// </copyright>
// <author>Sergey Dzyuban</author>
//-----------------------------------------------------------------------
namespace SD.PlaceHunter.Common.Test
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Test fixture to check employee container
    /// </summary>
    [TestFixture]
    public class EmployeeTest
    {
        [Test]
        public void Name_SetAndGetValue_Correct()
        {
            Employee employee = new Employee();

            employee.Name = "Smith";

            Assert.AreEqual("Smith", employee.Name);
        }
    }
}
