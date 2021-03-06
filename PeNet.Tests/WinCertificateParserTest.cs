// <copyright file="WinCertificateParserTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PeNet.Parser.Tests
{
    [TestClass]
    [PexClass(typeof(WinCertificateParser))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class WinCertificateParserTest
    {
        [PexMethod]
        internal WinCertificateParser Constructor(byte[] buff, uint offset)
        {
            var target = new WinCertificateParser(buff, offset);
            return target;
            // TODO: add assertions to method WinCertificateParserTest.Constructor(Byte[], UInt32)
        }
    }
}