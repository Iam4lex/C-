// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A";
// fraudulentOrderIDs[1] = "B";
// fraudulentOrderIDs[2] = "C";

// // Console.WriteLine(fraudulentOrderIDs[1]);

string[] fraudulentOrderIDs = {"A123" , "B456", "C789"};

// fraudulentOrderIDs[0] ;
// fraudulentOrderIDs[1] ;
// fraudulentOrderIDs[2];
// fraudulentOrderIDs[3]= "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

foreach (string name in fraudulentOrderIDs){
    Console.WriteLine("" + name);
}