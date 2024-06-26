﻿namespace CarTests;

using System.Runtime.CompilerServices;
using Car;

[TestClass]
public class CarTests
{
    //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
    [TestMethod]
    public void EmptyTest() 
    {
        Assert.AreEqual(10,10,.001);
    }
    //TODO: constructor sets gasTankLevel properly
    Car test_car;
    [TestInitialize]
    public void CreateCarObject()
    {
        test_car = new("Chrysler", "200", 15, 23);
    }

    [TestMethod]
    public void TestInitialGasTank() 
    {
        Assert.AreEqual(15, test_car.GasTankLevel, .001);
    }
    //TODO: gasTankLevel is accurate after driving within tank range
    //TODO: gasTankLevel is accurate after attempting to drive past tank range
    //TODO: can't have more gas than tank size, expect an exception
}
