namespace State.After
{
    /// <summary>
    /// The 'State' interface
    /// The ATMState interface defines the common methods for all the concrete states. 
    /// All the concrete states will implement this interface so that they are going to be interchangeable.
    /// </summary>
    public interface IATMState
    {
        void InsertDebitCard();
        void EjectDebitCard();
        void EnterPin();
        void WithdrawMoney();
    }
}
