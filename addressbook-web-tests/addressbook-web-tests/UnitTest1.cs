﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace addressbook_web_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double total = 900;
            bool vipClient = false ;

            if( total> 1000 || vipClient )
            {
                total = total * 0.9;
                System.Console.Out.Write("Discount 10 %, total amount " + total);
            }
            else
            {
                System.Console.Out.Write("No discount total amount " + total);
            }
        }
    }
}