using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

class Table {
   private int numberOfLegs;
   private String? material;
   private String? typeOfTable;

   private double weight;

   private DateOnly age;

   public void Start() {
    Console.WriteLine("Enter some information about your table");
    tableType();
    tableMaterial();
    tableWeight();
    nmbrOfLegs();
    whenCreated();
    print();
   }

   private void tableType() {
    Console.WriteLine("What type of table is it? ");
    typeOfTable = Console.ReadLine();
   }

   private void tableMaterial() {
    Console.WriteLine("What material is your " + typeOfTable + "-table made of?");
    material = Console.ReadLine();
   }

   private void tableWeight() {
    Console.WriteLine("How many kg does your table weigh?");
    weight = Convert.ToDouble(Console.ReadLine());
   }
   private void nmbrOfLegs() {
    Console.WriteLine("How many legs does your " + typeOfTable + "-table have?");
    numberOfLegs = Convert.ToInt32(Console.ReadLine());
   }

   private void whenCreated() {
    Console.WriteLine("What year was your table built? (YYYY)");
    age = DateOnly.FromDateTime(DateTime.Now);
    age = age.AddYears(-(Convert.ToInt32(Console.ReadLine())));
   }

   private void print() {
    Console.WriteLine("Table information: ");
    Console.WriteLine("Table type: " + tableType);
    Console.WriteLine("Table material: " + material);
    Console.WriteLine("Number of legs: " + numberOfLegs);
    Console.WriteLine("Weight: " + weight);
    Console.WriteLine("Table age: " + age.Year);
   }
}
