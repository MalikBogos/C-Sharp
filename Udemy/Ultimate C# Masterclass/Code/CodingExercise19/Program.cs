DailyAccountState uitprobering = new DailyAccountState(2000, +2900);

Console.WriteLine(uitprobering.Report);
Console.ReadKey();
public class DailyAccountState
{
    public int InitialState { get; }
    public int SumOfOperations { get; }
    
    public DailyAccountState (int initialState, int sumOfOperations)
    {
        InitialState = initialState;
        SumOfOperations = sumOfOperations;
    }

    private int _EndOfDayState;

    public int EndOfDayState
    {
        get { return InitialState + SumOfOperations; }
    }

    private int _report;

    public string Report
    {
        get => $"Day: {DateTime.Now.Day}, month: {DateTime.Now.Month}, year: {DateTime.Now.Year}, initial state: {InitialState}, end of day state: {EndOfDayState}";
    }

}