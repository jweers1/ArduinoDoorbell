// <copyright file="Form1Test.cs" company="Micron Technology, Inc.">Copyright © Micron Technology, Inc. 2015</copyright>
using System;
using ArduinoDoorbell;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArduinoDoorbell.Tests
{
    /// <summary>This class contains parameterized unit tests for Form1</summary>
    [PexClass(typeof(Form1))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class Form1Test
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public Form1 ConstructorTest()
        {
            Form1 target = new Form1();
            return target;
            // TODO: add assertions to method Form1Test.ConstructorTest()
        }
    }
}
