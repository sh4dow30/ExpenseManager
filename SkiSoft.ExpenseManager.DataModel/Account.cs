using System.Collections.Generic;

namespace SkiSoft.ExpenseManager.DataModel
{
  public class Account
  {
    public string Name { get; set; }
    public decimal Balance { get; set; }
    public string Description { get; set; }

    public List<Transaction> Transactions { get; set; }
  }
}