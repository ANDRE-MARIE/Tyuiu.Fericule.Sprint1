﻿using Tyuiu.Fericule.Sprint1.Task4.V24.Lib;

namespace Tyuiu.Fericule.Sprint1.Task4.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
       
        
             public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 5;
            double wait = 0.124;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, 0.124);
        }
    }
}
        
