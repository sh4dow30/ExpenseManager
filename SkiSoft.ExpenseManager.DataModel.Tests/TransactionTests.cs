using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkiSoft.ExpenseManager.DataModel.Tests
{
  [TestClass]
  public class TransactionTests
  {
    private const decimal c_value = 3.14M;

    [TestMethod]
    public void IncomingTransaction_Value_ReturnAbsoluteValue()
    {
      Transaction incomingTransaction = new Income() { AbsoluteValue = c_value };

      Assert.AreEqual(c_value, incomingTransaction.Value);
    }

    [TestMethod]
    public void OutgoingTransaction_Value_ReturnMinusAbsoluteValue()
    {
      Transaction incomingTransaction = new Expense() { AbsoluteValue = c_value };

      Assert.AreEqual(-c_value, incomingTransaction.Value);
    }
  }
}
