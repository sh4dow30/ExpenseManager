namespace SkiSoft.ExpenseManager.DataModel
{
  public class Income : Transaction
  {
    public override decimal Value => AbsoluteValue;
  }
}