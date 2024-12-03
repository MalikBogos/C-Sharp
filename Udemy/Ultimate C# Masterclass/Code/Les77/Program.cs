var medicalAppointment = new MedicalAppointment("Malik", new DateTime(2024, 5, 4));

//medicalAppointment.Reschedule(new DateTime(2023, 4, 4));

var medicalAppointmentPrinter = new MedicalAppointmentPrinter();
var appointmentUnknownPatient = new MedicalAppointment();

medicalAppointmentPrinter.Print(medicalAppointment);

Console.ReadKey();

class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine("Appointment will take place on " + medicalAppointment.GetDate());
    }
}

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;
    public DateTime GetDate() => _date;


    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    //public MedicalAppointment(string patientName) :
    //    this(patientName, 7) // constructor chaining
    //{
    //}

    //public MedicalAppointment(string patientName) // in case of ambiguity, method without optional parameter will be used
    //{
    //    _patientName = patientName;
    //}

    public MedicalAppointment(string patientName = "Unknown", int daysFromNow = 7) // daysFromNow is an optional parameter
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }

    public void Reschedule(DateTime date)
    {
        _date = date;
        var printer = new MedicalAppointmentPrinter();
        printer.Print(this);
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