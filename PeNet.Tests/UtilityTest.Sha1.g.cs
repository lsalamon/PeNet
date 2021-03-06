using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="UtilityTest.Sha1.g.cs">Copyright ©  2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace PeNet.Tests
{
    public partial class UtilityTest
    {

[TestMethod]
[PexGeneratedBy(typeof(UtilityTest))]
[PexRaisedException(typeof(ArgumentNullException))]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Sha1ThrowsArgumentNullException929()
{
    string s;
    s = this.Sha1((string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(UtilityTest))]
[PexRaisedException(typeof(ArgumentException))]
        [ExpectedException(typeof(ArgumentException))]
        public void Sha1ThrowsArgumentException457()
{
    string s;
    s = this.Sha1("");
}

[TestMethod]
[PexGeneratedBy(typeof(UtilityTest))]
[PexRaisedException(typeof(ArgumentException))]
        [ExpectedException(typeof(ArgumentException))]
        public void Sha1ThrowsArgumentException508()
{
    string s;
    s = this.Sha1("\0");
}
    }
}
