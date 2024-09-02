class Pet {
    private int? age;
    private bool isFemale;
    private string? name;

    public void Start() {
        Console.WriteLine("\nGreetings from the Pet class!\n");
        ReadAndSavePetData();
        DisplayPetInfo();
    }
    public void ReadAndSavePetData() {
        Console.Write("What is the name of your pet? ");
        name = Console.ReadLine();
        Console.Write("What is " + name + "'s age? ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Is your dog female? (y/n) ");
        if(Console.ReadLine().Equals('y')) {
            isFemale = true;
        } else {
            isFemale = false;
        }
    }
    public void DisplayPetInfo() {
        Console.WriteLine("Name: " + name + " Age: " + age);
        Console.Write(name + ": ");
        if(isFemale) {
            Console.Write("She's");
        } else {
            Console.Write("He's");
        }
        Console.WriteLine(" such a wonderful pup!");
    }

}