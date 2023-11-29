using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Zadanie1
        string FirstName = "Jarek";
        string SurnameName = "Pawłowski";
        int Age = 25;
        char Gender = 'm';
        string PersonalId = "84025482941";
        string IdWorker = "A12";

        Console.WriteLine(FirstName);
        Console.WriteLine(SurnameName);
        Console.WriteLine(Age);
        Console.WriteLine(Gender);
        Console.WriteLine(PersonalId);
        Console.WriteLine(IdWorker);


        //Zadanie2

        char a = 'A';
        char b = 'B';
        char c = 'C';

        Console.WriteLine(c + "" + "" + b + "" + a);

        //Zadanie3

        int Lenght = 10;
        int Height = 5;

        double diagonal = (Math.Sqrt(Math.Pow(Lenght, 2) + Math.Pow(Height, 2)));

        Console.WriteLine(diagonal);

        //Zadanie4

        int First = 10;
        string Second = "Szkoła Dotneta";
        float Third = 12.5f;

        Console.WriteLine(First);
        Console.WriteLine(Second);
        Console.WriteLine(Third);

        //Zadanie 5
        Console.WriteLine("Insert your firstname: ");
        string FName = Console.ReadLine();

        Console.WriteLine("Insert your Surname: ");
        string SName = Console.ReadLine();

        Console.WriteLine("Insert your Age: ");
        string age = Console.ReadLine();
        int.Parse(age);

        Console.WriteLine("Insert your weight: ");
        string weight = Console.ReadLine();
        float.Parse(weight);

        Console.WriteLine("Insert your height: ");
        string height = Console.ReadLine();
        float.Parse(height);

        Console.WriteLine("Insert your Gender m/f: ");
        string gender = Console.ReadLine();
        char.Parse(gender);

        Console.WriteLine("Data:");
        Console.WriteLine($"Firstname: {FName}");
        Console.WriteLine($"Surname: {SName}");
        Console.WriteLine($"Age: {age} lat");
        Console.WriteLine($"Weight: {weight} kg");
        Console.WriteLine($"Height: {height} cm");
        Console.WriteLine($"Gender: {gender}");
    }
}