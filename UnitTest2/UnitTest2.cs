﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Morgengry;

namespace UnitTest2
{
    [TestClass]
    public class UnitTest2
    {
        Book b1, b2, b3;
        Amulet a11, a12, a13;
        Course c111, c112, c113;


        [TestInitialize]
        public void Init()
        {
            b1 = new Book("1");
            b2 = new Book("2", "Falling in Love with Yourself");
            b3 = new Book("3", "Spirits in the Night", 123.55);


            a11 = new Amulet("11");
            a12 = new Amulet("12", Level.high);
            a13 = new Amulet("13", Level.low, "Capricorn");

            c111 = new Course("Eufori med røg");
            c112 = new Course("Nuru Massage using Chia Oil", 157);
            c113 = new Course("XDDDXDXD", 12);
        }

        [TestMethod]
        public void TestGetValueForBook()
        {
            Assert.AreEqual(0.0, Utility.GetValueOfBook(b1));
            Assert.AreEqual(0.0, Utility.GetValueOfBook(b2));
            Assert.AreEqual(123.55, Utility.GetValueOfBook(b3));
        }

        [TestMethod]
        public void TestGetValueForAmulet()
        {
            Assert.AreEqual(20.0, Utility.GetValueOfAmulet(a11));
            Assert.AreEqual(27.5, Utility.GetValueOfAmulet(a12));
            Assert.AreEqual(12.5, Utility.GetValueOfAmulet(a13));
        }

        [TestMethod]
        public void TestGetValueForCourse()
        {
            Assert.AreEqual(0.0, Utility.GetValueOfCourse(c111));
            Assert.AreEqual(2625.00, Utility.GetValueOfCourse(c112));
            Assert.AreEqual(875.00, Utility.GetValueOfCourse(c113));
        }
    }

}
