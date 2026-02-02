using NUnit.Framework;
using System;

#region UnitTest
[TestFixture]
public class TestCase
{
    [Test]
    public void Test_Deposit_ValidAmount()
    {
        Program account = new Program(20000m);

        account.Deposit(5000m);

        Assert.AreEqual(25000m, account.Balance);
    }

    [Test]
    public void Test_Deposit_NegativeAmount()
    {
        Program account = new Program(5000m);

        var ex = Assert.Throws<Exception>(() => account.Deposit(-20m));

        Assert.AreEqual("Deposit amount cannot be negative", ex.Message);
    }

    [Test]
    public void Test_Withdraw_ValidAmount()
    {
        Program account = new Program(200m);

        account.Withdraw(80m);

        Assert.AreEqual(120m, account.Balance);
    }

    [Test]
    public void Test_Withdraw_InsufficientFunds()
    {
        Program account = new Program(100m);

        var ex = Assert.Throws<Exception>(() => account.Withdraw(150m));

        Assert.AreEqual("Insufficient funds.", ex.Message);
    }
}
#endregion