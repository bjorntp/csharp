public class TicketSeller {
    private double amountToPay, price = 100.0;
    private string? name;
    private int numOfAdults, numOfChildren;


    public void Start(){
        Console.WriteLine("Welcome to the KIDS' FAIR!");
        Console.WriteLine("Children get always a 75% discount!");
        ReadInput();
        CalculateAmountTopay();
        ShowResults();
    }

    public void ReadInput(){
        Console.WriteLine("You name please:");
        name = Console.ReadLine();
        Console.WriteLine("Number of adults:");
        numOfAdults = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Number of children:");
        numOfChildren = Convert.ToInt32(Console.ReadLine());
    }
    private void CalculateAmountTopay(){
        amountToPay = numOfAdults * price + numOfChildren * price * 0.25;
    }
    private void ShowResults(){
        Console.WriteLine(" +++ Your receipt +++");
        Console.WriteLine(" +++ Amount to pay " + amountToPay + " +++");
        Console.WriteLine(" +++ Price per ticket " + price + " +++");
        Console.WriteLine();
        Console.WriteLine(" +++ Thank you " + name + " and please come back! +++");

    }
}