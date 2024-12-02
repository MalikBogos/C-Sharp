var medicalAppointment = new MedicalAppointment("Malik", new DateTime(2024, 5, 4));

// overwrite month and day
medicalAppointment.OverwriteMonthAndDay(2, 9);

// add a given number of months and days
medicalAppointment.MoveByMonthsAndDays(1, 2);

medicalAppointment.print();

Console.ReadKey();

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    public void print()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_patientName);
    }

    public void Reschedule(DateTime date)
    {
        _date = date;
    }

    public void OverwriteMonthAndDay(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day); // method overloading
    }

    public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd) //doesn't work in all cases for example, December + 5 months
    {
        _date = new DateTime(_date.Year,
            _date.Month + monthsToAdd,
            _date.Day + daysToAdd); 
    }
}