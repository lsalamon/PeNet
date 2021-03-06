// <copyright file="ImageDebugDirectoryParserTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PeNet.Parser.Tests
{
    [TestClass]
    [PexClass(typeof(ImageDebugDirectoryParser))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ImageDebugDirectoryParserTest
    {
        [PexMethod]
        internal ImageDebugDirectoryParser Constructor(byte[] buff, uint offset)
        {
            var target = new ImageDebugDirectoryParser(buff, offset);
            return target;
            // TODO: add assertions to method ImageDebugDirectoryParserTest.Constructor(Byte[], UInt32)
        }
    }
}