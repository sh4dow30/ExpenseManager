namespace SkiSoft.ExpenseManager.DataModel
{
  public class IncomingTransaction : Transaction
  {
    public override decimal Value => AbsoluteValue;
  }
}