namespace TechnicalAssesmentBackendDeveloper;
public class Booking
{
    public string guestname { get; set; }
    public string roomnumber { get; set; }
    public DateTime checkindate { get; set; }
    public DateTime checkoutdate { get; set; }
    public int totaldays { get; set; }
    public double rateperday { get; set; }
    public double discount { get; set; }
    public double totalamount { get; set; }

    public Booking(string name, string room, DateTime checkin, DateTime checkout, double rate, double discountRate)
    {
        guestname = name;
        roomnumber = room;
        checkindate = checkin;
        checkoutdate = checkout;
        rateperday = rate;
        discount = discountRate;
    }
    public void calculateTotalDaysAndAmount()
    {
        totaldays = (checkoutdate - checkindate).Days;
        totalamount = totaldays * rateperday;
        totalamount = totalamount - (totalamount * discount / 100);
    }
    public void printBookingDetails()
    {
        Console.WriteLine("Room Booked for " + guestname);
        Console.WriteLine("Room No: " + roomnumber);
        Console.WriteLine("Check-In: " + checkindate.ToString());
        Console.WriteLine("Check-Out: " + checkoutdate.ToString());
        Console.WriteLine("Total Days: " + totaldays);
        Console.WriteLine("Amount: " + totalamount);
    }

    public async Task LogBookingDetailsAsync()
    {
        // Simulate writing to a log file or remote system
        await Task.Delay(1000);
        Console.WriteLine("Booking log saved.");
    }
    public async Task BookRoom(string name, string room, DateTime checkin, DateTime checkout, double rate, double discountRate)
    {
        await LogBookingDetailsAsync();
    }

    public void Cancel()
    {
        guestname = "";
        roomnumber = "";
        checkindate = DateTime.MinValue;
        checkoutdate = DateTime.MinValue;
        rateperday = 0;
        discount = 0;
        totalamount = 0;

        Console.WriteLine("Booking cancelled");
    }
}

public static class AppHost
{
    public static async Task Run(string[] args)
    {
        Booking b = new Booking("Alice", "101", DateTime.Now, DateTime.Now.AddDays(3), 150.5, 10);
        await b.LogBookingDetailsAsync();
        b.calculateTotalDaysAndAmount();
        b.printBookingDetails();
        b.Cancel();
    }
}