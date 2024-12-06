public class DailyAccountState
{
    public int InitialState { get; }
    public int SumOfOperations { get; }
    public DailyAccountState (int initialState, int sumOfOperations)
    {
        InitialState = initialState;
        SumOfOperations = sumOfOperations;
    }

}