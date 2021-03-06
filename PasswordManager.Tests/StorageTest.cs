// <copyright file="StorageTest.cs">Copyright ©  2017</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordManager;

namespace PasswordManager.Tests
{
    /// <summary>This class contains parameterized unit tests for Storage</summary>
    [PexClass(typeof(Storage))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClassAttribute]
    public partial class StorageTest
    {
        /// <summary>Test stub for SerializeEntries(List`1&lt;Entry&gt;, String)</summary>
        [PexMethod]
        public void SerializeEntriesTest(List<Entry> list, string fileName)
        {
            Storage.SerializeEntries(list, fileName);
            // TODO: add assertions to method StorageTest.SerializeEntriesTest(List`1<Entry>, String)
        }
    }
}
