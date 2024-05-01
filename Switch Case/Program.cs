// Switch case in number of days

Console.WriteLine("Enter number between 1 - 7");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7){
    Console.WriteLine("Enter a valid number!");
}

else {
    switch (number){
        case 1:
        Console.WriteLine("Monday");
        break;

        case 2:
        Console.WriteLine("Tuesday");
        break ;

        case 3:
        Console.WriteLine("Wednesday");
        break;

        case 4:
        Console.WriteLine("Thursday");
        break;

        case 5:
        Console.WriteLine("Friday");
        break;

        case 6:
        Console.WriteLine("Surtuday");
        break;

        case 7:
        Console.WriteLine("Sunday");
        break;

        default:
        Console.WriteLine("Enter a valid number!");
        break;
    }
}