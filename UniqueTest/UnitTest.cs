using System;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Unique.Unique;

namespace UniqueTest
{
    [TestClass]
    public class UnitTest
    {
        //HashSet

        [TestMethod]
        public void IsUniqueSymbolsInStringHashSet_ABCDEF_ReturnedTrue()
        {
            //arrange
            string str = "ABCDEF";
            bool expected = true;

            //act
            bool actual = IsUniqueSymbolsInStringHashSet(str);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsUniqueSymbolsInStringHashSet_EmptyString_ReturnedTrue()
        {
            //arrange
            string str = "";
            bool expected = true;

            //act
            bool actual = IsUniqueSymbolsInStringHashSet(str);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsUniqueSymbolsInStringHashSet_ABCDEFC_ReturnedFalse()
        {
            //arrange
            string str = "ABCDEFC";
            bool expected = false;

            //act
            bool actual = IsUniqueSymbolsInStringHashSet(str);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsUniqueSymbolsInStringHashSet_Null_ThrowNullReferenceException()
        {
            //arrange
            string str = null;

            //act and assert
            Assert.ThrowsException<NullReferenceException>(() => IsUniqueSymbolsInStringHashSet(str));
        }


        //LINQ
        [TestMethod]
        public void IsUniqueSymbolsInStringLinq_ABCDEF_ReturnedTrue()
        {
            //arrange
            string str = "ABCDEF";
            bool expected = true;

            //act
            bool actual = IsUniqueSymbolsInStringLinq(str);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsUniqueSymbolsInStringLinq_ABCDEFC_ReturnedFalse()
        {
            //arrange
            string str = "ABCDEFC";
            bool expected = false;

            //act
            bool actual = IsUniqueSymbolsInStringLinq(str);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsUniqueSymbolsInStringLinq_EmptyString_ReturnedTrue()
        {
            //arrange
            string str = "";
            bool expected = true;

            //act
            bool actual = IsUniqueSymbolsInStringLinq(str);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsUniqueSymbolsInStringLinq_Null_ThrowNullReferenceException()
        {
            //arrange
            string str = null;

            //act and assert
            Assert.ThrowsException<NullReferenceException>(() => IsUniqueSymbolsInStringLinq(str));
        }
    }
}