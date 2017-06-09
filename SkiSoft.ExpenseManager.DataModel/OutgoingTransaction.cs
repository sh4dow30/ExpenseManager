namespace SkiSoft.ExpenseManager.DataModel
{
  public class OutgoingTransaction : Transaction
  {
    public override decimal Value => -AbsoluteValue;
  }
}