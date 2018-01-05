namespace SkiSoft.ExpenseManager.DataModel
{
  public class Expense : Transaction
  {
    public override decimal Value => -AbsoluteValue;
  }
}