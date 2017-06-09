using System;
using System.Collections.Generic;

namespace SkiSoft.ExpenseManager.DataModel
{
  public abstract class Transaction
  {
    public DateTime DateTime { get; set; }
    public decimal AbsoluteValue { get; set; }
    public abstract decimal Value { get; }
    public Category Category { get; set; }
    public List<string> Tags { get; set; }
  }
}