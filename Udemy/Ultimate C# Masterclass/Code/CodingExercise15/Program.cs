HotelBooking test = new HotelBooking("malik", new DateTime(20,06,03), 5);
Console.WriteLine(test.GuestName);
Console.WriteLine(test.StartDate);
Console.WriteLine(test.EndDate);

Console.ReadKey();

public class HotelBooking
{
    public string GuestName;
    public DateTime StartDate;
    public DateTime EndDate;

    public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
    {
        GuestName = guestName;
        StartDate = startDate;
        EndDate = startDate.AddDays(lengthOfStayInDays);
    }
}